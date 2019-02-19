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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindWindow));
            this.dragControl1 = new DragControl.DragControl();
            this.Lbl_AlarmTitle = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Snooze = new System.Windows.Forms.Button();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_CurrentTime = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // Lbl_AlarmTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lbl_AlarmTitle, 2);
            resources.ApplyResources(this.Lbl_AlarmTitle, "Lbl_AlarmTitle");
            this.Lbl_AlarmTitle.ForeColor = System.Drawing.Color.Black;
            this.Lbl_AlarmTitle.Name = "Lbl_AlarmTitle";
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Btn_Close, "Btn_Close");
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.ForeColor = System.Drawing.Color.Black;
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Btn_Close, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Snooze, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_AlarmTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_CurrentTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Btn_Snooze
            // 
            this.Btn_Snooze.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Btn_Snooze, "Btn_Snooze");
            this.Btn_Snooze.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Snooze.FlatAppearance.BorderSize = 0;
            this.Btn_Snooze.ForeColor = System.Drawing.Color.Black;
            this.Btn_Snooze.Name = "Btn_Snooze";
            this.Btn_Snooze.UseVisualStyleBackColor = false;
            this.Btn_Snooze.Click += new System.EventHandler(this.Btn_Snooze_Click);
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.Panel_Title, 2);
            this.Panel_Title.Controls.Add(this.label1);
            resources.ApplyResources(this.Panel_Title, "Panel_Title");
            this.Panel_Title.Name = "Panel_Title";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // Lbl_CurrentTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lbl_CurrentTime, 2);
            resources.ApplyResources(this.Lbl_CurrentTime, "Lbl_CurrentTime");
            this.Lbl_CurrentTime.Name = "Lbl_CurrentTime";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12"),
            resources.GetString("comboBox1.Items13"),
            resources.GetString("comboBox1.Items14"),
            resources.GetString("comboBox1.Items15"),
            resources.GetString("comboBox1.Items16"),
            resources.GetString("comboBox1.Items17"),
            resources.GetString("comboBox1.Items18"),
            resources.GetString("comboBox1.Items19"),
            resources.GetString("comboBox1.Items20"),
            resources.GetString("comboBox1.Items21"),
            resources.GetString("comboBox1.Items22"),
            resources.GetString("comboBox1.Items23"),
            resources.GetString("comboBox1.Items24"),
            resources.GetString("comboBox1.Items25"),
            resources.GetString("comboBox1.Items26"),
            resources.GetString("comboBox1.Items27"),
            resources.GetString("comboBox1.Items28"),
            resources.GetString("comboBox1.Items29")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RemindWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemindWindow";
            this.Load += new System.EventHandler(this.RemindWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DragControl.DragControl dragControl1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_AlarmTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Snooze;
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_CurrentTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}