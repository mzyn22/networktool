namespace NetworkHelper.UC
{
    partial class UcIpConfig
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
            this.comboBoxNetworkInterface = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNetMask = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInternetIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLocalIpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGateway = new System.Windows.Forms.TextBox();
            this.textBoxDNS2 = new System.Windows.Forms.TextBox();
            this.textBoxDNS1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxNetworkInterface
            // 
            this.comboBoxNetworkInterface.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxNetworkInterface.FormattingEnabled = true;
            this.comboBoxNetworkInterface.Location = new System.Drawing.Point(157, 56);
            this.comboBoxNetworkInterface.Name = "comboBoxNetworkInterface";
            this.comboBoxNetworkInterface.Size = new System.Drawing.Size(156, 24);
            this.comboBoxNetworkInterface.TabIndex = 32;
            this.comboBoxNetworkInterface.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(96, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "网卡：";
            // 
            // textBoxNetMask
            // 
            this.textBoxNetMask.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNetMask.Location = new System.Drawing.Point(157, 124);
            this.textBoxNetMask.Name = "textBoxNetMask";
            this.textBoxNetMask.Size = new System.Drawing.Size(156, 26);
            this.textBoxNetMask.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Ping指定IP";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "互联网IP地址：";
            // 
            // textBoxInternetIpAddress
            // 
            this.textBoxInternetIpAddress.Enabled = false;
            this.textBoxInternetIpAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxInternetIpAddress.Location = new System.Drawing.Point(157, 15);
            this.textBoxInternetIpAddress.Name = "textBoxInternetIpAddress";
            this.textBoxInternetIpAddress.Size = new System.Drawing.Size(156, 26);
            this.textBoxInternetIpAddress.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "本机IP地址：";
            // 
            // textBoxLocalIpAddress
            // 
            this.textBoxLocalIpAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLocalIpAddress.Location = new System.Drawing.Point(157, 90);
            this.textBoxLocalIpAddress.Name = "textBoxLocalIpAddress";
            this.textBoxLocalIpAddress.Size = new System.Drawing.Size(156, 26);
            this.textBoxLocalIpAddress.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "子网掩码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(64, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "默认网关：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "首选DNS服务器：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "备用DNS服务器：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGateway.Location = new System.Drawing.Point(157, 158);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(156, 26);
            this.textBoxGateway.TabIndex = 26;
            // 
            // textBoxDNS2
            // 
            this.textBoxDNS2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDNS2.Location = new System.Drawing.Point(157, 226);
            this.textBoxDNS2.Name = "textBoxDNS2";
            this.textBoxDNS2.Size = new System.Drawing.Size(156, 26);
            this.textBoxDNS2.TabIndex = 28;
            // 
            // textBoxDNS1
            // 
            this.textBoxDNS1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDNS1.Location = new System.Drawing.Point(157, 192);
            this.textBoxDNS1.Name = "textBoxDNS1";
            this.textBoxDNS1.Size = new System.Drawing.Size(156, 26);
            this.textBoxDNS1.TabIndex = 27;
            // 
            // UcIpConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxNetworkInterface);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNetMask);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInternetIpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLocalIpAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGateway);
            this.Controls.Add(this.textBoxDNS2);
            this.Controls.Add(this.textBoxDNS1);
            this.Name = "UcIpConfig";
            this.Size = new System.Drawing.Size(386, 370);
            this.Load += new System.EventHandler(this.UcIpConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNetworkInterface;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNetMask;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInternetIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLocalIpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxGateway;
        private System.Windows.Forms.TextBox textBoxDNS2;
        private System.Windows.Forms.TextBox textBoxDNS1;
    }
}
