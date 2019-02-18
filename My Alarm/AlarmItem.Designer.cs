namespace My_Alarm
{
    partial class AlarmItem
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
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_AlarmContent = new System.Windows.Forms.Label();
            this.Lbl_AlarmTitle = new System.Windows.Forms.Label();
            this.Lbl_AlarmDate = new System.Windows.Forms.Label();
            this.Lbl_RepeatInterval = new System.Windows.Forms.Label();
            this.ChkBox_AlarmEnableStatus = new System.Windows.Forms.CheckBox();
            this.Panel_Background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Background.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(0, 0);
            this.Panel_Background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(731, 61);
            this.Panel_Background.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmContent, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_RepeatInterval, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChkBox_AlarmEnableStatus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 61);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_AlarmContent
            // 
            this.Lbl_AlarmContent.AutoSize = true;
            this.Lbl_AlarmContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmContent.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_AlarmContent.Location = new System.Drawing.Point(238, 30);
            this.Lbl_AlarmContent.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AlarmContent.Name = "Lbl_AlarmContent";
            this.Lbl_AlarmContent.Size = new System.Drawing.Size(493, 31);
            this.Lbl_AlarmContent.TabIndex = 1;
            this.Lbl_AlarmContent.Text = "AlarmContent";
            this.Lbl_AlarmContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AlarmContent.Click += new System.EventHandler(this.AlarmItem_Click);
            this.Lbl_AlarmContent.MouseEnter += new System.EventHandler(this.AlarmItem_MouseEnter);
            this.Lbl_AlarmContent.MouseLeave += new System.EventHandler(this.AlarmItem_MouseLeave);
            // 
            // Lbl_AlarmTitle
            // 
            this.Lbl_AlarmTitle.AutoSize = true;
            this.Lbl_AlarmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmTitle.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AlarmTitle.Location = new System.Drawing.Point(238, 0);
            this.Lbl_AlarmTitle.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AlarmTitle.Name = "Lbl_AlarmTitle";
            this.Lbl_AlarmTitle.Size = new System.Drawing.Size(493, 30);
            this.Lbl_AlarmTitle.TabIndex = 0;
            this.Lbl_AlarmTitle.Text = "AlarmTitle";
            this.Lbl_AlarmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AlarmTitle.Click += new System.EventHandler(this.AlarmItem_Click);
            this.Lbl_AlarmTitle.MouseEnter += new System.EventHandler(this.AlarmItem_MouseEnter);
            this.Lbl_AlarmTitle.MouseLeave += new System.EventHandler(this.AlarmItem_MouseLeave);
            // 
            // Lbl_AlarmDate
            // 
            this.Lbl_AlarmDate.AutoSize = true;
            this.Lbl_AlarmDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmDate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmDate.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AlarmDate.Location = new System.Drawing.Point(27, 0);
            this.Lbl_AlarmDate.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AlarmDate.Name = "Lbl_AlarmDate";
            this.Lbl_AlarmDate.Size = new System.Drawing.Size(211, 30);
            this.Lbl_AlarmDate.TabIndex = 2;
            this.Lbl_AlarmDate.Text = "Alarm Date";
            this.Lbl_AlarmDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AlarmDate.Click += new System.EventHandler(this.AlarmItem_Click);
            this.Lbl_AlarmDate.MouseEnter += new System.EventHandler(this.AlarmItem_MouseEnter);
            this.Lbl_AlarmDate.MouseLeave += new System.EventHandler(this.AlarmItem_MouseLeave);
            // 
            // Lbl_RepeatInterval
            // 
            this.Lbl_RepeatInterval.AutoSize = true;
            this.Lbl_RepeatInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_RepeatInterval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_RepeatInterval.Location = new System.Drawing.Point(27, 30);
            this.Lbl_RepeatInterval.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RepeatInterval.Name = "Lbl_RepeatInterval";
            this.Lbl_RepeatInterval.Size = new System.Drawing.Size(211, 31);
            this.Lbl_RepeatInterval.TabIndex = 3;
            this.Lbl_RepeatInterval.Text = "RepeatInterval";
            this.Lbl_RepeatInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_RepeatInterval.Click += new System.EventHandler(this.AlarmItem_Click);
            this.Lbl_RepeatInterval.MouseEnter += new System.EventHandler(this.AlarmItem_MouseEnter);
            this.Lbl_RepeatInterval.MouseLeave += new System.EventHandler(this.AlarmItem_MouseLeave);
            // 
            // ChkBox_AlarmEnableStatus
            // 
            this.ChkBox_AlarmEnableStatus.AutoSize = true;
            this.ChkBox_AlarmEnableStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkBox_AlarmEnableStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChkBox_AlarmEnableStatus.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_AlarmEnableStatus.Location = new System.Drawing.Point(4, 4);
            this.ChkBox_AlarmEnableStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ChkBox_AlarmEnableStatus.Name = "ChkBox_AlarmEnableStatus";
            this.tableLayoutPanel1.SetRowSpan(this.ChkBox_AlarmEnableStatus, 2);
            this.ChkBox_AlarmEnableStatus.Size = new System.Drawing.Size(19, 53);
            this.ChkBox_AlarmEnableStatus.TabIndex = 4;
            this.ChkBox_AlarmEnableStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBox_AlarmEnableStatus.UseVisualStyleBackColor = true;
            this.ChkBox_AlarmEnableStatus.CheckedChanged += new System.EventHandler(this.ChkBox_AlarmEnableStatus_CheckedChanged);
            // 
            // AlarmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel_Background);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AlarmItem";
            this.Size = new System.Drawing.Size(731, 61);
            this.Load += new System.EventHandler(this.AlarmItem_Load);
            this.Panel_Background.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_AlarmTitle;
        private System.Windows.Forms.Label Lbl_AlarmContent;
        private System.Windows.Forms.Label Lbl_AlarmDate;
        private System.Windows.Forms.Label Lbl_RepeatInterval;
        private System.Windows.Forms.CheckBox ChkBox_AlarmEnableStatus;
    }
}
