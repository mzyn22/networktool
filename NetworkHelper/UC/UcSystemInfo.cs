using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkHelper.UC
{
    public partial class UcSystemInfo : UserControl
    {
        public UcSystemInfo()
        {
            InitializeComponent();
        }

        private void UcSystemInfo_Load(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("  操作系统版本：");
            stringBuilder.AppendLine(Environment.OSVersion.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("      内部版本：");
            stringBuilder.AppendLine(Environment.Version.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("      系统路径：");
            stringBuilder.AppendLine(Environment.SystemDirectory.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("处理器核心数量：");
            stringBuilder.AppendLine(Environment.ProcessorCount.ToString());
            stringBuilder.AppendLine();
            stringBuilder.Append("  操作系统位数：");
            stringBuilder.AppendLine(Environment.Is64BitOperatingSystem ? "64位" : "32位");
            stringBuilder.AppendLine();
            stringBuilder.Append("当前登录用户名：");
            stringBuilder.AppendLine(Environment.UserName);
            stringBuilder.AppendLine();
            stringBuilder.Append("  系统启动时间：");
            stringBuilder.AppendLine(Common.TimeHelper.GetDayString(Environment.TickCount));
            stringBuilder.AppendLine();
            this.textBox1.Text = stringBuilder.ToString();
        }
    }
}
