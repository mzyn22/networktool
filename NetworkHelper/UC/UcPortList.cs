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
            this.comboBoxProtocol.DataSource = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("全部", "ALL"),
                new KeyValuePair<string, string>("TCP", "TCP"),
                new KeyValuePair<string, string>("UDP", "UDP" )
            };
            comboBoxProtocol.DisplayMember = "Key";
            comboBoxProtocol.ValueMember = "Value";
            comboBoxProtocol.SelectedValue = "ALL";

            this.comboBoxIPType.DataSource = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("全部", "ALL"),
                new KeyValuePair<string, string>("IPv4", "IPv4"),
                new KeyValuePair<string, string>("IPv6", "IPv6"),
            };
            comboBoxIPType.DisplayMember = "Key";
            comboBoxIPType.ValueMember = "Value";
            comboBoxIPType.SelectedValue = "IPv4";

            this.comboBoxStatus.DataSource = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("全部", "ALL"),
                new KeyValuePair<string, string>("LISTENING", "LISTENING"),
                new KeyValuePair<string, string>("ESTABLISHED", "ESTABLISHED"),
                new KeyValuePair<string, string>("CLOSE_WAIT", "CLOSE_WAIT"),
                new KeyValuePair<string, string>("SYN_SENT", "SYN_SENT"),
                new KeyValuePair<string, string>("TIME_WAIT", "TIME_WAIT"),
            };
            comboBoxStatus.DisplayMember = "Key";
            comboBoxStatus.ValueMember = "Value";
            comboBoxStatus.SelectedValue = "LISTENING";
        }

        private void ReadNetstatInfo()
        {
            string status = comboBoxStatus.SelectedValue.ToString();
            string iptype = comboBoxIPType.SelectedValue.ToString();
            string protocal = comboBoxProtocol.SelectedValue.ToString();

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
                    try
                    {
                        if ((protocal == spi.Protocal || protocal == "ALL")
                            && (status == "ALL" || status == spi.Status)
                            )
                        {
                            Process ps = Process.GetProcessById(spi.PID);
                            spi.ProcessName = ps.ProcessName;
                            try
                            {
                                spi.FileName = ps.MainModule.FileName;
                            }
                            catch { }
                            port_list.Add(spi);
                        }
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {

                    }
                    catch (ArgumentNullException e)
                    {

                    }
                }
            }



            this.dataGridView1.DataSource = port_list;

            //MessageBox.Show(result);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
