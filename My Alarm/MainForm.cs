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

        #region 全局变量
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        DBAssistant dbHelper;
        /// <summary>
        /// 当前窗口句柄
        /// </summary>
        IntPtr thisWindow;
        /// <summary>
        /// 表示热键是否成功注册
        /// </summary>
        bool successOfHotKey;
        /// <summary>
        /// 全局热键的虚拟键
        /// </summary>
        uint vitualKey = (uint)Keys.I;
        #endregion

        private void Btn_AddAlarm_Click(object sender, EventArgs e)
        {
            Wnd_AddAlarm wnd_AddAlarm = new Wnd_AddAlarm();
            if(wnd_AddAlarm.ShowDialog() == DialogResult.OK)
            {
                //TODO：在数据库中添加闹钟
                dbHelper = new DBAssistant();
                dbHelper.InsertData(dbHelper.MainTableName, Util.GetStringArrayFromAlarmInfo(Pub.AlarmInfo));
            }
            CreateAlarmItem(Pub.AlarmInfo);
        }

        private void CreateAlarmItem(Util.ALARMINFO alarmInfo)
        {
            AlarmItem item = new AlarmItem(alarmInfo.AlarmName,alarmInfo.AlarmDate);
            LayoutPanel_AlarmItems.Controls.Add(item);
        }

        #region 响应全局热键
        protected override void WndProc(ref Message keyPressed)
        {
            //热键被按下
            if(keyPressed.Msg == WinAPI.WM_HOTKEY)
            {
                //TODO: 快速添加闹钟
                WndQuickAddAlarm quickAddAlarm = new WndQuickAddAlarm();
                if(quickAddAlarm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(Pub.QuickAlarmInfo);
                }
            }
            base.WndProc(ref keyPressed);
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //全局快捷键的注册
            thisWindow = this.FindForm().Handle;
            successOfHotKey = WinAPI.RegisterHotKey(thisWindow, 0x3376, (uint)WinAPI.ModifierKeys.Alt | (uint)WinAPI.ModifierKeys.Control, vitualKey);
            if(!successOfHotKey)
            {
                MessageBox.Show("注册全局热键失败！");
            }


        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            foreach(var a in LayoutPanel_AlarmItems.Controls)
            {
                ((AlarmItem)a).ResizeWidth();
            }
        }
    }
}
