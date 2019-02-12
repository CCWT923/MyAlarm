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

        public RemindWindow(string title, string content = "")
        {
            InitializeComponent();
            this._AlarmContent = content;
            this._AlarmTitle = title;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemindWindow_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            Lbl_AlarmContent.Text = _AlarmContent;
            Lbl_AlarmTitle.Text = _AlarmTitle;
        }
    }
}
