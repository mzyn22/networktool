namespace NetworkHelper.UC
{
    partial class UcProcessInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_MainWindowTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_HandleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_MainWindowHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_WorkingSet64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_TotelProcessorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_PID,
            this.column_ProcessName,
            this.column_MainWindowTitle,
            this.column_Threads,
            this.column_HandleCount,
            this.column_MainWindowHandle,
            this.column_FileName,
            this.column_StartTime,
            this.column_WorkingSet64,
            this.column_TotelProcessorTime});
            this.dataGridView1.Location = new System.Drawing.Point(2, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(434, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgv_PID
            // 
            this.dgv_PID.DataPropertyName = "ID";
            this.dgv_PID.HeaderText = "PID";
            this.dgv_PID.Name = "dgv_PID";
            // 
            // column_ProcessName
            // 
            this.column_ProcessName.DataPropertyName = "ProcessName";
            this.column_ProcessName.HeaderText = "进程名";
            this.column_ProcessName.Name = "column_ProcessName";
            // 
            // column_MainWindowTitle
            // 
            this.column_MainWindowTitle.DataPropertyName = "MainWindowTitle";
            this.column_MainWindowTitle.HeaderText = "主窗体名称";
            this.column_MainWindowTitle.Name = "column_MainWindowTitle";
            // 
            // column_Threads
            // 
            this.column_Threads.DataPropertyName = "ThreadsCount";
            this.column_Threads.HeaderText = "线程数";
            this.column_Threads.Name = "column_Threads";
            // 
            // column_HandleCount
            // 
            this.column_HandleCount.DataPropertyName = "HandleCount";
            this.column_HandleCount.HeaderText = "句柄数";
            this.column_HandleCount.Name = "column_HandleCount";
            // 
            // column_MainWindowHandle
            // 
            this.column_MainWindowHandle.DataPropertyName = "MainWindowHandle";
            this.column_MainWindowHandle.HeaderText = "主窗体句柄";
            this.column_MainWindowHandle.Name = "column_MainWindowHandle";
            // 
            // column_FileName
            // 
            this.column_FileName.DataPropertyName = "FileName";
            this.column_FileName.HeaderText = "文件位置";
            this.column_FileName.Name = "column_FileName";
            // 
            // column_StartTime
            // 
            this.column_StartTime.DataPropertyName = "StartTime";
            this.column_StartTime.HeaderText = "启动时间";
            this.column_StartTime.Name = "column_StartTime";
            // 
            // column_WorkingSet64
            // 
            this.column_WorkingSet64.DataPropertyName = "WorkingSet64";
            this.column_WorkingSet64.HeaderText = "工作内存";
            this.column_WorkingSet64.Name = "column_WorkingSet64";
            // 
            // column_TotelProcessorTime
            // 
            this.column_TotelProcessorTime.DataPropertyName = "TotalProcessorTime";
            this.column_TotelProcessorTime.HeaderText = "总CPU时间";
            this.column_TotelProcessorTime.Name = "column_TotelProcessorTime";
            // 
            // UcProcessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcProcessInfo";
            this.Size = new System.Drawing.Size(439, 358);
            this.Load += new System.EventHandler(this.UcProcessInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_MainWindowTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Threads;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_HandleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_MainWindowHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_WorkingSet64;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_TotelProcessorTime;
    }
}
