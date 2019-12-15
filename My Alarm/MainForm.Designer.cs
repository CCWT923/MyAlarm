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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LayoutPanel_AlarmItems = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_MainAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EditAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_DeleteAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_QuickAddAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_ExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // LayoutPanel_AlarmItems
            // 
            this.LayoutPanel_AlarmItems.AutoScroll = true;
            this.LayoutPanel_AlarmItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel_AlarmItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel_AlarmItems.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel_AlarmItems.Name = "LayoutPanel_AlarmItems";
            this.LayoutPanel_AlarmItems.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.LayoutPanel_AlarmItems.Size = new System.Drawing.Size(561, 359);
            this.LayoutPanel_AlarmItems.TabIndex = 1;
            this.LayoutPanel_AlarmItems.WrapContents = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_MainAlarm,
            this.MenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(561, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_MainAlarm
            // 
            this.MenuItem_MainAlarm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_NewAlarm,
            this.MenuItem_EditAlarm,
            this.MenuItem_DeleteAlarm,
            this.toolStripSeparator1,
            this.MenuItem_QuickAddAlarm,
            this.toolStripMenuItem1,
            this.MenuItem_ExitApp});
            this.MenuItem_MainAlarm.Name = "MenuItem_MainAlarm";
            this.MenuItem_MainAlarm.Size = new System.Drawing.Size(72, 24);
            this.MenuItem_MainAlarm.Text = "闹钟(&A)";
            // 
            // MenuItem_NewAlarm
            // 
            this.MenuItem_NewAlarm.Name = "MenuItem_NewAlarm";
            this.MenuItem_NewAlarm.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_NewAlarm.Text = "添加(&N)";
            this.MenuItem_NewAlarm.Click += new System.EventHandler(this.MenuItem_NewAlarm_Click);
            // 
            // MenuItem_EditAlarm
            // 
            this.MenuItem_EditAlarm.Name = "MenuItem_EditAlarm";
            this.MenuItem_EditAlarm.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_EditAlarm.Text = "编辑(&E)";
            this.MenuItem_EditAlarm.Click += new System.EventHandler(this.MenuItem_EditAlarm_Click);
            // 
            // MenuItem_DeleteAlarm
            // 
            this.MenuItem_DeleteAlarm.Name = "MenuItem_DeleteAlarm";
            this.MenuItem_DeleteAlarm.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_DeleteAlarm.Text = "删除(&D)";
            this.MenuItem_DeleteAlarm.Click += new System.EventHandler(this.MenuItem_DeleteAlarm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // MenuItem_QuickAddAlarm
            // 
            this.MenuItem_QuickAddAlarm.Name = "MenuItem_QuickAddAlarm";
            this.MenuItem_QuickAddAlarm.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_QuickAddAlarm.Text = "快速添加(&Q)";
            this.MenuItem_QuickAddAlarm.Click += new System.EventHandler(this.MenuItem_QuickAddAlarm_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // MenuItem_ExitApp
            // 
            this.MenuItem_ExitApp.Name = "MenuItem_ExitApp";
            this.MenuItem_ExitApp.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_ExitApp.Text = "退出(&X)";
            this.MenuItem_ExitApp.Click += new System.EventHandler(this.MenuItem_ExitApp_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(73, 24);
            this.MenuItem_Help.Text = "帮助(&H)";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(133, 26);
            this.MenuItem_About.Text = "关于(&B)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 359);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LayoutPanel_AlarmItems);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel_AlarmItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_MainAlarm;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewAlarm;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_EditAlarm;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_DeleteAlarm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ExitApp;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_QuickAddAlarm;
    }
}

