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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIpInfo = new System.Windows.Forms.TabPage();
            this.tabPageEndPoint = new System.Windows.Forms.TabPage();
            this.tabPageSystemInfo = new System.Windows.Forms.TabPage();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.ucIpConfig1 = new NetworkHelper.UC.UcIpConfig();
            this.ucPortList1 = new NetworkHelper.UC.UcPortList();
            this.ucSystemInfo1 = new NetworkHelper.UC.UcSystemInfo();
            this.ucTools1 = new NetworkHelper.UC.UcTools();
            this.ucProcessInfo1 = new NetworkHelper.UC.UcProcessInfo();
            this.tabPageInnerNetWork = new System.Windows.Forms.TabPage();
            this.ucOnlineDevice1 = new NetworkHelper.UC.UcOnlineDevice();
            this.tabControl1.SuspendLayout();
            this.tabPageIpInfo.SuspendLayout();
            this.tabPageEndPoint.SuspendLayout();
            this.tabPageSystemInfo.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            this.tabPageProcess.SuspendLayout();
            this.tabPageInnerNetWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefreshDNSCache
            // 
            this.buttonRefreshDNSCache.Location = new System.Drawing.Point(13, 74);
            this.buttonRefreshDNSCache.Name = "buttonRefreshDNSCache";
            this.buttonRefreshDNSCache.Size = new System.Drawing.Size(89, 23);
            this.buttonRefreshDNSCache.TabIndex = 10;
            this.buttonRefreshDNSCache.Text = "刷新DNS缓存";
            this.buttonRefreshDNSCache.UseVisualStyleBackColor = true;
            this.buttonRefreshDNSCache.Click += new System.EventHandler(this.buttonRefreshDNSCache_Click);
            // 
            // buttonQueryPortUse
            // 
            this.buttonQueryPortUse.Location = new System.Drawing.Point(105, 56);
            this.buttonQueryPortUse.Name = "buttonQueryPortUse";
            this.buttonQueryPortUse.Size = new System.Drawing.Size(91, 23);
            this.buttonQueryPortUse.TabIndex = 11;
            this.buttonQueryPortUse.Text = "查看端口占用";
            this.buttonQueryPortUse.UseVisualStyleBackColor = true;
            this.buttonQueryPortUse.Click += new System.EventHandler(this.buttonQueryPortUse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "查看服务状态";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "查看进程";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "打开记事本";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "打开注册表";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageIpInfo);
            this.tabControl1.Controls.Add(this.tabPageEndPoint);
            this.tabControl1.Controls.Add(this.tabPageInnerNetWork);
            this.tabControl1.Controls.Add(this.tabPageProcess);
            this.tabControl1.Controls.Add(this.tabPageSystemInfo);
            this.tabControl1.Controls.Add(this.tabPageTools);
            this.tabControl1.Controls.Add(this.tabPageServices);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 453);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPageIpInfo
            // 
            this.tabPageIpInfo.Controls.Add(this.ucIpConfig1);
            this.tabPageIpInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageIpInfo.Name = "tabPageIpInfo";
            this.tabPageIpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIpInfo.Size = new System.Drawing.Size(821, 427);
            this.tabPageIpInfo.TabIndex = 0;
            this.tabPageIpInfo.Text = "IP地址";
            this.tabPageIpInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageEndPoint
            // 
            this.tabPageEndPoint.Controls.Add(this.ucPortList1);
            this.tabPageEndPoint.Controls.Add(this.buttonQueryPortUse);
            this.tabPageEndPoint.Location = new System.Drawing.Point(4, 22);
            this.tabPageEndPoint.Name = "tabPageEndPoint";
            this.tabPageEndPoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndPoint.Size = new System.Drawing.Size(821, 427);
            this.tabPageEndPoint.TabIndex = 1;
            this.tabPageEndPoint.Text = "端口占用";
            this.tabPageEndPoint.UseVisualStyleBackColor = true;
            // 
            // tabPageSystemInfo
            // 
            this.tabPageSystemInfo.Controls.Add(this.ucSystemInfo1);
            this.tabPageSystemInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageSystemInfo.Name = "tabPageSystemInfo";
            this.tabPageSystemInfo.Size = new System.Drawing.Size(821, 427);
            this.tabPageSystemInfo.TabIndex = 2;
            this.tabPageSystemInfo.Text = "系统信息";
            this.tabPageSystemInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageTools
            // 
            this.tabPageTools.Controls.Add(this.ucTools1);
            this.tabPageTools.Controls.Add(this.buttonRefreshDNSCache);
            this.tabPageTools.Controls.Add(this.button5);
            this.tabPageTools.Controls.Add(this.button6);
            this.tabPageTools.Location = new System.Drawing.Point(4, 22);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Size = new System.Drawing.Size(821, 427);
            this.tabPageTools.TabIndex = 3;
            this.tabPageTools.Text = "工具";
            this.tabPageTools.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.button2);
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Size = new System.Drawing.Size(821, 427);
            this.tabPageServices.TabIndex = 4;
            this.tabPageServices.Text = "服务";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // tabPageProcess
            // 
            this.tabPageProcess.Controls.Add(this.ucProcessInfo1);
            this.tabPageProcess.Controls.Add(this.button3);
            this.tabPageProcess.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcess.Name = "tabPageProcess";
            this.tabPageProcess.Size = new System.Drawing.Size(821, 427);
            this.tabPageProcess.TabIndex = 5;
            this.tabPageProcess.Text = "进程";
            this.tabPageProcess.UseVisualStyleBackColor = true;
            // 
            // ucIpConfig1
            // 
            this.ucIpConfig1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ucIpConfig1.Location = new System.Drawing.Point(6, 6);
            this.ucIpConfig1.Margin = new System.Windows.Forms.Padding(4);
            this.ucIpConfig1.Name = "ucIpConfig1";
            this.ucIpConfig1.Size = new System.Drawing.Size(386, 414);
            this.ucIpConfig1.TabIndex = 0;
            // 
            // ucPortList1
            // 
            this.ucPortList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPortList1.Location = new System.Drawing.Point(6, 6);
            this.ucPortList1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPortList1.Name = "ucPortList1";
            this.ucPortList1.Size = new System.Drawing.Size(808, 414);
            this.ucPortList1.TabIndex = 12;
            // 
            // ucSystemInfo1
            // 
            this.ucSystemInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSystemInfo1.Location = new System.Drawing.Point(2, 2);
            this.ucSystemInfo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucSystemInfo1.Name = "ucSystemInfo1";
            this.ucSystemInfo1.Size = new System.Drawing.Size(817, 423);
            this.ucSystemInfo1.TabIndex = 18;
            // 
            // ucTools1
            // 
            this.ucTools1.Location = new System.Drawing.Point(2, 2);
            this.ucTools1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTools1.Name = "ucTools1";
            this.ucTools1.Size = new System.Drawing.Size(441, 374);
            this.ucTools1.TabIndex = 17;
            // 
            // ucProcessInfo1
            // 
            this.ucProcessInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProcessInfo1.Location = new System.Drawing.Point(2, 3);
            this.ucProcessInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.ucProcessInfo1.Name = "ucProcessInfo1";
            this.ucProcessInfo1.Size = new System.Drawing.Size(817, 424);
            this.ucProcessInfo1.TabIndex = 14;
            // 
            // tabPageInnerNetWork
            // 
            this.tabPageInnerNetWork.Controls.Add(this.ucOnlineDevice1);
            this.tabPageInnerNetWork.Location = new System.Drawing.Point(4, 22);
            this.tabPageInnerNetWork.Name = "tabPageInnerNetWork";
            this.tabPageInnerNetWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInnerNetWork.Size = new System.Drawing.Size(821, 427);
            this.tabPageInnerNetWork.TabIndex = 6;
            this.tabPageInnerNetWork.Text = "局域网";
            this.tabPageInnerNetWork.UseVisualStyleBackColor = true;
            // 
            // ucOnlineDevice1
            // 
            this.ucOnlineDevice1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucOnlineDevice1.Location = new System.Drawing.Point(5, 5);
            this.ucOnlineDevice1.Margin = new System.Windows.Forms.Padding(2);
            this.ucOnlineDevice1.Name = "ucOnlineDevice1";
            this.ucOnlineDevice1.Size = new System.Drawing.Size(811, 417);
            this.ucOnlineDevice1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 477);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "网络辅助程序      QQ：178323367";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageIpInfo.ResumeLayout(false);
            this.tabPageEndPoint.ResumeLayout(false);
            this.tabPageSystemInfo.ResumeLayout(false);
            this.tabPageTools.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            this.tabPageProcess.ResumeLayout(false);
            this.tabPageInnerNetWork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRefreshDNSCache;
        private System.Windows.Forms.Button buttonQueryPortUse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageIpInfo;
        private System.Windows.Forms.TabPage tabPageEndPoint;
        private System.Windows.Forms.TabPage tabPageSystemInfo;
        private System.Windows.Forms.TabPage tabPageTools;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageProcess;
        private UC.UcIpConfig ucIpConfig1;
        private UC.UcPortList ucPortList1;
        private UC.UcSystemInfo ucSystemInfo1;
        private UC.UcProcessInfo ucProcessInfo1;
        private UC.UcTools ucTools1;
        private System.Windows.Forms.TabPage tabPageInnerNetWork;
        private UC.UcOnlineDevice ucOnlineDevice1;
    }
}

