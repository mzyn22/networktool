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
            this.buttonDevice = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonControl = new System.Windows.Forms.Button();
            this.buttonDisk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRecorder = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.buttonRecorder);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buttonDisk);
            this.tabPage1.Controls.Add(this.buttonControl);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonProgram);
            this.tabPage1.Controls.Add(this.buttonDevice);
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
            // buttonDevice
            // 
            this.buttonDevice.Location = new System.Drawing.Point(5, 210);
            this.buttonDevice.Name = "buttonDevice";
            this.buttonDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonDevice.TabIndex = 8;
            this.buttonDevice.Text = "设备管理器";
            this.buttonDevice.UseVisualStyleBackColor = true;
            this.buttonDevice.Click += new System.EventHandler(this.buttonDevice_Click);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(5, 239);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(75, 23);
            this.buttonProgram.TabIndex = 9;
            this.buttonProgram.Text = "程序和功能";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "远程桌面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonControl
            // 
            this.buttonControl.Location = new System.Drawing.Point(5, 297);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(75, 23);
            this.buttonControl.TabIndex = 11;
            this.buttonControl.Text = "控制面板";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // buttonDisk
            // 
            this.buttonDisk.Location = new System.Drawing.Point(86, 297);
            this.buttonDisk.Name = "buttonDisk";
            this.buttonDisk.Size = new System.Drawing.Size(75, 23);
            this.buttonDisk.TabIndex = 12;
            this.buttonDisk.Text = "磁盘管理";
            this.buttonDisk.UseVisualStyleBackColor = true;
            this.buttonDisk.Click += new System.EventHandler(this.buttonDisk_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "组策略";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRecorder
            // 
            this.buttonRecorder.Location = new System.Drawing.Point(86, 239);
            this.buttonRecorder.Name = "buttonRecorder";
            this.buttonRecorder.Size = new System.Drawing.Size(75, 23);
            this.buttonRecorder.TabIndex = 14;
            this.buttonRecorder.Text = "录音机";
            this.buttonRecorder.UseVisualStyleBackColor = true;
            this.buttonRecorder.Click += new System.EventHandler(this.buttonRecorder_Click);
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
        private System.Windows.Forms.Button buttonDevice;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.Button buttonDisk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRecorder;
    }
}
