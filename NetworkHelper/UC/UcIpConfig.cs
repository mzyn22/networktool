using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using NetworkHelper.Common;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetworkHelper.UC
{
    public partial class UcIpConfig : UserControl
    {

        private Thread RefreshThread;

        public UcIpConfig()
        {
            InitializeComponent();
        }


        private void RefreshTask()
        {
            while (true)
            {
                SetIpToUI();
                Thread.Sleep(10 * 1000);
            }

        }



        private void UcIpConfig_Load(object sender, EventArgs e)
        {
            RefreshThread = new Thread(RefreshTask);

            RefreshThread.IsBackground = true;
            RefreshThread.Start();

            //var niList = Common.LocalIPHelper.GetNetworkInterfaces();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            IList<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            string id = string.Empty;
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.OperationalStatus == OperationalStatus.Down) continue;
                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    list.Add(new KeyValuePair<string, string>(adapter.Id, adapter.Name));
                    if (adapter.GetIPProperties().GatewayAddresses.Count > 0)
                    {
                        id = adapter.Id;
                    }
                }
            }

            this.comboBoxNetworkInterface.SaveInvoke(() =>
            {
                this.comboBoxNetworkInterface.DataSource = list;
                this.comboBoxNetworkInterface.ValueMember = "Key";
                this.comboBoxNetworkInterface.DisplayMember = "Value";
            });
            comboBoxNetworkInterface.SelectedValue = id;
        }

        /// <summary>
        /// 显示
        /// </summary>
        [System.Diagnostics.DebuggerStepThrough]
        private void SetIpToUI()
        {
            string ip;

            bool result = Common.LocalIPHelper.GetIPFromSojson(out ip)
                || Common.LocalIPHelper.GetIPFromNetCn(out ip)
                || Common.LocalIPHelper.GetIPFromIPCn(out ip)
                || Common.LocalIPHelper.GetIPFrom360(out ip)
                || Common.LocalIPHelper.GetIPFromIpSb(out ip);

            if (result)
            {
                this.textBoxInternetIpAddress.SaveInvoke(() =>
                {
                    this.textBoxInternetIpAddress.Text = ip;
                });
            }

        }

        public const string LINK_LOCAL_BLOCK_PREFIX = "169.254";

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxNetworkInterface.SelectedValue != null)
            {
                string val = comboBoxNetworkInterface.SelectedValue.ToString();
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    if (adapter.Id == val)
                    {
                        IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                        string gateway = "";
                        foreach (var g in adapterProperties.GatewayAddresses)
                        {
                            gateway += g.Address.ToString() + ";";
                        }
                        this.textBoxGateway.Text = gateway.TrimEnd(';');
                        UnicastIPAddressInformationCollection localIPs = adapterProperties.UnicastAddresses;
                        string ips = string.Empty;
                        foreach (UnicastIPAddressInformation localIP in localIPs)
                        {
                            if (localIP.Address.AddressFamily == AddressFamily.InterNetwork &&
                                !localIP.Address.ToString().StartsWith(LINK_LOCAL_BLOCK_PREFIX))
                            {
                                ips += localIP.Address.ToString() + ";";
                                this.textBoxNetMask.Text = localIP.IPv4Mask.ToString();
                            }
                        }
                        this.textBoxLocalIpAddress.Text = ips.TrimEnd(';');
                        string dns1 = null;
                        string dns2 = null;
                        foreach (var dns in adapterProperties.DnsAddresses)
                        {
                            if (dns.AddressFamily == AddressFamily.InterNetwork)
                            {
                                if (dns1 == null)
                                {
                                    dns1 = dns.ToString();
                                }
                                else
                                {
                                    dns2 = dns.ToString();
                                }
                            }
                        }
                        this.textBoxDNS1.Text = dns1 ?? "";
                        this.textBoxDNS2.Text = dns2 ?? "";
                        break;
                    }
                }
            }
        }

    }
}
