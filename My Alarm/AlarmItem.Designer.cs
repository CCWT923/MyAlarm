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
            this.Lbl_AlarmName = new System.Windows.Forms.Label();
            this.Lbl_AlarmContent = new System.Windows.Forms.Label();
            this.Lbl_AlarmDate = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(0, 0);
            this.Panel_Background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(440, 70);
            this.Panel_Background.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmContent, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmDate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_AlarmName
            // 
            this.Lbl_AlarmName.AutoSize = true;
            this.Lbl_AlarmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmName.Location = new System.Drawing.Point(286, 0);
            this.Lbl_AlarmName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AlarmName.Name = "Lbl_AlarmName";
            this.Lbl_AlarmName.Size = new System.Drawing.Size(152, 35);
            this.Lbl_AlarmName.TabIndex = 0;
            this.Lbl_AlarmName.Text = "My Alarm";
            this.Lbl_AlarmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_AlarmContent
            // 
            this.Lbl_AlarmContent.AutoSize = true;
            this.Lbl_AlarmContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmContent.Location = new System.Drawing.Point(287, 35);
            this.Lbl_AlarmContent.Name = "Lbl_AlarmContent";
            this.Lbl_AlarmContent.Size = new System.Drawing.Size(150, 35);
            this.Lbl_AlarmContent.TabIndex = 1;
            this.Lbl_AlarmContent.Text = "label1";
            // 
            // Lbl_AlarmDate
            // 
            this.Lbl_AlarmDate.AutoSize = true;
            this.Lbl_AlarmDate.Location = new System.Drawing.Point(55, 0);
            this.Lbl_AlarmDate.Name = "Lbl_AlarmDate";
            this.Lbl_AlarmDate.Size = new System.Drawing.Size(41, 12);
            this.Lbl_AlarmDate.TabIndex = 2;
            this.Lbl_AlarmDate.Text = "label1";
            // 
            // AlarmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Background);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlarmItem";
            this.Size = new System.Drawing.Size(440, 70);
            this.Panel_Background.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lbl_AlarmName;
        private System.Windows.Forms.Label Lbl_AlarmContent;
        private System.Windows.Forms.Label Lbl_AlarmDate;
    }
}
