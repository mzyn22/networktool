using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace NetworkHelper.UC
{
    /// <summary>
    /// 在线的设备的IP地址和设备类型
    /// </summary>
    public partial class UcOnlineDevice : UserControl
    {
        public UcOnlineDevice()
        {
            InitializeComponent();

        }

        private void Scan()
        {
            string cmd = "arp.exe";
            string args = "/a";
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            process.StartInfo.FileName = "arp.exe";
            process.StartInfo.Arguments = "/a";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            var output = process.StandardOutput;
            string result = output.ReadToEnd();
            char[] split_chars = new char[] { '\r', '\n' };
            char[] ch_split_chars = new char[] { ' ' };
            string[] lines = result.Split(split_chars, StringSplitOptions.RemoveEmptyEntries);
            IList<Entities.IPMacPair> list = new List<Entities.IPMacPair>();
            foreach (var str in lines)
            {
                Entities.IPMacPair pair = null;
                if (Entities.IPMacPair.TryParse(str, out pair))
                {
                    IPAddress iPAddress = IPAddress.Parse(pair.IP);
                    if (IPAddress.IsLoopback(iPAddress))
                    {
                        continue;
                    }
                    if (pair.IP.StartsWith("10.") && !pair.IP.EndsWith(".255") || pair.IP.StartsWith("192.168.") && !pair.IP.EndsWith(".255"))
                    {
                        bool exists = false;
                        foreach (var a in list)
                        {
                            if (a.IP == pair.IP && a.Mac == pair.Mac)
                            {
                                exists = true;
                            }
                        }
                        if (!exists)
                        {
                            list.Add(pair);
                        }
                    }
                }
            }

            this.dataGridView1.DataSource = list;


        }

        private void UcOnlineDevice_Load(object sender, EventArgs e)
        {
            Scan();
        }
    }
}
