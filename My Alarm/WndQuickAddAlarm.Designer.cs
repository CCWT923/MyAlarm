namespace My_Alarm
{
    partial class WndQuickAddAlarm
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
            this.TextBox_QuickAlarmInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_QuickAlarmInfo
            // 
            this.TextBox_QuickAlarmInfo.BackColor = System.Drawing.Color.White;
            this.TextBox_QuickAlarmInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_QuickAlarmInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_QuickAlarmInfo.ForeColor = System.Drawing.Color.Black;
            this.TextBox_QuickAlarmInfo.Location = new System.Drawing.Point(12, 37);
            this.TextBox_QuickAlarmInfo.Name = "TextBox_QuickAlarmInfo";
            this.TextBox_QuickAlarmInfo.Size = new System.Drawing.Size(311, 36);
            this.TextBox_QuickAlarmInfo.TabIndex = 0;
            this.TextBox_QuickAlarmInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_QuickAlarmInfo_KeyPress);
            this.TextBox_QuickAlarmInfo.LostFocus += new System.EventHandler(this.TextBox_QuickAlarmInfo_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "快速添加闹钟（例如：10 min，表示10分钟）";
            // 
            // WndQuickAddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_QuickAlarmInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WndQuickAddAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WndQuickAddAlarm";
            this.Load += new System.EventHandler(this.WndQuickAddAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_QuickAlarmInfo;
        private System.Windows.Forms.Label label1;
    }
}