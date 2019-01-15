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
            this.Lbl_AlarmTitle = new System.Windows.Forms.Label();
            this.Lbl_AlarmDate = new System.Windows.Forms.Label();
            this.Lbl_Number = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(0, 0);
            this.Panel_Background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(451, 41);
            this.Panel_Background.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Number, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_AlarmTitle
            // 
            this.Lbl_AlarmTitle.AutoSize = true;
            this.Lbl_AlarmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmTitle.Location = new System.Drawing.Point(43, 0);
            this.Lbl_AlarmTitle.Name = "Lbl_AlarmTitle";
            this.Lbl_AlarmTitle.Size = new System.Drawing.Size(199, 41);
            this.Lbl_AlarmTitle.TabIndex = 0;
            this.Lbl_AlarmTitle.Text = "AlarmTitle";
            this.Lbl_AlarmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_AlarmDate
            // 
            this.Lbl_AlarmDate.AutoSize = true;
            this.Lbl_AlarmDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmDate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmDate.Location = new System.Drawing.Point(248, 0);
            this.Lbl_AlarmDate.Name = "Lbl_AlarmDate";
            this.Lbl_AlarmDate.Size = new System.Drawing.Size(200, 41);
            this.Lbl_AlarmDate.TabIndex = 1;
            this.Lbl_AlarmDate.Text = "AlarmDate";
            this.Lbl_AlarmDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Number
            // 
            this.Lbl_Number.AutoSize = true;
            this.Lbl_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Number.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Number.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Number.Name = "Lbl_Number";
            this.Lbl_Number.Size = new System.Drawing.Size(34, 41);
            this.Lbl_Number.TabIndex = 2;
            this.Lbl_Number.Text = "0";
            this.Lbl_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Background);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AlarmItem";
            this.Size = new System.Drawing.Size(451, 41);
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
        private System.Windows.Forms.Label Lbl_AlarmDate;
        private System.Windows.Forms.Label Lbl_Number;
    }
}
