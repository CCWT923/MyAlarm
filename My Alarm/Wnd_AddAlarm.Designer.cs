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
            this.DateTimePicker_AlarmDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_AlarmName = new System.Windows.Forms.TextBox();
            this.TextBox_AlarmContents = new System.Windows.Forms.TextBox();
            this.Lbl_AlarmContents = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_AlarmSound = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RadBtn_RepeatOnce = new System.Windows.Forms.RadioButton();
            this.RadBtn_RepeatWeekday = new System.Windows.Forms.RadioButton();
            this.Panel_RepeatWeekday = new System.Windows.Forms.Panel();
            this.ChkBox_Sunday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Saturday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Friday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Thursday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Wednesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Tuesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Monday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Daily = new System.Windows.Forms.CheckBox();
            this.RadBtn_RepeatMonthly = new System.Windows.Forms.RadioButton();
            this.Combox_RepeatDayOfMonth = new System.Windows.Forms.ComboBox();
            this.Btn_SaveAlarm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.FlowPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_RepeatWeekday.SuspendLayout();
            this.FlowPanel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker_AlarmDate
            // 
            this.DateTimePicker_AlarmDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DateTimePicker_AlarmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_AlarmDate.Location = new System.Drawing.Point(117, 24);
            this.DateTimePicker_AlarmDate.MinDate = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            this.DateTimePicker_AlarmDate.Name = "DateTimePicker_AlarmDate";
            this.DateTimePicker_AlarmDate.Size = new System.Drawing.Size(221, 25);
            this.DateTimePicker_AlarmDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "提醒时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称：";
            // 
            // TextBox_AlarmName
            // 
            this.TextBox_AlarmName.Location = new System.Drawing.Point(117, 69);
            this.TextBox_AlarmName.Name = "TextBox_AlarmName";
            this.TextBox_AlarmName.Size = new System.Drawing.Size(413, 25);
            this.TextBox_AlarmName.TabIndex = 3;
            // 
            // TextBox_AlarmContents
            // 
            this.TextBox_AlarmContents.Location = new System.Drawing.Point(117, 120);
            this.TextBox_AlarmContents.Multiline = true;
            this.TextBox_AlarmContents.Name = "TextBox_AlarmContents";
            this.TextBox_AlarmContents.Size = new System.Drawing.Size(413, 100);
            this.TextBox_AlarmContents.TabIndex = 4;
            // 
            // Lbl_AlarmContents
            // 
            this.Lbl_AlarmContents.AutoSize = true;
            this.Lbl_AlarmContents.Location = new System.Drawing.Point(15, 120);
            this.Lbl_AlarmContents.Name = "Lbl_AlarmContents";
            this.Lbl_AlarmContents.Size = new System.Drawing.Size(52, 15);
            this.Lbl_AlarmContents.TabIndex = 5;
            this.Lbl_AlarmContents.Text = "备注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "提示音：";
            // 
            // TextBox_AlarmSound
            // 
            this.TextBox_AlarmSound.Location = new System.Drawing.Point(117, 242);
            this.TextBox_AlarmSound.Name = "TextBox_AlarmSound";
            this.TextBox_AlarmSound.Size = new System.Drawing.Size(297, 25);
            this.TextBox_AlarmSound.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "浏览...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "重复周期：";
            // 
            // RadBtn_RepeatOnce
            // 
            this.RadBtn_RepeatOnce.AutoSize = true;
            this.RadBtn_RepeatOnce.Location = new System.Drawing.Point(227, 322);
            this.RadBtn_RepeatOnce.Name = "RadBtn_RepeatOnce";
            this.RadBtn_RepeatOnce.Size = new System.Drawing.Size(58, 19);
            this.RadBtn_RepeatOnce.TabIndex = 10;
            this.RadBtn_RepeatOnce.TabStop = true;
            this.RadBtn_RepeatOnce.Text = "一次";
            this.RadBtn_RepeatOnce.UseVisualStyleBackColor = true;
            // 
            // RadBtn_RepeatWeekday
            // 
            this.RadBtn_RepeatWeekday.AutoSize = true;
            this.RadBtn_RepeatWeekday.Location = new System.Drawing.Point(103, 322);
            this.RadBtn_RepeatWeekday.Name = "RadBtn_RepeatWeekday";
            this.RadBtn_RepeatWeekday.Size = new System.Drawing.Size(58, 19);
            this.RadBtn_RepeatWeekday.TabIndex = 11;
            this.RadBtn_RepeatWeekday.TabStop = true;
            this.RadBtn_RepeatWeekday.Text = "重复";
            this.RadBtn_RepeatWeekday.UseVisualStyleBackColor = true;
            this.RadBtn_RepeatWeekday.CheckedChanged += new System.EventHandler(this.RadBtn_RepeatWeekday_CheckedChanged);
            // 
            // Panel_RepeatWeekday
            // 
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Sunday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Saturday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Friday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Thursday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Wednesday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Tuesday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Monday);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Daily);
            this.Panel_RepeatWeekday.Location = new System.Drawing.Point(90, 347);
            this.Panel_RepeatWeekday.Name = "Panel_RepeatWeekday";
            this.Panel_RepeatWeekday.Size = new System.Drawing.Size(108, 200);
            this.Panel_RepeatWeekday.TabIndex = 12;
            // 
            // ChkBox_Sunday
            // 
            this.ChkBox_Sunday.AutoSize = true;
            this.ChkBox_Sunday.Location = new System.Drawing.Point(12, 178);
            this.ChkBox_Sunday.Name = "ChkBox_Sunday";
            this.ChkBox_Sunday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Sunday.TabIndex = 0;
            this.ChkBox_Sunday.Text = "星期天";
            this.ChkBox_Sunday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Saturday
            // 
            this.ChkBox_Saturday.AutoSize = true;
            this.ChkBox_Saturday.Location = new System.Drawing.Point(12, 153);
            this.ChkBox_Saturday.Name = "ChkBox_Saturday";
            this.ChkBox_Saturday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Saturday.TabIndex = 0;
            this.ChkBox_Saturday.Text = "星期六";
            this.ChkBox_Saturday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Friday
            // 
            this.ChkBox_Friday.AutoSize = true;
            this.ChkBox_Friday.Location = new System.Drawing.Point(12, 128);
            this.ChkBox_Friday.Name = "ChkBox_Friday";
            this.ChkBox_Friday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Friday.TabIndex = 0;
            this.ChkBox_Friday.Text = "星期五";
            this.ChkBox_Friday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Thursday
            // 
            this.ChkBox_Thursday.AutoSize = true;
            this.ChkBox_Thursday.Location = new System.Drawing.Point(12, 103);
            this.ChkBox_Thursday.Name = "ChkBox_Thursday";
            this.ChkBox_Thursday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Thursday.TabIndex = 0;
            this.ChkBox_Thursday.Text = "星期四";
            this.ChkBox_Thursday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Wednesday
            // 
            this.ChkBox_Wednesday.AutoSize = true;
            this.ChkBox_Wednesday.Location = new System.Drawing.Point(12, 78);
            this.ChkBox_Wednesday.Name = "ChkBox_Wednesday";
            this.ChkBox_Wednesday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Wednesday.TabIndex = 0;
            this.ChkBox_Wednesday.Text = "星期三";
            this.ChkBox_Wednesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Tuesday
            // 
            this.ChkBox_Tuesday.AutoSize = true;
            this.ChkBox_Tuesday.Location = new System.Drawing.Point(12, 53);
            this.ChkBox_Tuesday.Name = "ChkBox_Tuesday";
            this.ChkBox_Tuesday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Tuesday.TabIndex = 0;
            this.ChkBox_Tuesday.Text = "星期二";
            this.ChkBox_Tuesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Monday
            // 
            this.ChkBox_Monday.AutoSize = true;
            this.ChkBox_Monday.Location = new System.Drawing.Point(12, 28);
            this.ChkBox_Monday.Name = "ChkBox_Monday";
            this.ChkBox_Monday.Size = new System.Drawing.Size(74, 19);
            this.ChkBox_Monday.TabIndex = 0;
            this.ChkBox_Monday.Text = "星期一";
            this.ChkBox_Monday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Daily
            // 
            this.ChkBox_Daily.AutoSize = true;
            this.ChkBox_Daily.Location = new System.Drawing.Point(12, 3);
            this.ChkBox_Daily.Name = "ChkBox_Daily";
            this.ChkBox_Daily.Size = new System.Drawing.Size(59, 19);
            this.ChkBox_Daily.TabIndex = 0;
            this.ChkBox_Daily.Text = "每天";
            this.ChkBox_Daily.UseVisualStyleBackColor = true;
            // 
            // RadBtn_RepeatMonthly
            // 
            this.RadBtn_RepeatMonthly.AutoSize = true;
            this.RadBtn_RepeatMonthly.Location = new System.Drawing.Point(335, 322);
            this.RadBtn_RepeatMonthly.Name = "RadBtn_RepeatMonthly";
            this.RadBtn_RepeatMonthly.Size = new System.Drawing.Size(58, 19);
            this.RadBtn_RepeatMonthly.TabIndex = 13;
            this.RadBtn_RepeatMonthly.TabStop = true;
            this.RadBtn_RepeatMonthly.Text = "每月";
            this.RadBtn_RepeatMonthly.UseVisualStyleBackColor = true;
            this.RadBtn_RepeatMonthly.CheckedChanged += new System.EventHandler(this.RadBtn_RepeatMonthly_CheckedChanged);
            // 
            // Combox_RepeatDayOfMonth
            // 
            this.Combox_RepeatDayOfMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_RepeatDayOfMonth.FormattingEnabled = true;
            this.Combox_RepeatDayOfMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Combox_RepeatDayOfMonth.Location = new System.Drawing.Point(409, 321);
            this.Combox_RepeatDayOfMonth.Name = "Combox_RepeatDayOfMonth";
            this.Combox_RepeatDayOfMonth.Size = new System.Drawing.Size(121, 23);
            this.Combox_RepeatDayOfMonth.TabIndex = 14;
            // 
            // Btn_SaveAlarm
            // 
            this.Btn_SaveAlarm.Location = new System.Drawing.Point(3, 3);
            this.Btn_SaveAlarm.Name = "Btn_SaveAlarm";
            this.Btn_SaveAlarm.Size = new System.Drawing.Size(104, 40);
            this.Btn_SaveAlarm.TabIndex = 15;
            this.Btn_SaveAlarm.Text = "保存";
            this.Btn_SaveAlarm.UseVisualStyleBackColor = true;
            this.Btn_SaveAlarm.Click += new System.EventHandler(this.Btn_SaveAlarm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(113, 3);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(104, 40);
            this.Btn_Cancel.TabIndex = 15;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // FlowPanel_Buttons
            // 
            this.FlowPanel_Buttons.Controls.Add(this.Btn_SaveAlarm);
            this.FlowPanel_Buttons.Controls.Add(this.Btn_Cancel);
            this.FlowPanel_Buttons.Location = new System.Drawing.Point(335, 550);
            this.FlowPanel_Buttons.Name = "FlowPanel_Buttons";
            this.FlowPanel_Buttons.Size = new System.Drawing.Size(224, 49);
            this.FlowPanel_Buttons.TabIndex = 16;
            // 
            // Wnd_AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 601);
            this.Controls.Add(this.FlowPanel_Buttons);
            this.Controls.Add(this.Combox_RepeatDayOfMonth);
            this.Controls.Add(this.RadBtn_RepeatMonthly);
            this.Controls.Add(this.Panel_RepeatWeekday);
            this.Controls.Add(this.RadBtn_RepeatWeekday);
            this.Controls.Add(this.RadBtn_RepeatOnce);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_AlarmSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_AlarmContents);
            this.Controls.Add(this.TextBox_AlarmContents);
            this.Controls.Add(this.TextBox_AlarmName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker_AlarmDate);
            this.Name = "Wnd_AddAlarm";
            this.ShowInTaskbar = false;
            this.Text = "添加闹钟";
            this.Load += new System.EventHandler(this.Wnd_AddAlarm_Load);
            this.Panel_RepeatWeekday.ResumeLayout(false);
            this.Panel_RepeatWeekday.PerformLayout();
            this.FlowPanel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker_AlarmDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_AlarmName;
        private System.Windows.Forms.TextBox TextBox_AlarmContents;
        private System.Windows.Forms.Label Lbl_AlarmContents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_AlarmSound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RadBtn_RepeatOnce;
        private System.Windows.Forms.RadioButton RadBtn_RepeatWeekday;
        private System.Windows.Forms.Panel Panel_RepeatWeekday;
        private System.Windows.Forms.CheckBox ChkBox_Sunday;
        private System.Windows.Forms.CheckBox ChkBox_Saturday;
        private System.Windows.Forms.CheckBox ChkBox_Friday;
        private System.Windows.Forms.CheckBox ChkBox_Thursday;
        private System.Windows.Forms.CheckBox ChkBox_Wednesday;
        private System.Windows.Forms.CheckBox ChkBox_Tuesday;
        private System.Windows.Forms.CheckBox ChkBox_Monday;
        private System.Windows.Forms.CheckBox ChkBox_Daily;
        private System.Windows.Forms.RadioButton RadBtn_RepeatMonthly;
        private System.Windows.Forms.ComboBox Combox_RepeatDayOfMonth;
        private System.Windows.Forms.Button Btn_SaveAlarm;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Buttons;
    }
}