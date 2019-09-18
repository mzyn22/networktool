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
using System.Threading;
using NetworkHelper.Common;

namespace NetworkHelper.UC
{
    public partial class UcProcessInfo : UserControl
    {
        public UcProcessInfo()
        {
            InitializeComponent();
        }

        private void UcProcessInfo_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(RefreshProcessInfo), new object());
        }

        private void RefreshProcessInfo(object obj)
        {
            IList<ProcessInfo> processInfos = GetProcessInfo();
            this.dataGridView1.SaveInvoke(() =>
            {
                dataGridView1.DataSource = processInfos;
            });
        }

        private static IList<ProcessInfo> GetProcessInfo()
        {
            var processes = Process.GetProcesses();
            IList<ProcessInfo> processInfos = new List<ProcessInfo>();
            foreach (var process in processes)
            {
                ProcessInfo info = new ProcessInfo();
                info.HandleCount = process.HandleCount;
                info.ID = process.Id;
                try
                {
                    info.FileName = process.MainModule.FileName;
                }
                catch { }
                info.MainWindowHandle = process.MainWindowHandle;
                info.MainWindowTitle = process.MainWindowTitle;
                info.ProcessName = process.ProcessName;
                try
                {
                    info.StartTime = process.StartTime;
                }
                catch { }

                info.ThreadsCount = process.Threads.Count;
                info.WorkingSet64 = process.WorkingSet64;
                try
                {
                    info.TotalProcessorTime = process.TotalProcessorTime;
                }
                catch { }
                processInfos.Add(info);
            }
            return processInfos;
        }
    }
}
