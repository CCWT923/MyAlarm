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
            DateTimePicker_AlarmDate.MinDate = DateTime.Now;
            DateTimePicker_AlarmDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            
        }

        private void RadBtn_RepeatWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_RepeatWeekday.Checked)
            {
                Panel_RepeatWeekday.Enabled = true;

            }
            else
            {
                Panel_RepeatWeekday.Enabled = false;
            }
        }

        private void RadBtn_RepeatMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if(RadBtn_RepeatMonthly.Checked)
            {
                Combox_RepeatDayOfMonth.Enabled = true;
            }
            else
            {
                Combox_RepeatDayOfMonth.Enabled = false;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_SaveAlarm_Click(object sender, EventArgs e)
        {
            Util.ALARMINFO alarmInfo = new Util.ALARMINFO();
            Util.REPEATINTERVAL repeatInterval = new Util.REPEATINTERVAL();
            alarmInfo.AlarmDate = DateTimePicker_AlarmDate.Value;
            alarmInfo.CreateDate = DateTime.Now;
            alarmInfo.AlarmSound = TextBox_AlarmSound.Text;
            alarmInfo.AlarmName = TextBox_AlarmName.Text;
            alarmInfo.AlarmContents = TextBox_AlarmContents.Text;
            if(RadBtn_RepeatOnce.Checked)
            {
                repeatInterval.Once = true;
                repeatInterval.Weekly = false;
                repeatInterval.Monthly = false;
            }
            else if(RadBtn_RepeatMonthly.Checked)
            {
                repeatInterval.Monthly = true;
                repeatInterval.DayOfMonth = int.Parse(Combox_RepeatDayOfMonth.SelectedItem.ToString());
                repeatInterval.Once = false;
                repeatInterval.Weekly = false;
            }
            else if(RadBtn_RepeatWeekday.Checked)
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
        }
    }
}
