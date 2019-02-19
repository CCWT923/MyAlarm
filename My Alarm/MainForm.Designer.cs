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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.闹钟AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AddAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.FPanel_ToolBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPanel_ToolBox
            // 
            this.FPanel_ToolBox.Controls.Add(this.Btn_AddAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_EditAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_DeleteAlarm);
            resources.ApplyResources(this.FPanel_ToolBox, "FPanel_ToolBox");
            this.FPanel_ToolBox.Name = "FPanel_ToolBox";
            // 
            // Btn_AddAlarm
            // 
            this.Btn_AddAlarm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_AddAlarm, "Btn_AddAlarm");
            this.Btn_AddAlarm.ForeColor = System.Drawing.Color.Green;
            this.Btn_AddAlarm.Image = global::My_Alarm.Properties.Resources.add;
            this.Btn_AddAlarm.Name = "Btn_AddAlarm";
            this.Btn_AddAlarm.UseVisualStyleBackColor = true;
            this.Btn_AddAlarm.Click += new System.EventHandler(this.Btn_AddAlarm_Click);
            // 
            // Btn_EditAlarm
            // 
            this.Btn_EditAlarm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_EditAlarm, "Btn_EditAlarm");
            this.Btn_EditAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_EditAlarm.Name = "Btn_EditAlarm";
            this.Btn_EditAlarm.UseVisualStyleBackColor = true;
            this.Btn_EditAlarm.Click += new System.EventHandler(this.Btn_EditAlarm_Click);
            // 
            // Btn_DeleteAlarm
            // 
            this.Btn_DeleteAlarm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_DeleteAlarm, "Btn_DeleteAlarm");
            this.Btn_DeleteAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_DeleteAlarm.Image = global::My_Alarm.Properties.Resources.delete;
            this.Btn_DeleteAlarm.Name = "Btn_DeleteAlarm";
            this.Btn_DeleteAlarm.UseVisualStyleBackColor = true;
            this.Btn_DeleteAlarm.Click += new System.EventHandler(this.Btn_DeleteAlarm_Click);
            // 
            // LayoutPanel_AlarmItems
            // 
            resources.ApplyResources(this.LayoutPanel_AlarmItems, "LayoutPanel_AlarmItems");
            this.LayoutPanel_AlarmItems.Name = "LayoutPanel_AlarmItems";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // NotifyIcon1
            // 
            resources.ApplyResources(this.NotifyIcon1, "NotifyIcon1");
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.闹钟AToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 闹钟AToolStripMenuItem
            // 
            this.闹钟AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AddAlarm,
            this.toolStripMenuItem1,
            this.MenuItem_Exit});
            this.闹钟AToolStripMenuItem.Name = "闹钟AToolStripMenuItem";
            resources.ApplyResources(this.闹钟AToolStripMenuItem, "闹钟AToolStripMenuItem");
            // 
            // MenuItem_AddAlarm
            // 
            this.MenuItem_AddAlarm.Name = "MenuItem_AddAlarm";
            resources.ApplyResources(this.MenuItem_AddAlarm, "MenuItem_AddAlarm");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            resources.ApplyResources(this.MenuItem_Exit, "MenuItem_Exit");
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            resources.ApplyResources(this.帮助HToolStripMenuItem, "帮助HToolStripMenuItem");
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            resources.ApplyResources(this.MenuItem_About, "MenuItem_About");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayoutPanel_AlarmItems);
            this.Controls.Add(this.FPanel_ToolBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FPanel_ToolBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPanel_ToolBox;
        private System.Windows.Forms.Button Btn_AddAlarm;
        private System.Windows.Forms.Button Btn_EditAlarm;
        private System.Windows.Forms.Button Btn_DeleteAlarm;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel_AlarmItems;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 闹钟AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AddAlarm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
    }
}

