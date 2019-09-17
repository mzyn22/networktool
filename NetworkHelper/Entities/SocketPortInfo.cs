using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkHelper.Entities
{
    internal class SocketPortInfo
    {
        public string Protocal { get; set; }

        public string LocalAddress { get; set; }

        public string OuterAddress { get; set; }

        public string Status { get; set; }

        public string PID { get; set; }

        public string ProcessName { get; set; }

        public static bool TryParse(string portstr, out SocketPortInfo socketPortInfo)
        {
            if (string.IsNullOrWhiteSpace(portstr))
            {
                socketPortInfo = null;
                return false;
            }
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
                socketPortInfo.OuterAddress = items_str[2];
                socketPortInfo.Status = items_str[3];
                socketPortInfo.PID = items_str[4];
                return true;
            }
            else if ("UDP".Equals(items_str[0], StringComparison.OrdinalIgnoreCase))
            {
                socketPortInfo = new SocketPortInfo();
                socketPortInfo.Protocal = items_str[0];
                socketPortInfo.LocalAddress = items_str[1];
                socketPortInfo.OuterAddress = items_str[2];
                socketPortInfo.PID = items_str[3];
                return true;
            }
            else
            {
                socketPortInfo = null;
                return false;
            }

        }
    }
}
