﻿namespace My_Alarm
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
            this.Btn_SaveAlarm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Panel_RepeatWeekday = new System.Windows.Forms.Panel();
            this.Combox_RepeatDayOfMonth = new System.Windows.Forms.ComboBox();
            this.RadBtn_RepeatMonthly = new System.Windows.Forms.RadioButton();
            this.ChkBox_Daily = new System.Windows.Forms.CheckBox();
            this.RadBtn_Repeat = new System.Windows.Forms.RadioButton();
            this.RadBtn_RepeatOnce = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_AlarmSound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_AlarmContents = new System.Windows.Forms.Label();
            this.TextBox_AlarmContents = new System.Windows.Forms.TextBox();
            this.TextBox_AlarmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker_AlarmDate = new System.Windows.Forms.DateTimePicker();
            this.Panel_Weekday = new System.Windows.Forms.Panel();
            this.ChkBox_Sunday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Saturday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Friday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Thursday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Wednesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Tuesday = new System.Windows.Forms.CheckBox();
            this.ChkBox_Monday = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel_Background.SuspendLayout();
            this.Panel_RepeatWeekday.SuspendLayout();
            this.Panel_Weekday.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SaveAlarm
            // 
            this.Btn_SaveAlarm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_SaveAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_SaveAlarm.FlatAppearance.BorderSize = 0;
            this.Btn_SaveAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveAlarm.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SaveAlarm.Location = new System.Drawing.Point(3, 3);
            this.Btn_SaveAlarm.Name = "Btn_SaveAlarm";
            this.Btn_SaveAlarm.Size = new System.Drawing.Size(355, 40);
            this.Btn_SaveAlarm.TabIndex = 52;
            this.Btn_SaveAlarm.Text = "保存";
            this.Btn_SaveAlarm.UseVisualStyleBackColor = true;
            this.Btn_SaveAlarm.Click += new System.EventHandler(this.Btn_SaveAlarm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(364, 3);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(356, 40);
            this.Btn_Cancel.TabIndex = 53;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Background, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 512);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_SaveAlarm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Cancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 463);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(723, 46);
            this.tableLayoutPanel2.TabIndex = 57;
            // 
            // Panel_Background
            // 
            this.Panel_Background.AutoScroll = true;
            this.Panel_Background.Controls.Add(this.Panel_Weekday);
            this.Panel_Background.Controls.Add(this.Panel_RepeatWeekday);
            this.Panel_Background.Controls.Add(this.RadBtn_Repeat);
            this.Panel_Background.Controls.Add(this.RadBtn_RepeatOnce);
            this.Panel_Background.Controls.Add(this.label4);
            this.Panel_Background.Controls.Add(this.button1);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmSound);
            this.Panel_Background.Controls.Add(this.label3);
            this.Panel_Background.Controls.Add(this.Lbl_AlarmContents);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmContents);
            this.Panel_Background.Controls.Add(this.TextBox_AlarmName);
            this.Panel_Background.Controls.Add(this.label2);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.DateTimePicker_AlarmDate);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(3, 3);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(723, 454);
            this.Panel_Background.TabIndex = 56;
            // 
            // Panel_RepeatWeekday
            // 
            this.Panel_RepeatWeekday.Controls.Add(this.Combox_RepeatDayOfMonth);
            this.Panel_RepeatWeekday.Controls.Add(this.RadBtn_RepeatMonthly);
            this.Panel_RepeatWeekday.Controls.Add(this.ChkBox_Daily);
            this.Panel_RepeatWeekday.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.Panel_RepeatWeekday.Location = new System.Drawing.Point(12, 502);
            this.Panel_RepeatWeekday.Name = "Panel_RepeatWeekday";
            this.Panel_RepeatWeekday.Size = new System.Drawing.Size(619, 53);
            this.Panel_RepeatWeekday.TabIndex = 64;
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
            this.Combox_RepeatDayOfMonth.Location = new System.Drawing.Point(257, 13);
            this.Combox_RepeatDayOfMonth.Name = "Combox_RepeatDayOfMonth";
            this.Combox_RepeatDayOfMonth.Size = new System.Drawing.Size(106, 32);
            this.Combox_RepeatDayOfMonth.TabIndex = 66;
            // 
            // RadBtn_RepeatMonthly
            // 
            this.RadBtn_RepeatMonthly.AutoSize = true;
            this.RadBtn_RepeatMonthly.Location = new System.Drawing.Point(180, 14);
            this.RadBtn_RepeatMonthly.Name = "RadBtn_RepeatMonthly";
            this.RadBtn_RepeatMonthly.Size = new System.Drawing.Size(71, 29);
            this.RadBtn_RepeatMonthly.TabIndex = 65;
            this.RadBtn_RepeatMonthly.TabStop = true;
            this.RadBtn_RepeatMonthly.Text = "每月";
            this.RadBtn_RepeatMonthly.UseVisualStyleBackColor = true;
            this.RadBtn_RepeatMonthly.CheckedChanged += new System.EventHandler(this.RadBtn_RepeatMonthly_CheckedChanged);
            // 
            // ChkBox_Daily
            // 
            this.ChkBox_Daily.AutoSize = true;
            this.ChkBox_Daily.Location = new System.Drawing.Point(12, 15);
            this.ChkBox_Daily.Name = "ChkBox_Daily";
            this.ChkBox_Daily.Size = new System.Drawing.Size(72, 29);
            this.ChkBox_Daily.TabIndex = 0;
            this.ChkBox_Daily.Text = "每天";
            this.ChkBox_Daily.UseVisualStyleBackColor = true;
            this.ChkBox_Daily.CheckedChanged += new System.EventHandler(this.ChkBox_Daily_CheckedChanged);
            // 
            // RadBtn_Repeat
            // 
            this.RadBtn_Repeat.AutoSize = true;
            this.RadBtn_Repeat.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.RadBtn_Repeat.Location = new System.Drawing.Point(12, 461);
            this.RadBtn_Repeat.Name = "RadBtn_Repeat";
            this.RadBtn_Repeat.Size = new System.Drawing.Size(71, 29);
            this.RadBtn_Repeat.TabIndex = 63;
            this.RadBtn_Repeat.TabStop = true;
            this.RadBtn_Repeat.Text = "重复";
            this.RadBtn_Repeat.UseVisualStyleBackColor = true;
            this.RadBtn_Repeat.CheckedChanged += new System.EventHandler(this.RadBtn_Repeat_CheckedChanged);
            // 
            // RadBtn_RepeatOnce
            // 
            this.RadBtn_RepeatOnce.AutoSize = true;
            this.RadBtn_RepeatOnce.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.RadBtn_RepeatOnce.Location = new System.Drawing.Point(12, 422);
            this.RadBtn_RepeatOnce.Name = "RadBtn_RepeatOnce";
            this.RadBtn_RepeatOnce.Size = new System.Drawing.Size(71, 29);
            this.RadBtn_RepeatOnce.TabIndex = 62;
            this.RadBtn_RepeatOnce.TabStop = true;
            this.RadBtn_RepeatOnce.Text = "一次";
            this.RadBtn_RepeatOnce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "重复周期";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.Location = new System.Drawing.Point(560, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TextBox_AlarmSound
            // 
            this.TextBox_AlarmSound.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.TextBox_AlarmSound.Location = new System.Drawing.Point(12, 344);
            this.TextBox_AlarmSound.Name = "TextBox_AlarmSound";
            this.TextBox_AlarmSound.Size = new System.Drawing.Size(542, 32);
            this.TextBox_AlarmSound.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "提示音";
            // 
            // Lbl_AlarmContents
            // 
            this.Lbl_AlarmContents.AutoSize = true;
            this.Lbl_AlarmContents.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_AlarmContents.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lbl_AlarmContents.Location = new System.Drawing.Point(12, 173);
            this.Lbl_AlarmContents.Name = "Lbl_AlarmContents";
            this.Lbl_AlarmContents.Size = new System.Drawing.Size(50, 26);
            this.Lbl_AlarmContents.TabIndex = 57;
            this.Lbl_AlarmContents.Text = "备注";
            // 
            // TextBox_AlarmContents
            // 
            this.TextBox_AlarmContents.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.TextBox_AlarmContents.Location = new System.Drawing.Point(12, 205);
            this.TextBox_AlarmContents.Multiline = true;
            this.TextBox_AlarmContents.Name = "TextBox_AlarmContents";
            this.TextBox_AlarmContents.Size = new System.Drawing.Size(619, 73);
            this.TextBox_AlarmContents.TabIndex = 56;
            // 
            // TextBox_AlarmName
            // 
            this.TextBox_AlarmName.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.TextBox_AlarmName.Location = new System.Drawing.Point(12, 127);
            this.TextBox_AlarmName.Name = "TextBox_AlarmName";
            this.TextBox_AlarmName.Size = new System.Drawing.Size(619, 32);
            this.TextBox_AlarmName.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "提醒时间";
            // 
            // DateTimePicker_AlarmDate
            // 
            this.DateTimePicker_AlarmDate.CalendarFont = new System.Drawing.Font("微软雅黑", 11F);
            this.DateTimePicker_AlarmDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DateTimePicker_AlarmDate.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.DateTimePicker_AlarmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_AlarmDate.Location = new System.Drawing.Point(12, 48);
            this.DateTimePicker_AlarmDate.MinDate = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            this.DateTimePicker_AlarmDate.Name = "DateTimePicker_AlarmDate";
            this.DateTimePicker_AlarmDate.Size = new System.Drawing.Size(619, 32);
            this.DateTimePicker_AlarmDate.TabIndex = 52;
            // 
            // Panel_Weekday
            // 
            this.Panel_Weekday.Controls.Add(this.ChkBox_Sunday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Saturday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Friday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Thursday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Wednesday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Tuesday);
            this.Panel_Weekday.Controls.Add(this.ChkBox_Monday);
            this.Panel_Weekday.Location = new System.Drawing.Point(12, 555);
            this.Panel_Weekday.Name = "Panel_Weekday";
            this.Panel_Weekday.Size = new System.Drawing.Size(619, 236);
            this.Panel_Weekday.TabIndex = 65;
            // 
            // ChkBox_Sunday
            // 
            this.ChkBox_Sunday.AutoSize = true;
            this.ChkBox_Sunday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Sunday.Location = new System.Drawing.Point(14, 205);
            this.ChkBox_Sunday.Name = "ChkBox_Sunday";
            this.ChkBox_Sunday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Sunday.TabIndex = 1;
            this.ChkBox_Sunday.Text = "星期日";
            this.ChkBox_Sunday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Saturday
            // 
            this.ChkBox_Saturday.AutoSize = true;
            this.ChkBox_Saturday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Saturday.Location = new System.Drawing.Point(14, 172);
            this.ChkBox_Saturday.Name = "ChkBox_Saturday";
            this.ChkBox_Saturday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Saturday.TabIndex = 2;
            this.ChkBox_Saturday.Text = "星期六";
            this.ChkBox_Saturday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Friday
            // 
            this.ChkBox_Friday.AutoSize = true;
            this.ChkBox_Friday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Friday.Location = new System.Drawing.Point(14, 139);
            this.ChkBox_Friday.Name = "ChkBox_Friday";
            this.ChkBox_Friday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Friday.TabIndex = 3;
            this.ChkBox_Friday.Text = "星期五";
            this.ChkBox_Friday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Thursday
            // 
            this.ChkBox_Thursday.AutoSize = true;
            this.ChkBox_Thursday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Thursday.Location = new System.Drawing.Point(14, 106);
            this.ChkBox_Thursday.Name = "ChkBox_Thursday";
            this.ChkBox_Thursday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Thursday.TabIndex = 4;
            this.ChkBox_Thursday.Text = "星期四";
            this.ChkBox_Thursday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Wednesday
            // 
            this.ChkBox_Wednesday.AutoSize = true;
            this.ChkBox_Wednesday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Wednesday.Location = new System.Drawing.Point(14, 73);
            this.ChkBox_Wednesday.Name = "ChkBox_Wednesday";
            this.ChkBox_Wednesday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Wednesday.TabIndex = 5;
            this.ChkBox_Wednesday.Text = "星期三";
            this.ChkBox_Wednesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Tuesday
            // 
            this.ChkBox_Tuesday.AutoSize = true;
            this.ChkBox_Tuesday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Tuesday.Location = new System.Drawing.Point(14, 40);
            this.ChkBox_Tuesday.Name = "ChkBox_Tuesday";
            this.ChkBox_Tuesday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Tuesday.TabIndex = 6;
            this.ChkBox_Tuesday.Text = "星期二";
            this.ChkBox_Tuesday.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Monday
            // 
            this.ChkBox_Monday.AutoSize = true;
            this.ChkBox_Monday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChkBox_Monday.Location = new System.Drawing.Point(14, 7);
            this.ChkBox_Monday.Name = "ChkBox_Monday";
            this.ChkBox_Monday.Size = new System.Drawing.Size(91, 29);
            this.ChkBox_Monday.TabIndex = 7;
            this.ChkBox_Monday.Text = "星期一";
            this.ChkBox_Monday.UseVisualStyleBackColor = true;
            // 
            // Wnd_AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Wnd_AddAlarm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加闹钟";
            this.Load += new System.EventHandler(this.Wnd_AddAlarm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            this.Panel_RepeatWeekday.ResumeLayout(false);
            this.Panel_RepeatWeekday.PerformLayout();
            this.Panel_Weekday.ResumeLayout(false);
            this.Panel_Weekday.PerformLayout();
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
        private System.Windows.Forms.Button button1;
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
    }
}