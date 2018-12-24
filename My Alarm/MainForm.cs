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
            wnd_AddAlarm.ShowDialog();
        }
    }
}
