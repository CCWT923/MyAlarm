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
        Util util;
        #endregion

        private void Btn_AddAlarm_Click(object sender, EventArgs e)
        {
            Wnd_AddAlarm wnd_AddAlarm = new Wnd_AddAlarm();
            if(wnd_AddAlarm.ShowDialog() == DialogResult.OK)
            {
                CreateAlarmItem(Pub.AlarmInfo,false);
            }
            
        }
        /// <summary>
        /// 创建闹钟对象，并添加到数据库
        /// </summary>
        /// <param name="alarmInfo">一个存储闹钟信息的结构体变量</param>
        /// <param name="readFlag">该标志指示是读取（true）或创建（false）</param>
        private void CreateAlarmItem(Util.ALARMINFO alarmInfo, bool readFlag)
        {

            if(!readFlag) //创建新的闹钟项目
            {
                try
                {
                    dbHelper.InsertData(dbHelper.MainTableName, Util.GetStringArrayFromAlarmInfo(alarmInfo));
                    AlarmItem item = new AlarmItem(ref alarmInfo);
                    LayoutPanel_AlarmItems.Controls.Add(item);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else //从数据库中读取，然后显示的项目
            {
                AlarmItem item = new AlarmItem(ref alarmInfo);
                LayoutPanel_AlarmItems.Controls.Add(item);
            }
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
                    CreateAlarmItem(Util.ParseAlarmInfo(Pub.QuickAlarmInfo),false);
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
            else
            {
#if DEBUG
                //Lbl_Debug.Text = "全局热键：" + "Alt+Ctrl+" + (char)vitualKey;
#endif
            }
            dbHelper = new DBAssistant();
            //读取数据库中有效的闹钟
            util = new Util();
            var table = dbHelper.GetValidAlarmList();
            var alarms = util.GetAlarmInfoFromTable(ref table);
            foreach(var alarm in alarms)
            {
                CreateAlarmItem(alarm,true);
            }
        }
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeAlarmItems();
        }
        /// <summary>
        /// 调整所有AlarmItems的尺寸，根据窗口大小
        /// </summary>
        private void ResizeAlarmItems()
        {
            foreach(var a in LayoutPanel_AlarmItems.Controls)
            {
                ((AlarmItem)a).ResizeWidth();
            }
        }

        private void Btn_DeleteAlarm_Click(object sender, EventArgs e)
        {
            DeleteCheckedAlarmItems();
        }
        /// <summary>
        /// 删除选中的AlarmItem
        /// </summary>
        private void DeleteCheckedAlarmItems()
        {
            for(int i = 0; i < LayoutPanel_AlarmItems.Controls.Count;i++)
            {
                if(((AlarmItem)LayoutPanel_AlarmItems.Controls[i]).Checked)
                {
                    //从数据库中删除
                    dbHelper.DeleteAlarmByID(((AlarmItem)LayoutPanel_AlarmItems.Controls[i]).AlarmID);
                    //从窗口中移除
                    LayoutPanel_AlarmItems.Controls.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
