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
    public partial class UcTools : UserControl
    {
        public UcTools()
        {
            InitializeComponent();
        }

        private void buttonCmd_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd.exe");
        }

        private void ExecuteCommand(string command, string args = null, string workingDir = null)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = args;
            process.StartInfo.WorkingDirectory = workingDir;
            process.Start();
        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            ExecuteCommand("explorer.exe");
        }

        private void buttonTaskManager_Click(object sender, EventArgs e)
        {
            ExecuteCommand("taskmgr.exe");
        }

        private void buttonDisk_Click(object sender, EventArgs e)
        {
            ExecuteCommand("diskmgr.exe");
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            ExecuteCommand(System.IO.Path.Combine(path, "eventvwr.msc"), "/s");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ExecuteCommand("regedit.exe");
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            string cmd = "compmgmt.msc";
            ExecuteCommand(cmd, "/s", path);
        }

        private void buttonSystemInfo_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            ExecuteCommand("msinfo32.exe", null, path);
        }

        private void buttonSysConfig_Click(object sender, EventArgs e)
        {
            string cmd = "msconfig.exe";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            ExecuteCommand(cmd, "/s", path);
        }
    }
}
