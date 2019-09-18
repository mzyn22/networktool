namespace NetworkHelper.UC
{
    partial class UcTools
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSystemInfo = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonEvent = new System.Windows.Forms.Button();
            this.buttonSysConfig = new System.Windows.Forms.Button();
            this.buttonTaskManager = new System.Windows.Forms.Button();
            this.buttonExplorer = new System.Windows.Forms.Button();
            this.buttonCmd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(436, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSystemInfo);
            this.tabPage1.Controls.Add(this.buttonManagement);
            this.tabPage1.Controls.Add(this.buttonRegister);
            this.tabPage1.Controls.Add(this.buttonEvent);
            this.tabPage1.Controls.Add(this.buttonSysConfig);
            this.tabPage1.Controls.Add(this.buttonTaskManager);
            this.tabPage1.Controls.Add(this.buttonExplorer);
            this.tabPage1.Controls.Add(this.buttonCmd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(428, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "桌面工具";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSystemInfo
            // 
            this.buttonSystemInfo.Location = new System.Drawing.Point(5, 180);
            this.buttonSystemInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSystemInfo.Name = "buttonSystemInfo";
            this.buttonSystemInfo.Size = new System.Drawing.Size(73, 25);
            this.buttonSystemInfo.TabIndex = 7;
            this.buttonSystemInfo.Text = "系统信息";
            this.buttonSystemInfo.UseVisualStyleBackColor = true;
            this.buttonSystemInfo.Click += new System.EventHandler(this.buttonSystemInfo_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.Location = new System.Drawing.Point(5, 155);
            this.buttonManagement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(73, 25);
            this.buttonManagement.TabIndex = 6;
            this.buttonManagement.Text = "计算机管理";
            this.buttonManagement.UseVisualStyleBackColor = true;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(5, 130);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(73, 25);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "注册表";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonEvent
            // 
            this.buttonEvent.Location = new System.Drawing.Point(5, 105);
            this.buttonEvent.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.Size = new System.Drawing.Size(73, 25);
            this.buttonEvent.TabIndex = 4;
            this.buttonEvent.Text = "事件查看器";
            this.buttonEvent.UseVisualStyleBackColor = true;
            this.buttonEvent.Click += new System.EventHandler(this.buttonEvent_Click);
            // 
            // buttonSysConfig
            // 
            this.buttonSysConfig.Location = new System.Drawing.Point(5, 80);
            this.buttonSysConfig.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSysConfig.Name = "buttonSysConfig";
            this.buttonSysConfig.Size = new System.Drawing.Size(73, 25);
            this.buttonSysConfig.TabIndex = 3;
            this.buttonSysConfig.Text = "系统配置";
            this.buttonSysConfig.UseVisualStyleBackColor = true;
            this.buttonSysConfig.Click += new System.EventHandler(this.buttonSysConfig_Click);
            // 
            // buttonTaskManager
            // 
            this.buttonTaskManager.Location = new System.Drawing.Point(5, 55);
            this.buttonTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaskManager.Name = "buttonTaskManager";
            this.buttonTaskManager.Size = new System.Drawing.Size(73, 25);
            this.buttonTaskManager.TabIndex = 2;
            this.buttonTaskManager.Text = "任务管理器";
            this.buttonTaskManager.UseVisualStyleBackColor = true;
            this.buttonTaskManager.Click += new System.EventHandler(this.buttonTaskManager_Click);
            // 
            // buttonExplorer
            // 
            this.buttonExplorer.Location = new System.Drawing.Point(4, 30);
            this.buttonExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorer.Name = "buttonExplorer";
            this.buttonExplorer.Size = new System.Drawing.Size(73, 25);
            this.buttonExplorer.TabIndex = 1;
            this.buttonExplorer.Text = "资源管理器";
            this.buttonExplorer.UseVisualStyleBackColor = true;
            this.buttonExplorer.Click += new System.EventHandler(this.buttonExplorer_Click);
            // 
            // buttonCmd
            // 
            this.buttonCmd.Location = new System.Drawing.Point(4, 5);
            this.buttonCmd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCmd.Name = "buttonCmd";
            this.buttonCmd.Size = new System.Drawing.Size(73, 25);
            this.buttonCmd.TabIndex = 0;
            this.buttonCmd.Text = "命令行";
            this.buttonCmd.UseVisualStyleBackColor = true;
            this.buttonCmd.Click += new System.EventHandler(this.buttonCmd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(428, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "网络工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UcTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcTools";
            this.Size = new System.Drawing.Size(441, 374);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.Button buttonSysConfig;
        private System.Windows.Forms.Button buttonTaskManager;
        private System.Windows.Forms.Button buttonExplorer;
        private System.Windows.Forms.Button buttonCmd;
        private System.Windows.Forms.Button buttonSystemInfo;
    }
}
