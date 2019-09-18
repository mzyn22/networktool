using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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


        }

        private void UcOnlineDevice_Load(object sender, EventArgs e)
        {
            Scan();
        }
    }
}
