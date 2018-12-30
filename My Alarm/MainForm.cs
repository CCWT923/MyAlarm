using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Alarm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_AddAlarm_Click(object sender, EventArgs e)
        {
            Wnd_AddAlarm wnd_AddAlarm = new Wnd_AddAlarm();
            if(wnd_AddAlarm.ShowDialog() == DialogResult.OK)
            {
                //TODO：在数据库中添加闹钟
                MessageBox.Show(Pub.AlarmInfo.AlarmContents + ";" + Pub.AlarmInfo.AlarmDate + "" + Pub.AlarmInfo.AlarmName);
            }
        }
    }
}
