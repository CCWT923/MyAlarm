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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FPanel_ToolBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_AddAlarm = new System.Windows.Forms.Button();
            this.Btn_EditAlarm = new System.Windows.Forms.Button();
            this.Btn_DeleteAlarm = new System.Windows.Forms.Button();
            this.LayoutPanel_AlarmItems = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.FPanel_ToolBox.Size = new System.Drawing.Size(561, 42);
            this.FPanel_ToolBox.TabIndex = 0;
            // 
            // Btn_AddAlarm
            // 
            this.Btn_AddAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_AddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_AddAlarm.ForeColor = System.Drawing.Color.Green;
            this.Btn_AddAlarm.Image = global::My_Alarm.Properties.Resources.add;
            this.Btn_AddAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AddAlarm.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddAlarm.Name = "Btn_AddAlarm";
            this.Btn_AddAlarm.Size = new System.Drawing.Size(80, 35);
            this.Btn_AddAlarm.TabIndex = 0;
            this.Btn_AddAlarm.Text = "添加";
            this.Btn_AddAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AddAlarm.UseVisualStyleBackColor = true;
            this.Btn_AddAlarm.Click += new System.EventHandler(this.Btn_AddAlarm_Click);
            // 
            // Btn_EditAlarm
            // 
            this.Btn_EditAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_EditAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_EditAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_EditAlarm.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EditAlarm.Image")));
            this.Btn_EditAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EditAlarm.Location = new System.Drawing.Point(80, 0);
            this.Btn_EditAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_EditAlarm.Name = "Btn_EditAlarm";
            this.Btn_EditAlarm.Size = new System.Drawing.Size(80, 35);
            this.Btn_EditAlarm.TabIndex = 0;
            this.Btn_EditAlarm.Text = "编辑";
            this.Btn_EditAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditAlarm.UseVisualStyleBackColor = true;
            this.Btn_EditAlarm.Click += new System.EventHandler(this.Btn_EditAlarm_Click);
            // 
            // Btn_DeleteAlarm
            // 
            this.Btn_DeleteAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteAlarm.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DeleteAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_DeleteAlarm.Image = global::My_Alarm.Properties.Resources.delete;
            this.Btn_DeleteAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DeleteAlarm.Location = new System.Drawing.Point(160, 0);
            this.Btn_DeleteAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DeleteAlarm.Name = "Btn_DeleteAlarm";
            this.Btn_DeleteAlarm.Size = new System.Drawing.Size(80, 35);
            this.Btn_DeleteAlarm.TabIndex = 0;
            this.Btn_DeleteAlarm.Text = "删除";
            this.Btn_DeleteAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_DeleteAlarm.UseVisualStyleBackColor = true;
            this.Btn_DeleteAlarm.Click += new System.EventHandler(this.Btn_DeleteAlarm_Click);
            // 
            // LayoutPanel_AlarmItems
            // 
            this.LayoutPanel_AlarmItems.AutoScroll = true;
            this.LayoutPanel_AlarmItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutPanel_AlarmItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel_AlarmItems.Location = new System.Drawing.Point(0, 40);
            this.LayoutPanel_AlarmItems.Name = "LayoutPanel_AlarmItems";
            this.LayoutPanel_AlarmItems.Size = new System.Drawing.Size(561, 319);
            this.LayoutPanel_AlarmItems.TabIndex = 1;
            this.LayoutPanel_AlarmItems.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Text = "Free Alarm";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 359);
            this.Controls.Add(this.LayoutPanel_AlarmItems);
            this.Controls.Add(this.FPanel_ToolBox);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FPanel_ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPanel_ToolBox;
        private System.Windows.Forms.Button Btn_AddAlarm;
        private System.Windows.Forms.Button Btn_EditAlarm;
        private System.Windows.Forms.Button Btn_DeleteAlarm;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel_AlarmItems;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
    }
}

