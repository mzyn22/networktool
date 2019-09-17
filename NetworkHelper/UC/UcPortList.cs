using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using NetworkHelper.Entities;

namespace NetworkHelper.UC
{
    public partial class UcPortList : UserControl
    {
        public UcPortList()
        {
            InitializeComponent();
        }

        private void UcPortList_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = new List<string>() { "TCP", "UDP" };
        }

        private void ReadNetstatInfo()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            process.StartInfo.FileName = "netstat";
            process.StartInfo.Arguments = "/ano";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            var output = process.StandardOutput;
            string result = output.ReadToEnd();
            char[] split_chars = new char[] { '\r', '\n' };
            char[] ch_split_chars = new char[] { ' ' };
            string[] lines = result.Split(split_chars, StringSplitOptions.RemoveEmptyEntries);
            IList<SocketPortInfo> port_list = new List<SocketPortInfo>();
            foreach (string li in lines)
            {
                SocketPortInfo spi = null;
                if (SocketPortInfo.TryParse(li, out spi))
                {
                    Console.WriteLine(spi.LocalAddress);
                    Process ps = Process.GetProcessById(spi.PID);
                    spi.ProcessName = ps.ProcessName;
                    port_list.Add(spi);
                }
            }



            this.dataGridView1.DataSource = port_list;

            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadProcessesInfo();
            ReadNetstatInfo();
        }

        private void ReadProcessesInfo()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine(process.ProcessName);
            }
        }
    }
}
