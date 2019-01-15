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
            this.Btn_EditAlarm = new System.Windows.Forms.Button();
            this.Btn_DeleteAlarm = new System.Windows.Forms.Button();
            this.LayoutPanel_AlarmItems = new System.Windows.Forms.FlowLayoutPanel();
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
            this.FPanel_ToolBox.Margin = new System.Windows.Forms.Padding(0);
            this.FPanel_ToolBox.Name = "FPanel_ToolBox";
            this.FPanel_ToolBox.Size = new System.Drawing.Size(684, 49);
            this.FPanel_ToolBox.TabIndex = 0;
            // 
            // Btn_AddAlarm
            // 
            this.Btn_AddAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_AddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_AddAlarm.ForeColor = System.Drawing.Color.Green;
            this.Btn_AddAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddAlarm.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddAlarm.Name = "Btn_AddAlarm";
            this.Btn_AddAlarm.Size = new System.Drawing.Size(123, 46);
            this.Btn_AddAlarm.TabIndex = 0;
            this.Btn_AddAlarm.Text = "添加";
            this.Btn_AddAlarm.UseVisualStyleBackColor = true;
            this.Btn_AddAlarm.Click += new System.EventHandler(this.Btn_AddAlarm_Click);
            // 
            // Btn_EditAlarm
            // 
            this.Btn_EditAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_EditAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_EditAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_EditAlarm.Location = new System.Drawing.Point(123, 0);
            this.Btn_EditAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_EditAlarm.Name = "Btn_EditAlarm";
            this.Btn_EditAlarm.Size = new System.Drawing.Size(123, 46);
            this.Btn_EditAlarm.TabIndex = 0;
            this.Btn_EditAlarm.Text = "编辑";
            this.Btn_EditAlarm.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteAlarm
            // 
            this.Btn_DeleteAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DeleteAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_DeleteAlarm.Location = new System.Drawing.Point(246, 0);
            this.Btn_DeleteAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DeleteAlarm.Name = "Btn_DeleteAlarm";
            this.Btn_DeleteAlarm.Size = new System.Drawing.Size(123, 46);
            this.Btn_DeleteAlarm.TabIndex = 0;
            this.Btn_DeleteAlarm.Text = "删除";
            this.Btn_DeleteAlarm.UseVisualStyleBackColor = true;
            // 
            // LayoutPanel_AlarmItems
            // 
            this.LayoutPanel_AlarmItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel_AlarmItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel_AlarmItems.Location = new System.Drawing.Point(0, 49);
            this.LayoutPanel_AlarmItems.Name = "LayoutPanel_AlarmItems";
            this.LayoutPanel_AlarmItems.Size = new System.Drawing.Size(684, 323);
            this.LayoutPanel_AlarmItems.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.LayoutPanel_AlarmItems);
            this.Controls.Add(this.FPanel_ToolBox);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Alarm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FPanel_ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPanel_ToolBox;
        private System.Windows.Forms.Button Btn_AddAlarm;
        private System.Windows.Forms.Button Btn_EditAlarm;
        private System.Windows.Forms.Button Btn_DeleteAlarm;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel_AlarmItems;
    }
}

