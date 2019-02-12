namespace My_Alarm
{
    partial class RemindWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dragControl1 = new DragControl.DragControl();
            this.Lbl_AlarmTitle = new System.Windows.Forms.Label();
            this.Lbl_AlarmContent = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // Lbl_AlarmTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lbl_AlarmTitle, 2);
            this.Lbl_AlarmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmTitle.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmTitle.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AlarmTitle.Location = new System.Drawing.Point(3, 111);
            this.Lbl_AlarmTitle.Name = "Lbl_AlarmTitle";
            this.Lbl_AlarmTitle.Size = new System.Drawing.Size(1085, 222);
            this.Lbl_AlarmTitle.TabIndex = 0;
            this.Lbl_AlarmTitle.Text = "提醒";
            this.Lbl_AlarmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_AlarmContent
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lbl_AlarmContent, 2);
            this.Lbl_AlarmContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_AlarmContent.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AlarmContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_AlarmContent.Location = new System.Drawing.Point(3, 333);
            this.Lbl_AlarmContent.Name = "Lbl_AlarmContent";
            this.Lbl_AlarmContent.Size = new System.Drawing.Size(1085, 111);
            this.Lbl_AlarmContent.TabIndex = 0;
            this.Lbl_AlarmContent.Text = "label1";
            this.Lbl_AlarmContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(548, 502);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(540, 50);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmContent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Close, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 555);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // RemindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemindWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemindWindow";
            this.Load += new System.EventHandler(this.RemindWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DragControl.DragControl dragControl1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_AlarmContent;
        private System.Windows.Forms.Label Lbl_AlarmTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}