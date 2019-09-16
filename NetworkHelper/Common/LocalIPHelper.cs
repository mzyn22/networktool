using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace NetworkHelper.Common
{
    class LocalIPHelper
    {
        public const string LINK_LOCAL_BLOCK_PREFIX = "169.254";

        public static List<IPAddress> GetLocalIPv4Addresses()
        {
            List<IPAddress> localAddresses = new List<IPAddress>();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();

                UnicastIPAddressInformationCollection localIPs = adapterProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation localIP in localIPs)
                {
                    if (localIP.Address.AddressFamily == AddressFamily.InterNetwork &&
                        !localIP.Address.ToString().StartsWith(LINK_LOCAL_BLOCK_PREFIX))
                    {
                        localAddresses.Add(localIP.Address);
                    }
                }
            }

            return localAddresses;
        }

        public static IEnumerable<KeyValuePair<string, string>> GetNetworkInterfaces()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                yield return new KeyValuePair<string, string>(adapter.Id, adapter.Name);
            }
        }
        public static string GetGatewayAddress(string networkInterfaceId)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Id == networkInterfaceId)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    return adapterProperties.GatewayAddresses.ToString();
                }
            }
            return string.Empty;
        }
        public static string GetDnsAddress(string networkInterfaceId)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Id == networkInterfaceId)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    return adapterProperties.DnsAddresses.ToString();
                }
            }
            return string.Empty;
        }
        public static string GetIPAddress(string networkInterfaceId)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Id == networkInterfaceId)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    UnicastIPAddressInformationCollection localIPs = adapterProperties.UnicastAddresses;
                    string ips = string.Empty;
                    foreach (UnicastIPAddressInformation localIP in localIPs)
                    {
                        if (localIP.Address.AddressFamily == AddressFamily.InterNetwork &&
                            !localIP.Address.ToString().StartsWith(LINK_LOCAL_BLOCK_PREFIX))
                        {
                            ips += localIP.Address.ToString() + ";";
                        }
                    }
                    return ips.TrimEnd(';');
                }
            }
            return string.Empty;
        }

        internal static void SetNetworkAdapter()
        {
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"])
                    continue;

                //设置ip地址和子网掩码 
                inPar = mo.GetMethodParameters("EnableStatic");
                inPar["IPAddress"] = new string[] { "192.168.1.248", "192.168.1.249" };// 1.备用 2.IP
                inPar["SubnetMask"] = new string[] { "255.255.255.0", "255.255.255.0" };
                outPar = mo.InvokeMethod("EnableStatic", inPar, null);

                //设置网关地址 
                inPar = mo.GetMethodParameters("SetGateways");
                inPar["DefaultIPGateway"] = new string[] { "192.168.1.1", "192.168.1.254" }; // 1.网关;2.备用网关
                outPar = mo.InvokeMethod("SetGateways", inPar, null);

                //设置DNS 
                inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                inPar["DNSServerSearchOrder"] = new string[] { "222.222.222.222", "223.5.5.5" }; // 1.DNS 2.备用DNS
                outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                break;
            }
        }

        internal static bool GetIPFromIpSb(out string ip)
        {
            try
            {
                string url = "https://api.ip.sb/ip";
                ip = Common.HttpRequest.HttpResponseGetString(url, timeout: 10 * 1000);
                return GetIp(ip, out ip);
            }
            catch (Exception)
            {
                ip = string.Empty;
                return false;
            }
        }

        internal static bool GetIPFrom360(out string ip)
        {
            try
            {
                string url = "http://ip.360.cn/IPShare/info";
                string result = Common.HttpRequest.HttpResponseGetString(url, timeout: 10 * 1000);
                return GetIp(result, out ip);
            }
            catch (Exception e)
            {
                ip = string.Empty;
                return false;
            }
        }

        internal static bool GetIPFromIPCn(out string ip)
        {
            try
            {
                string url = "http://www.ip.cn";
                string result = Common.HttpRequest.HttpResponseGetString(url, timeout: 10 * 1000);
                return GetIp(result, out ip);
            }
            catch (Exception e)
            {
                ip = string.Empty;
                return false;
            }
        }
        internal static bool GetIPFromNetCn(out string ip)
        {
            try
            {
                string url = "http://www.net.cn/static/customercare/yourip.asp";
                string result = Common.HttpRequest.HttpResponseGetString(url, timeout: 10 * 1000);
                return GetIp(result, out ip);
            }
            catch (Exception e)
            {
                ip = string.Empty;
                return false;
            }
        }
        internal static bool GetIPFromSojson(out string ip)
        {
            try
            {
                string url = "https://www.sojson.com/ip/";
                string result = Common.HttpRequest.HttpResponseGetString(url, timeout: 10 * 1000);
                return GetIp(result, out ip);
            }
            catch (Exception e)
            {
                ip = string.Empty;
                return false;
            }
        }

        internal static bool GetIp(string input, out string ip)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ip = string.Empty;
                return false;
            }
            string patten = @"(?=(\b|\D))(((\d{1,2})|(1\d{1,2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{1,2})|(2[0-4]\d)|(25[0-5]))(?=(\b|\D))";
            Match match = Regex.Match(input, patten);
            if (match.Success)
            {
                ip = match.Value;
                return true;
            }
            else
            {
                ip = string.Empty;
                return false;
            }
        }

    }

}
