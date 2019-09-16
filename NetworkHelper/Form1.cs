using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

using NetworkHelper.Common;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;

namespace NetworkHelper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocalIPHelper.GetLocalIPv4Addresses();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            LocalIPHelper.SetNetworkAdapter();
        }

        private void buttonRefreshDNSCache_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.Arguments = "/flushdns";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            var output = process.StandardOutput;
            string result = output.ReadToEnd();
            MessageBox.Show(result);
        }

        private void buttonQueryPortUse_Click(object sender, EventArgs e)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                Console.WriteLine(endPoint.Port);

            }

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.Arguments = "/flushdns";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            var output = process.StandardOutput;
            string result = output.ReadToEnd();
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
