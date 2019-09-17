namespace NetworkHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRefreshDNSCache = new System.Windows.Forms.Button();
            this.buttonQueryPortUse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ucIpConfig1 = new NetworkHelper.UC.UcIpConfig();
            this.ucPortList1 = new NetworkHelper.UC.UcPortList();
            this.ucSystemInfo1 = new NetworkHelper.UC.UcSystemInfo();
            this.ucTools1 = new NetworkHelper.UC.UcTools();
            this.ucProcessInfo1 = new NetworkHelper.UC.UcProcessInfo();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefreshDNSCache
            // 
            this.buttonRefreshDNSCache.Location = new System.Drawing.Point(17, 92);
            this.buttonRefreshDNSCache.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshDNSCache.Name = "buttonRefreshDNSCache";
            this.buttonRefreshDNSCache.Size = new System.Drawing.Size(119, 29);
            this.buttonRefreshDNSCache.TabIndex = 10;
            this.buttonRefreshDNSCache.Text = "刷新DNS缓存";
            this.buttonRefreshDNSCache.UseVisualStyleBackColor = true;
            this.buttonRefreshDNSCache.Click += new System.EventHandler(this.buttonRefreshDNSCache_Click);
            // 
            // buttonQueryPortUse
            // 
            this.buttonQueryPortUse.Location = new System.Drawing.Point(140, 70);
            this.buttonQueryPortUse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryPortUse.Name = "buttonQueryPortUse";
            this.buttonQueryPortUse.Size = new System.Drawing.Size(121, 29);
            this.buttonQueryPortUse.TabIndex = 11;
            this.buttonQueryPortUse.Text = "查看端口占用";
            this.buttonQueryPortUse.UseVisualStyleBackColor = true;
            this.buttonQueryPortUse.Click += new System.EventHandler(this.buttonQueryPortUse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "查看服务状态";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "查看进程";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 19);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "打开记事本";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 55);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 29);
            this.button6.TabIndex = 16;
            this.button6.Text = "打开注册表";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(197, 26);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 29);
            this.button7.TabIndex = 17;
            this.button7.Text = "环境变量";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 566);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucIpConfig1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1097, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP地址";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucPortList1);
            this.tabPage2.Controls.Add(this.buttonQueryPortUse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1097, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "端口占用";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucSystemInfo1);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1097, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "系统信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucTools1);
            this.tabPage4.Controls.Add(this.buttonRefreshDNSCache);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1097, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "工具";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1097, 537);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "服务";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ucProcessInfo1);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1097, 537);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "进程";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ucIpConfig1
            // 
            this.ucIpConfig1.Location = new System.Drawing.Point(8, 8);
            this.ucIpConfig1.Margin = new System.Windows.Forms.Padding(5);
            this.ucIpConfig1.Name = "ucIpConfig1";
            this.ucIpConfig1.Size = new System.Drawing.Size(515, 462);
            this.ucIpConfig1.TabIndex = 0;
            // 
            // ucPortList1
            // 
            this.ucPortList1.Location = new System.Drawing.Point(8, 8);
            this.ucPortList1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPortList1.Name = "ucPortList1";
            this.ucPortList1.Size = new System.Drawing.Size(1081, 521);
            this.ucPortList1.TabIndex = 12;
            // 
            // ucSystemInfo1
            // 
            this.ucSystemInfo1.Location = new System.Drawing.Point(304, 26);
            this.ucSystemInfo1.Name = "ucSystemInfo1";
            this.ucSystemInfo1.Size = new System.Drawing.Size(600, 491);
            this.ucSystemInfo1.TabIndex = 18;
            // 
            // ucTools1
            // 
            this.ucTools1.Location = new System.Drawing.Point(3, 3);
            this.ucTools1.Name = "ucTools1";
            this.ucTools1.Size = new System.Drawing.Size(588, 468);
            this.ucTools1.TabIndex = 17;
            // 
            // ucProcessInfo1
            // 
            this.ucProcessInfo1.Location = new System.Drawing.Point(3, 4);
            this.ucProcessInfo1.Name = "ucProcessInfo1";
            this.ucProcessInfo1.Size = new System.Drawing.Size(629, 530);
            this.ucProcessInfo1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 596);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "网络辅助程序      QQ：178323367";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRefreshDNSCache;
        private System.Windows.Forms.Button buttonQueryPortUse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private UC.UcIpConfig ucIpConfig1;
        private UC.UcPortList ucPortList1;
        private UC.UcSystemInfo ucSystemInfo1;
        private UC.UcProcessInfo ucProcessInfo1;
        private UC.UcTools ucTools1;
    }
}

