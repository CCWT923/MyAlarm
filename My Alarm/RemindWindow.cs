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
    public partial class RemindWindow : Form
    {
        private string _AlarmTitle;
        private string _AlarmContent;

        public RemindWindow(string title, string content, AlarmUtil.RemindWindowDisplayMode displayMode)
        {
            InitializeComponent();
            this._AlarmContent = content;
            this._AlarmTitle = title;
            this.TopMost = true;
            //窗口的显示模式
            if(displayMode == AlarmUtil.RemindWindowDisplayMode.Fullscreen)
            {
                Panel_Title.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
            else if(displayMode == AlarmUtil.RemindWindowDisplayMode.PopFromBottomRightCorner)
            {
                Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
                this.PointToClient(p);
                this.Location = p;
            }
            else if(displayMode == AlarmUtil.RemindWindowDisplayMode.CenterScreen)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void RemindWindow_Load(object sender, EventArgs e)
        {
            Lbl_AlarmTitle.Text = _AlarmTitle;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Lbl_CurrentTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Btn_Snooze_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Pub.SnoozeValue = 5;
            this.Close();
        }
    }
}
