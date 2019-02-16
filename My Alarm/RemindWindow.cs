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

        public RemindWindow(string title, string content, Util.RemindWindowDisplayMode displayMode)
        {
            InitializeComponent();
            this._AlarmContent = content;
            this._AlarmTitle = title;
            this.TopMost = true;
            //窗口的显示模式
            if(displayMode == Util.RemindWindowDisplayMode.Fullscreen)
            {
                Panel_Title.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
            else if(displayMode == Util.RemindWindowDisplayMode.PopFromBottomRightCorner)
            {
                Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
                this.PointToClient(p);
                this.Location = p;
            }
            else if(displayMode == Util.RemindWindowDisplayMode.CenterScreen)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemindWindow_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "5";
            Lbl_AlarmTitle.Text = _AlarmTitle;
            Btn_Snooze.Text = string.Format("推迟{0}分钟",comboBox1.SelectedItem.ToString());
        }
    }
}
