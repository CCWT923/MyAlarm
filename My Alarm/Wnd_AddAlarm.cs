﻿using System;
using System.Windows.Forms;


namespace My_Alarm
{
    public partial class Wnd_AddAlarm : Form
    {
        public Wnd_AddAlarm()
        {
            InitializeComponent();
            SetAlarmDefault();
        }
        /// <summary>
        /// 通过一个AlarmInfo来初始化窗口
        /// </summary>
        /// <param name="alarmInfo"></param>
        public Wnd_AddAlarm(AlarmUtil.ALARMINFO alarmInfo)
        {
            InitializeComponent();
            this.Combox_Hour.SelectedItem = alarmInfo.AlarmDate.Hour.ToString();
            this.Combox_Minute.SelectedItem = alarmInfo.AlarmDate.Minute.ToString();
            this.DateTimePicker_AlarmDate.Value = alarmInfo.AlarmDate;
            this.TextBox_AlarmContents.Text = alarmInfo.AlarmContents;
            this.TextBox_AlarmName.Text = alarmInfo.AlarmName;
            this.TextBox_AlarmSound.Text = alarmInfo.AlarmSound;
            if(alarmInfo.RepeatInterval.Once)
            {
                this.RadBtn_RepeatOnce.Checked = true;
                this.Panel_Weekday.Enabled = false;
                this.Panel_RepeatWeekday.Enabled = false;
            }
            if(alarmInfo.RepeatInterval.Daily)
            {
                this.ChkBox_Daily.Checked = true;
                RadBtn_Repeat.Checked = true;
                Combox_RepeatDayOfMonth.Enabled = false;
            }
            if(alarmInfo.RepeatInterval.Monthly)
            {
                this.RadBtn_Repeat.Checked = true;
                this.RadBtn_RepeatMonthly.Checked = true;
                this.Combox_RepeatDayOfMonth.SelectedItem = alarmInfo.RepeatInterval.DayOfMonth.ToString();
            }
            if(alarmInfo.RepeatInterval.Weekly)
            {
                this.RadBtn_Repeat.Checked = true;
                this.ChkBox_Daily.Checked = false;
                if(alarmInfo.RepeatInterval.Monday)
                {
                    this.ChkBox_Monday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Tuesday)
                {
                    this.ChkBox_Tuesday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Wednesday)
                {
                    this.ChkBox_Wednesday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Thursday)
                {
                    this.ChkBox_Thursday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Friday)
                {
                    this.ChkBox_Friday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Saturday)
                {
                    this.ChkBox_Saturday.Checked = true;
                }
                if (alarmInfo.RepeatInterval.Sunday)
                {
                    this.ChkBox_Sunday.Checked = true;
                }
            }

        }

