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
    public partial class WndQuickAddAlarm : Form
    {
        public WndQuickAddAlarm()
        {
            InitializeComponent();
            TextBox_QuickAlarmInfo.Select(0, 0);
        }

        private void TextBox_QuickAlarmInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                Pub.QuickAlarmInfo = TextBox_QuickAlarmInfo.Text;
            }
            else if(e.KeyChar == (char)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void TextBox_QuickAlarmInfo_LostFocus(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WndQuickAddAlarm_Load(object sender, EventArgs e)
        {
            TextBox_QuickAlarmInfo.Focus();
        }
    }
}
