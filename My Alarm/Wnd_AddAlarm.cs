using System;
using System.Windows.Forms;

namespace My_Alarm
{
    public partial class Wnd_AddAlarm : Form
    {
        public Wnd_AddAlarm()
        {
            InitializeComponent();
        }

        private void Wnd_AddAlarm_Load(object sender, EventArgs e)
        {
            //DateTimePicker_AlarmDate.MinDate = DateTime.Now;
            DateTimePicker_AlarmDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
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
        private Util.ALARMINFO GetAlarmDetail()
        {
            Util.ALARMINFO alarmInfo = new Util.ALARMINFO();
            Util.REPEATINTERVAL repeatInterval = new Util.REPEATINTERVAL();
            alarmInfo.AlarmDate = DateTimePicker_AlarmDate.Value;
            alarmInfo.CreateDate = DateTime.Now;
            alarmInfo.AlarmSound = TextBox_AlarmSound.Text;
            alarmInfo.AlarmName = TextBox_AlarmName.Text;
            alarmInfo.AlarmContents = TextBox_AlarmContents.Text;
            if (RadBtn_RepeatOnce.Checked)
            {
                repeatInterval.Once = true;
                repeatInterval.Weekly = false;
                repeatInterval.Monthly = false;
            }
            else if (RadBtn_RepeatMonthly.Checked)
            {
                repeatInterval.Monthly = true;
                repeatInterval.DayOfMonth = int.Parse(Combox_RepeatDayOfMonth.SelectedItem.ToString());
                repeatInterval.Once = false;
                repeatInterval.Weekly = false;
            }
            else if (RadBtn_Repeat.Checked)
            {
                repeatInterval.Weekly = true;
                repeatInterval.Once = false;
                repeatInterval.Monthly = false;
                repeatInterval.Monday = ChkBox_Monday.Checked;
                repeatInterval.Tuesday = ChkBox_Tuesday.Checked;
                repeatInterval.Wednesday = ChkBox_Wednesday.Checked;
                repeatInterval.Thursday = ChkBox_Thursday.Checked;
                repeatInterval.Friday = ChkBox_Friday.Checked;
                repeatInterval.Saturday = ChkBox_Saturday.Checked;
                repeatInterval.Sunday = ChkBox_Sunday.Checked;
            }
            alarmInfo.RepeatInterval = repeatInterval;
            alarmInfo.Enable = true;
            return alarmInfo;
        }

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
    }
}
