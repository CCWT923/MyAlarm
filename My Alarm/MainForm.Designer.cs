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
            this.FPanel_ToolBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_AddAlarm = new System.Windows.Forms.Button();
            this.Btn_EditAlarm = new System.Windows.Forms.Button();
            this.Btn_DeleteAlarm = new System.Windows.Forms.Button();
            this.LayoutPanel_AlarmItems = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_TitleBar = new System.Windows.Forms.Panel();
            this.Btn_Minisize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControl.DragControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FPanel_ToolBox.SuspendLayout();
            this.Panel_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPanel_ToolBox
            // 
            this.FPanel_ToolBox.Controls.Add(this.Btn_AddAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_EditAlarm);
            this.FPanel_ToolBox.Controls.Add(this.Btn_DeleteAlarm);
            this.FPanel_ToolBox.Location = new System.Drawing.Point(0, 45);
            this.FPanel_ToolBox.Margin = new System.Windows.Forms.Padding(0);
            this.FPanel_ToolBox.Name = "FPanel_ToolBox";
            this.FPanel_ToolBox.Size = new System.Drawing.Size(495, 40);
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
            this.Btn_AddAlarm.Size = new System.Drawing.Size(90, 35);
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
            this.Btn_EditAlarm.Location = new System.Drawing.Point(90, 0);
            this.Btn_EditAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_EditAlarm.Name = "Btn_EditAlarm";
            this.Btn_EditAlarm.Size = new System.Drawing.Size(90, 35);
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
            this.Btn_DeleteAlarm.Location = new System.Drawing.Point(180, 0);
            this.Btn_DeleteAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DeleteAlarm.Name = "Btn_DeleteAlarm";
            this.Btn_DeleteAlarm.Size = new System.Drawing.Size(90, 35);
            this.Btn_DeleteAlarm.TabIndex = 0;
            this.Btn_DeleteAlarm.Text = "删除";
            this.Btn_DeleteAlarm.UseVisualStyleBackColor = true;
            this.Btn_DeleteAlarm.Click += new System.EventHandler(this.Btn_DeleteAlarm_Click);
            // 
            // LayoutPanel_AlarmItems
            // 
            this.LayoutPanel_AlarmItems.AutoScroll = true;
            this.LayoutPanel_AlarmItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutPanel_AlarmItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel_AlarmItems.Location = new System.Drawing.Point(0, 83);
            this.LayoutPanel_AlarmItems.Name = "LayoutPanel_AlarmItems";
            this.LayoutPanel_AlarmItems.Size = new System.Drawing.Size(684, 289);
            this.LayoutPanel_AlarmItems.TabIndex = 1;
            this.LayoutPanel_AlarmItems.WrapContents = false;
            // 
            // Panel_TitleBar
            // 
            this.Panel_TitleBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Panel_TitleBar.Controls.Add(this.Btn_Minisize);
            this.Panel_TitleBar.Controls.Add(this.Btn_Close);
            this.Panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TitleBar.Name = "Panel_TitleBar";
            this.Panel_TitleBar.Size = new System.Drawing.Size(684, 44);
            this.Panel_TitleBar.TabIndex = 2;
            // 
            // Btn_Minisize
            // 
            this.Btn_Minisize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Minisize.FlatAppearance.BorderSize = 0;
            this.Btn_Minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minisize.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Minisize.ForeColor = System.Drawing.Color.White;
            this.Btn_Minisize.Location = new System.Drawing.Point(592, 3);
            this.Btn_Minisize.Name = "Btn_Minisize";
            this.Btn_Minisize.Size = new System.Drawing.Size(37, 38);
            this.Btn_Minisize.TabIndex = 0;
            this.Btn_Minisize.Text = "-";
            this.Btn_Minisize.UseVisualStyleBackColor = true;
            this.Btn_Minisize.Click += new System.EventHandler(this.Btn_Minisize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(635, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(37, 38);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "×";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_TitleBar;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.Panel_TitleBar);
            this.Controls.Add(this.LayoutPanel_AlarmItems);
            this.Controls.Add(this.FPanel_ToolBox);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Alarm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.FPanel_ToolBox.ResumeLayout(false);
            this.Panel_TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FPanel_ToolBox;
        private System.Windows.Forms.Button Btn_AddAlarm;
        private System.Windows.Forms.Button Btn_EditAlarm;
        private System.Windows.Forms.Button Btn_DeleteAlarm;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel_AlarmItems;
        private System.Windows.Forms.Panel Panel_TitleBar;
        private System.Windows.Forms.Button Btn_Close;
        private DragControl.DragControl dragControl1;
        private System.Windows.Forms.Button Btn_Minisize;
        private System.Windows.Forms.Timer timer1;
    }
}

