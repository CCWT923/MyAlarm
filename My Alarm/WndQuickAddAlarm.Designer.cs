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
            this.SuspendLayout();
            // 
            // TextBox_QuickAlarmInfo
            // 
            this.TextBox_QuickAlarmInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TextBox_QuickAlarmInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_QuickAlarmInfo.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_QuickAlarmInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox_QuickAlarmInfo.Location = new System.Drawing.Point(12, 10);
            this.TextBox_QuickAlarmInfo.Name = "TextBox_QuickAlarmInfo";
            this.TextBox_QuickAlarmInfo.Size = new System.Drawing.Size(557, 29);
            this.TextBox_QuickAlarmInfo.TabIndex = 0;
            this.TextBox_QuickAlarmInfo.Text = "add 10 m";
            this.TextBox_QuickAlarmInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_QuickAlarmInfo_KeyPress);
            this.TextBox_QuickAlarmInfo.LostFocus += new System.EventHandler(this.TextBox_QuickAlarmInfo_LostFocus);
            // 
            // WndQuickAddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(581, 49);
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
    }
}