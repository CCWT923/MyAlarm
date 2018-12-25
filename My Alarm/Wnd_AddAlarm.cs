using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
