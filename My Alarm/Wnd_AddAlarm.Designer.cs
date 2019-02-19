namespace My_Alarm
{
    partial class Wnd_AddAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wnd_AddAlarm));
            this.Btn_SaveAlarm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combox_Minute = new System.Windows.Forms.ComboBox();
            this.Combox_Hour = new System.Windows.Forms.ComboBox();
            this.Panel_Weekday = new System.Windows.Forms.Panel();
            this.ChkBox_Sunday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Saturday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Friday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Thursday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Wednesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Tuesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Monday = new System.Windows.Forms.CheckBox();
            this.Panel_RepeatWeekday = new System.Windows.Forms.Panel();
            this.Combox_RepeatDayOfMonth = new System.Windows.Forms.ComboBox();
            this.RadBtn_RepeatMonthly = new System.Windows.Forms.RadioButton();
            this.ChkBox_Daily = new System.Windows.Forms.CheckBox();
            this.RadBtn_Repeat = new System.Windows.Forms.RadioButton();
            this.RadBtn_RepeatOnce = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_SelectSound = new System.Windows.Forms.Button();
            this.TextBox_AlarmSound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_AlarmContents = new System.Windows.Forms.Label();
            this.TextBox_AlarmContents = new System.Windows.Forms.TextBox();
            this.TextBox_AlarmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker_AlarmDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel_Background.SuspendLayout();
            this.Panel_Weekday.SuspendLayout();
            this.Panel_RepeatWeekday.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SaveAlarm
            // 
            resources.ApplyResources(this.Btn_SaveAlarm, "Btn_SaveAlarm");
            this.Btn_SaveAlarm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_SaveAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_SaveAlarm.Name = "Btn_SaveAlarm";
            this.Btn_SaveAlarm.UseVisualStyleBackColor = true;
            this.Btn_SaveAlarm.Click += new System.EventHandler(this.Btn_SaveAlarm_Click);
            // 
            // Btn_Cancel
            // 
            resources.ApplyResources(this.Btn_Cancel, "Btn_Cancel");
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Background, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.Btn_SaveAlarm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Cancel, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // Panel_Background
            // 
            resources.ApplyResources(this.Panel_Background, "Panel_Background");
            this.Panel_Background.Controls.Add(this.label6);
            this.Panel_Background.Controls.Add(this.label5);
            this.Panel_Background.Controls.Add(this.Combox_Minute);
            this.Panel_Background.Controls.Add(this.Combox_Hour);
            this.Panel_Background.Controls.Add(this.Panel_Weekday);
            this.Panel_Background.Controls.Add(this.Panel_RepeatWeekday);
            this.Panel_Background.Controls.Add(this.RadBtn_Repeat);
            this.Panel_Background.Controls.Add(this.RadBtn_RepeatOnce);
            this.Panel_Background.Controls.Add(this.label4);
            this.Panel_Background.Controls.Add(this.Btn_SelectSound);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmSound);
            this.Panel_Background.Controls.Add(this.label3);
            this.Panel_Background.Controls.Add(this.Lbl_AlarmContents);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmContents);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmName);
            this.Panel_Background.Controls.Add(this.label2);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.DateTimePicker_AlarmDate);
            this.Panel_Background.Name = "Panel_Background";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Name = "label5";
            // 
            // Combox_Minute
            // 
            resources.ApplyResources(this.Combox_Minute, "Combox_Minute");
            this.Combox_Minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_Minute.FormattingEnabled = true;
            this.Combox_Minute.Items.AddRange(new object[] {
            resources.GetString("Combox_Minute.Items"),
            resources.GetString("Combox_Minute.Items1"),
            resources.GetString("Combox_Minute.Items2"),
            resources.GetString("Combox_Minute.Items3"),
            resources.GetString("Combox_Minute.Items4"),
            resources.GetString("Combox_Minute.Items5"),
            resources.GetString("Combox_Minute.Items6"),
            resources.GetString("Combox_Minute.Items7"),
            resources.GetString("Combox_Minute.Items8"),
            resources.GetString("Combox_Minute.Items9"),
            resources.GetString("Combox_Minute.Items10"),
            resources.GetString("Combox_Minute.Items11"),
            resources.GetString("Combox_Minute.Items12"),
            resources.GetString("Combox_Minute.Items13"),
            resources.GetString("Combox_Minute.Items14"),
            resources.GetString("Combox_Minute.Items15"),
            resources.GetString("Combox_Minute.Items16"),
            resources.GetString("Combox_Minute.Items17"),
            resources.GetString("Combox_Minute.Items18"),
            resources.GetString("Combox_Minute.Items19"),
            resources.GetString("Combox_Minute.Items20"),
            resources.GetString("Combox_Minute.Items21"),
            resources.GetString("Combox_Minute.Items22"),
            resources.GetString("Combox_Minute.Items23"),
            resources.GetString("Combox_Minute.Items24"),
            resources.GetString("Combox_Minute.Items25"),
            resources.GetString("Combox_Minute.Items26"),
            resources.GetString("Combox_Minute.Items27"),
            resources.GetString("Combox_Minute.Items28"),
            resources.GetString("Combox_Minute.Items29"),
            resources.GetString("Combox_Minute.Items30"),
            resources.GetString("Combox_Minute.Items31"),
            resources.GetString("Combox_Minute.Items32"),
            resources.GetString("Combox_Minute.Items33"),
            resources.GetString("Combox_Minute.Items34"),
            resources.GetString("Combox_Minute.Items35"),
            resources.GetString("Combox_Minute.Items36"),
            resources.GetString("Combox_Minute.Items37"),
            resources.GetString("Combox_Minute.Items38"),
            resources.GetString("Combox_Minute.Items39"),
            resources.GetString("Combox_Minute.Items40"),
            resources.GetString("Combox_Minute.Items41"),
            resources.GetString("Combox_Minute.Items42"),
            resources.GetString("Combox_Minute.Items43"),
            resources.GetString("Combox_Minute.Items44"),
            resources.GetString("Combox_Minute.Items45"),
            resources.GetString("Combox_Minute.Items46"),
            resources.GetString("Combox_Minute.Items47"),
            resources.GetString("Combox_Minute.Items48"),
            resources.GetString("Combox_Minute.Items49"),
            resources.GetString("Combox_Minute.Items50"),
            resources.GetString("Combox_Minute.Items51"),
            resources.GetString("Combox_Minute.Items52"),
            resources.GetString("Combox_Minute.Items53"),
            resources.GetString("Combox_Minute.Items54"),
            resources.GetString("Combox_Minute.Items55"),
            resources.GetString("Combox_Minute.Items56"),
            resources.GetString("Combox_Minute.Items57"),
            resources.GetString("Combox_Minute.Items58"),
            resources.GetString("Combox_Minute.Items59")});
            this.Combox_Minute.Name = "Combox_Minute";
            // 
            // Combox_Hour
            // 
            resources.ApplyResources(this.Combox_Hour, "Combox_Hour");
            this.Combox_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_Hour.FormattingEnabled = true;
            this.Combox_Hour.Items.AddRange(new object[] {
            resources.GetString("Combox_Hour.Items"),
            resources.GetString("Combox_Hour.Items1"),
            resources.GetString("Combox_Hour.Items2"),
            resources.GetString("Combox_Hour.Items3"),
            resources.GetString("Combox_Hour.Items4"),
            resources.GetString("Combox_Hour.Items5"),
            resources.GetString("Combox_Hour.Items6"),
            resources.GetString("Combox_Hour.Items7"),
            resources.GetString("Combox_Hour.Items8"),
            resources.GetString("Combox_Hour.Items9"),
            resources.GetString("Combox_Hour.Items10"),
            resources.GetString("Combox_Hour.Items11"),
            resources.GetString("Combox_Hour.Items12"),
            resources.GetString("Combox_Hour.Items13"),
            resources.GetString("Combox_Hour.Items14"),
            resources.GetString("Combox_Hour.Items15"),
            resources.GetString("Combox_Hour.Items16"),
            resources.GetString("Combox_Hour.Items17"),
            resources.GetString("Combox_Hour.Items18"),
            resources.GetString("Combox_Hour.Items19"),
            resources.GetString("Combox_Hour.Items20"),
            resources.GetString("Combox_Hour.Items21"),
            resources.GetString("Combox_Hour.Items22"),
            resources.GetString("Combox_Hour.Items23")});
            this.Combox_Hour.Name = "Combox_Hour";
            // 
            // Panel_Weekday
            // 
            resources.ApplyResources(this.Panel_Weekday, "Panel_Weekday");
            this.Panel_Weekday.Controls.Add(this.ChkBox_Sunday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Saturday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Friday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Thursday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Wednesday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Tuesday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Monday);
            this.Panel_Weekday.Name = "Panel_Weekday";
            // 
            // ChkBox_Sunday
            // 
            resources.ApplyResources(this.ChkBox_Sunday, "ChkBox_Sunday");
            this.ChkBox_Sunday.Name = "ChkBox_Sunday";
            this.ChkBox_Sunday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Saturday
            // 
            resources.ApplyResources(this.ChkBox_Saturday, "ChkBox_Saturday");
            this.ChkBox_Saturday.Name = "ChkBox_Saturday";
            this.ChkBox_Saturday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Friday
            // 
            resources.ApplyResources(this.ChkBox_Friday, "ChkBox_Friday");
            this.ChkBox_Friday.Name = "ChkBox_Friday";
            this.ChkBox_Friday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Thursday
            // 
            resources.ApplyResources(this.ChkBox_Thursday, "ChkBox_Thursday");
            this.ChkBox_Thursday.Name = "ChkBox_Thursday";
            this.ChkBox_Thursday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Wednesday
            // 
            resources.ApplyResources(this.ChkBox_Wednesday, "ChkBox_Wednesday");
            this.ChkBox_Wednesday.Name = "ChkBox_Wednesday";
            this.ChkBox_Wednesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Tuesday
            // 
            resources.ApplyResources(this.ChkBox_Tuesday, "ChkBox_Tuesday");
            this.ChkBox_Tuesday.Name = "ChkBox_Tuesday";
            this.ChkBox_Tuesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Monday
            // 
            resources.ApplyResources(this.ChkBox_Monday, "ChkBox_Monday");
            this.ChkBox_Monday.Name = "ChkBox_Monday";
            this.ChkBox_Monday.UseVisualStyleBackColor = true;
            // 
            // Panel_RepeatWeekday
            // 
            resources.ApplyResources(this.Panel_RepeatWeekday, "Panel_RepeatWeekday");
            this.Panel_RepeatWeekday.Controls.Add(this.Combox_RepeatDayOfMonth);
            this.Panel_RepeatWeekday.Controls.Add(this.RadBtn_RepeatMonthly);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Daily);
            this.Panel_RepeatWeekday.Name = "Panel_RepeatWeekday";
            // 
            // Combox_RepeatDayOfMonth
            // 
            resources.ApplyResources(this.Combox_RepeatDayOfMonth, "Combox_RepeatDayOfMonth");
            this.Combox_RepeatDayOfMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_RepeatDayOfMonth.FormattingEnabled = true;
            this.Combox_RepeatDayOfMonth.Items.AddRange(new object[] {
            resources.GetString("Combox_RepeatDayOfMonth.Items"),
            resources.GetString("Combox_RepeatDayOfMonth.Items1"),
            resources.GetString("Combox_RepeatDayOfMonth.Items2"),
            resources.GetString("Combox_RepeatDayOfMonth.Items3"),
            resources.GetString("Combox_RepeatDayOfMonth.Items4"),
            resources.GetString("Combox_RepeatDayOfMonth.Items5"),
            resources.GetString("Combox_RepeatDayOfMonth.Items6"),
            resources.GetString("Combox_RepeatDayOfMonth.Items7"),
            resources.GetString("Combox_RepeatDayOfMonth.Items8"),
            resources.GetString("Combox_RepeatDayOfMonth.Items9"),
            resources.GetString("Combox_RepeatDayOfMonth.Items10"),
            resources.GetString("Combox_RepeatDayOfMonth.Items11"),
            resources.GetString("Combox_RepeatDayOfMonth.Items12"),
            resources.GetString("Combox_RepeatDayOfMonth.Items13"),
            resources.GetString("Combox_RepeatDayOfMonth.Items14"),
            resources.GetString("Combox_RepeatDayOfMonth.Items15"),
            resources.GetString("Combox_RepeatDayOfMonth.Items16"),
            resources.GetString("Combox_RepeatDayOfMonth.Items17"),
            resources.GetString("Combox_RepeatDayOfMonth.Items18"),
            resources.GetString("Combox_RepeatDayOfMonth.Items19"),
            resources.GetString("Combox_RepeatDayOfMonth.Items20"),
            resources.GetString("Combox_RepeatDayOfMonth.Items21"),
            resources.GetString("Combox_RepeatDayOfMonth.Items22"),
            resources.GetString("Combox_RepeatDayOfMonth.Items23"),
            resources.GetString("Combox_RepeatDayOfMonth.Items24"),
            resources.GetString("Combox_RepeatDayOfMonth.Items25"),
            resources.GetString("Combox_RepeatDayOfMonth.Items26"),
            resources.GetString("Combox_RepeatDayOfMonth.Items27"),
            resources.GetString("Combox_RepeatDayOfMonth.Items28"),
            resources.GetString("Combox_RepeatDayOfMonth.Items29"),
            resources.GetString("Combox_RepeatDayOfMonth.Items30")});
            this.Combox_RepeatDayOfMonth.Name = "Combox_RepeatDayOfMonth";
            // 
            // RadBtn_RepeatMonthly
            // 
            resources.ApplyResources(this.RadBtn_RepeatMonthly, "RadBtn_RepeatMonthly");
            this.RadBtn_RepeatMonthly.Name = "RadBtn_RepeatMonthly";
            this.RadBtn_RepeatMonthly.TabStop = true;
            this.RadBtn_RepeatMonthly.UseVisualStyleBackColor = true;
            this.RadBtn_RepeatMonthly.CheckedChanged += new System.EventHandler(this.RadBtn_RepeatMonthly_CheckedChanged);
            // 
            // ChkBox_Daily
            // 
            resources.ApplyResources(this.ChkBox_Daily, "ChkBox_Daily");
            this.ChkBox_Daily.Name = "ChkBox_Daily";
            this.ChkBox_Daily.UseVisualStyleBackColor = true;
            this.ChkBox_Daily.CheckedChanged += new System.EventHandler(this.ChkBox_Daily_CheckedChanged);
            // 
            // RadBtn_Repeat
            // 
            resources.ApplyResources(this.RadBtn_Repeat, "RadBtn_Repeat");
            this.RadBtn_Repeat.Name = "RadBtn_Repeat";
            this.RadBtn_Repeat.TabStop = true;
            this.RadBtn_Repeat.UseVisualStyleBackColor = true;
            this.RadBtn_Repeat.CheckedChanged += new System.EventHandler(this.RadBtn_Repeat_CheckedChanged);
            // 
            // RadBtn_RepeatOnce
            // 
            resources.ApplyResources(this.RadBtn_RepeatOnce, "RadBtn_RepeatOnce");
            this.RadBtn_RepeatOnce.Name = "RadBtn_RepeatOnce";
            this.RadBtn_RepeatOnce.TabStop = true;
            this.RadBtn_RepeatOnce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Name = "label4";
            // 
            // Btn_SelectSound
            // 
            resources.ApplyResources(this.Btn_SelectSound, "Btn_SelectSound");
            this.Btn_SelectSound.Name = "Btn_SelectSound";
            this.Btn_SelectSound.UseVisualStyleBackColor = true;
            this.Btn_SelectSound.Click += new System.EventHandler(this.Btn_SelectSound_Click);
            // 
            // TextBox_AlarmSound
            // 
            resources.ApplyResources(this.TextBox_AlarmSound, "TextBox_AlarmSound");
            this.TextBox_AlarmSound.Name = "TextBox_AlarmSound";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Name = "label3";
            // 
            // Lbl_AlarmContents
            // 
            resources.ApplyResources(this.Lbl_AlarmContents, "Lbl_AlarmContents");
            this.Lbl_AlarmContents.ForeColor = System.Drawing.Color.Crimson;
            this.Lbl_AlarmContents.Name = "Lbl_AlarmContents";
            // 
            // TextBox_AlarmContents
            // 
            resources.ApplyResources(this.TextBox_AlarmContents, "TextBox_AlarmContents");
            this.TextBox_AlarmContents.Name = "TextBox_AlarmContents";
            // 
            // TextBox_AlarmName
            // 
            resources.ApplyResources(this.TextBox_AlarmName, "TextBox_AlarmName");
            this.TextBox_AlarmName.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_AlarmName.Name = "TextBox_AlarmName";
            this.TextBox_AlarmName.Enter += new System.EventHandler(this.TextBox_AlarmName_Enter);
            this.TextBox_AlarmName.Leave += new System.EventHandler(this.TextBox_AlarmName_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Name = "label1";
            // 
            // DateTimePicker_AlarmDate
            // 
            resources.ApplyResources(this.DateTimePicker_AlarmDate, "DateTimePicker_AlarmDate");
            this.DateTimePicker_AlarmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_AlarmDate.MinDate = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            this.DateTimePicker_AlarmDate.Name = "DateTimePicker_AlarmDate";
            // 
            // Wnd_AddAlarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Wnd_AddAlarm";
            this.ShowInTaskbar = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            this.Panel_Weekday.ResumeLayout(false);
            this.Panel_Weekday.PerformLayout();
            this.Panel_RepeatWeekday.ResumeLayout(false);
            this.Panel_RepeatWeekday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_SaveAlarm;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Panel Panel_RepeatWeekday;
        private System.Windows.Forms.ComboBox Combox_RepeatDayOfMonth;
        private System.Windows.Forms.RadioButton RadBtn_RepeatMonthly;
        private System.Windows.Forms.CheckBox ChkBox_Daily;
        private System.Windows.Forms.RadioButton RadBtn_Repeat;
        private System.Windows.Forms.RadioButton RadBtn_RepeatOnce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_SelectSound;
        private System.Windows.Forms.TextBox TextBox_AlarmSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_AlarmContents;
        private System.Windows.Forms.TextBox TextBox_AlarmContents;
        private System.Windows.Forms.TextBox TextBox_AlarmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker_AlarmDate;
        private System.Windows.Forms.Panel Panel_Weekday;
        private System.Windows.Forms.CheckBox ChkBox_Sunday;
        private System.Windows.Forms.CheckBox ChkBox_Saturday;
        private System.Windows.Forms.CheckBox ChkBox_Friday;
        private System.Windows.Forms.CheckBox ChkBox_Thursday;
        private System.Windows.Forms.CheckBox ChkBox_Wednesday;
        private System.Windows.Forms.CheckBox ChkBox_Tuesday;
        private System.Windows.Forms.CheckBox ChkBox_Monday;
        private System.Windows.Forms.ComboBox Combox_Minute;
        private System.Windows.Forms.ComboBox Combox_Hour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}