        /// <summary>
        /// 默认闹钟名字
        /// </summary>
        private string _DefaultAlarmName = "Alarm";
        private void SetAlarmDefault()
        {
            //DateTimePicker_AlarmDate.CustomFormat = "yyyy/MM/dd";
            DateTime t = DateTime.Now.AddMinutes(5.0);
            DateTimePicker_AlarmDate.Value = t;
            Combox_Hour.SelectedItem = t.Hour.ToString();
            Combox_Minute.SelectedItem = t.Minute.ToString();            
            
            RadBtn_RepeatOnce.Checked = true;
            RadBtn_RepeatMonthly.Checked = false;
            Combox_RepeatDayOfMonth.Enabled = false;
            RadBtn_Repeat.Checked = false;
            Panel_RepeatWeekday.Enabled = false;
            Panel_Weekday.Enabled = false;
            Combox_RepeatDayOfMonth.SelectedIndex = 0;
        }
        /// <summary>
        /// 是否重复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBtn_Repeat_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_Repeat.Checked)
            {
                Panel_RepeatWeekday.Enabled = true;
                ChkBox_Daily.Checked = true;
            }
            else
            {
                Panel_RepeatWeekday.Enabled = false;
                Panel_Weekday.Enabled = false;
            }
        }
        /// <summary>
        /// 按月重复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadBtn_RepeatMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_RepeatMonthly.Checked)
            {
                Combox_RepeatDayOfMonth.Enabled = true;
                ChkBox_Daily.Checked = false;
                Panel_Weekday.Enabled = false;
            }
            else
            {
                Combox_RepeatDayOfMonth.Enabled = false;
            }
        }
        /// <summary>
        /// 取消新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SaveAlarm_Click(object sender, EventArgs e)
        {
            Pub.AlarmInfo = GetAlarmDetail();
        }
        /// <summary>
        /// 根据用户的选择，获取该闹钟的详细信息
        /// </summary>
        /// <returns></returns>
        private AlarmUtil.ALARMINFO GetAlarmDetail()
        {
            AlarmUtil.ALARMINFO alarmInfo = new AlarmUtil.ALARMINFO();
            AlarmUtil.REPEATINTERVAL repeatInterval = new AlarmUtil.REPEATINTERVAL();
            alarmInfo.AlarmDate = new DateTime
                (
                    DateTimePicker_AlarmDate.Value.Year,
                    DateTimePicker_AlarmDate.Value.Month,
                    DateTimePicker_AlarmDate.Value.Day,
                    int.Parse(Combox_Hour.SelectedItem.ToString()),
                    int.Parse(Combox_Minute.SelectedItem.ToString()),
                    0
                );
            alarmInfo.CreateDate = DateTime.Now;
            alarmInfo.AlarmSound = TextBox_AlarmSound.Text;
            alarmInfo.AlarmName = TextBox_AlarmName.Text;
            alarmInfo.AlarmContents = TextBox_AlarmContents.Text;
            if (RadBtn_RepeatOnce.Checked) //一次性，不重复
            {
                repeatInterval.Once = true;
                repeatInterval.Weekly = false;
                repeatInterval.Monthly = false;
                repeatInterval.Daily = false;
            }
            else if(ChkBox_Daily.Checked) //每日重复
            {
                repeatInterval.Daily = true;
                repeatInterval.Once = false;
                repeatInterval.Monthly = false;
                repeatInterval.Weekly = false;
            }
            else if (RadBtn_RepeatMonthly.Checked) //按月重复
            {
                repeatInterval.Monthly = true;
                repeatInterval.DayOfMonth = int.Parse(Combox_RepeatDayOfMonth.SelectedItem.ToString());
                repeatInterval.Once = false;
                repeatInterval.Weekly = false;
                repeatInterval.Daily = false;
            }
            else if(!RadBtn_RepeatOnce.Checked && !ChkBox_Daily.Checked && !RadBtn_RepeatMonthly.Checked) //每周几重复
            {
                repeatInterval.Weekly = true;
                repeatInterval.Monday = ChkBox_Monday.Checked;
                repeatInterval.Tuesday = ChkBox_Tuesday.Checked;
                repeatInterval.Wednesday = ChkBox_Wednesday.Checked;
                repeatInterval.Thursday = ChkBox_Thursday.Checked;
                repeatInterval.Friday = ChkBox_Friday.Checked;
                repeatInterval.Saturday = ChkBox_Saturday.Checked;
                repeatInterval.Sunday = ChkBox_Sunday.Checked;
                repeatInterval.Monthly = false;
                repeatInterval.Once = false;
                repeatInterval.Daily = false;
            }
            else
            {
                throw new Exception("Error Choice!");
            }
            alarmInfo.RepeatInterval = repeatInterval;
            alarmInfo.AlarmStatus = true;
            return alarmInfo;
        }
        /// <summary>
        /// 每日重复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkBox_Daily_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkBox_Daily.Checked)
            {
                Panel_Weekday.Enabled = false;
                Combox_RepeatDayOfMonth.Enabled = false;
                RadBtn_RepeatMonthly.Checked = false;
            }
            else
            {
                Panel_Weekday.Enabled = true;
            }
        }

        private void Btn_SelectSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectSoundDialog = new OpenFileDialog();
            selectSoundDialog.Filter = "声音文件|*.mp3;*.wav;*.amr";
            if(selectSoundDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox_AlarmSound.Text = selectSoundDialog.FileName;
            }
        }
        #region 闹钟名称设置
        private void TextBox_AlarmName_Enter(object sender, EventArgs e)
        {
            if(TextBox_AlarmName.Text == _DefaultAlarmName)
            {
                TextBox_AlarmName.Text = "";
                TextBox_AlarmName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TextBox_AlarmName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox_AlarmName_Leave(object sender, EventArgs e)
        {
            if(TextBox_AlarmName.Text.Trim() == string.Empty)
            {
                TextBox_AlarmName.Text = _DefaultAlarmName;
                TextBox_AlarmName.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                TextBox_AlarmName.ForeColor = System.Drawing.Color.Black;
            }
        }
        #endregion

    }
}
