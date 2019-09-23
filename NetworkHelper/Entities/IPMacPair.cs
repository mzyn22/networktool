using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
namespace NetworkHelper.Entities
{
    public class IPMacPair
    {
        public string IP { get; set; }

        public string Mac { get; set; }
        public string HostName { get; internal set; }

        public static bool TryParse(string str, out IPMacPair entity)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                entity = null;
                return false;
            }
            IPMacPair pair = new IPMacPair();
            char[] sep = new char[] { ' ' };
            string[] items = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            if (Common.LocalIPHelper.IsIPv4(items[0]))
            {
                pair.IP = items[0];

                if (Common.LocalIPHelper.IsMac(items[1]))
                {
                    pair.Mac = items[1];
                    entity = pair;
                    return true;
                }
            }
            entity = null;
            return false;
        }
    }
}
