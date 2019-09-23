using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace NetworkHelper.Entities
{
    internal class SocketPortInfo
    {
        public string Protocal { get; set; }

        public string LocalAddress { get; set; }

        public string OuterAddress { get; set; }

        public string Status { get; set; }

        public int PID { get; set; }

        public string ProcessName { get; set; }

        public string IP { get; set; }

        public int Port { get; set; }

        public string FileName { get; set; }

        public static bool TryParse(string portstr, out SocketPortInfo socketPortInfo)
        {
            if (string.IsNullOrWhiteSpace(portstr))
            {
                socketPortInfo = null;
                return false;
            }
            try
            {

                char[] ch_split_chars = new char[] { ' ' };
                string[] items_str = portstr.Split(ch_split_chars, StringSplitOptions.RemoveEmptyEntries);
                if (items_str == null || items_str.Length == 0)
                {
                    socketPortInfo = null;
                    return false;
                }
                //解析TCP
                if ("TCP".Equals(items_str[0], StringComparison.OrdinalIgnoreCase))
                {
                    socketPortInfo = new SocketPortInfo();
                    socketPortInfo.Protocal = items_str[0];
                    socketPortInfo.LocalAddress = items_str[1];
                    int port = 0;
                    string ip = "";
                    int index = items_str[1].LastIndexOf(':');
                    ip = items_str[1].Substring(0, index);
                    string str_port = items_str[1].Substring(index + 1);
                    socketPortInfo.IP = ip;
                    if (int.TryParse(str_port, out port))
                    {
                        socketPortInfo.Port = port;
                    }
                    socketPortInfo.OuterAddress = items_str[2];
                    socketPortInfo.Status = items_str[3];
                    int pid = 0;
                    if (int.TryParse(items_str[4], out pid))
                    {
                        socketPortInfo.PID = pid;
                    }

                    return true;
                }
                else if ("UDP".Equals(items_str[0], StringComparison.OrdinalIgnoreCase))
                {
                    socketPortInfo = new SocketPortInfo();
                    socketPortInfo.Protocal = items_str[0];
                    socketPortInfo.LocalAddress = items_str[1];
                    int port = 0;
                    string ip = "";
                    int index = items_str[1].LastIndexOf(':');
                    ip = items_str[1].Substring(0, index);
                    string str_port = items_str[1].Substring(index + 1);
                    socketPortInfo.IP = ip;
                    if (int.TryParse(str_port, out port))
                    {
                        socketPortInfo.Port = port;
                    }
                    socketPortInfo.OuterAddress = items_str[2];
                    int pid = 0;
                    if (int.TryParse(items_str[3], out pid))
                    {
                        socketPortInfo.PID = pid;
                    }
                    return true;
                }
                else
                {
                    socketPortInfo = null;
                    return false;
                }

            }
            catch (Exception e)
            {
                socketPortInfo = null;
                return false;
            }
        }
    }
}