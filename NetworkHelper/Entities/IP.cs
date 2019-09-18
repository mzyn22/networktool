using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkHelper.Entities
{
    internal class IP
    {
        public string AdapterId { get; set; }

        public string Ip { get; set; }

        public string SubnetMask { get; set; }

        public string Gateway { get; set; }

        public string Dns1 { get; set; }

        public string Dns2 { get; set; }
    }
}
