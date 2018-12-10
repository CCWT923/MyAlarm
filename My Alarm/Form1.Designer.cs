namespace My_Alarm
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FPanel_ToolBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_AddAlarm = new System.Windows.Forms.Button();
            this.Btn_DeleteAlarm = new System.Windows.Forms.Button();
            this.Btn_EditAlarm = new System.Windows.Forms.Button();
            this.FPanel_ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPanel_ToolBox
            // 
            this.FPanel_ToolBox.Controls.Add(this.Btn_AddAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_EditAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_DeleteAlarm);
            this.FPanel_ToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FPanel_ToolBox.Location = new System.Drawing.Point(0, 0);
            this.FPanel_ToolBox.Name = "FPanel_ToolBox";
            this.FPanel_ToolBox.Size = new System.Drawing.Size(911, 47);
            this.FPanel_ToolBox.TabIndex = 0;
            // 
            // Btn_AddAlarm
            // 
            this.Btn_AddAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_AddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddAlarm.Location = new System.Drawing.Point(3, 3);
            this.Btn_AddAlarm.Name = "Btn_AddAlarm";
            this.Btn_AddAlarm.Size = new System.Drawing.Size(123, 41);
            this.Btn_AddAlarm.TabIndex = 0;
            this.Btn_AddAlarm.Text = "添加";
            this.Btn_AddAlarm.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteAlarm
            // 
            this.Btn_DeleteAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteAlarm.Location = new System.Drawing.Point(261, 3);
            this.Btn_DeleteAlarm.Name = "Btn_DeleteAlarm";
            this.Btn_DeleteAlarm.Size = new System.Drawing.Size(123, 41);
            this.Btn_DeleteAlarm.TabIndex = 0;
            this.Btn_DeleteAlarm.Text = "删除";
            this.Btn_DeleteAlarm.UseVisualStyleBackColor = true;
            // 
            // Btn_EditAlarm
            // 
            this.Btn_EditAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_EditAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditAlarm.Location = new System.Drawing.Point(132, 3);
            this.Btn_EditAlarm.Name = "Btn_EditAlarm";
            this.Btn_EditAlarm.Size = new System.Drawing.Size(123, 41);
            this.Btn_EditAlarm.TabIndex = 0;
            this.Btn_EditAlarm.Text = "编辑";
            this.Btn_EditAlarm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 498);
            this.Controls.Add(this.FPanel_ToolBox);
            this.Name = "MainForm";
            this.Text = "My Alarm";
            this.FPanel_ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPanel_ToolBox;
        private System.Windows.Forms.Button Btn_AddAlarm;
        private System.Windows.Forms.Button Btn_EditAlarm;
        private System.Windows.Forms.Button Btn_DeleteAlarm;
    }
}

