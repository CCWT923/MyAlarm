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
        uint vitualKey = (uint)Keys.N;
        Util util;
        #endregion

        private void Btn_AddAlarm_Click(object sender, EventArgs e)
        {
            Wnd_AddAlarm wnd_AddAlarm = new Wnd_AddAlarm();
            if(wnd_AddAlarm.ShowDialog() == DialogResult.OK)
            {
                CreateAlarmItem(Pub.AlarmInfo, readFlag:false);
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
                    Pub.dbHelper.InsertData(Pub.dbHelper.MainTableName, Util.GetStringArrayFromAlarmInfo(alarmInfo));
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
                quickAddAlarm.Focus();
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
            RegisterHotkey();

            timer1.Enabled = true;

            Pub.dbHelper = new DBAssistant();
            //读取数据库中的闹钟
            util = new Util();
            var table = Pub.dbHelper.GetValidAlarmList();
            var alarms = util.GetAlarmInfoFromTable(ref table);
            foreach(var alarm in alarms)
            {
                CreateAlarmItem(alarm,true);
            }
        }
        /// <summary>
        /// 注册全局快捷键
        /// </summary>
        private void RegisterHotkey()
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
                    Pub.dbHelper.DeleteAlarmByID(((AlarmItem)LayoutPanel_AlarmItems.Controls[i]).AlarmID);
                    //从窗口中移除
                    LayoutPanel_AlarmItems.Controls.RemoveAt(i);
                    break;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CheckAlarmItem();
        }
        /// <summary>
        /// 检查每一个闹钟项目是否时间到达
        /// </summary>
        private void CheckAlarmItem()
        {
            foreach(AlarmItem item in LayoutPanel_AlarmItems.Controls)
            {
                if(item.AlarmStatus)
                {
                    if (DateTime.Now.Year == item.AlarmDate.Year && DateTime.Now.Month == item.AlarmDate.Month 
                        && DateTime.Now.Day == item.AlarmDate.Day && DateTime.Now.Hour == item.AlarmDate.Hour 
                        && DateTime.Now.Minute == item.AlarmDate.Minute && DateTime.Now.Second == item.AlarmDate.Second)
                    {
                        //显示提示窗口
                        item.AlarmStatus = false;
                        RemindWindow remind = new RemindWindow(item.AlarmTitle, item.AlarmContents, Util.RemindWindowDisplayMode.CenterScreen);
                        //推迟
                        if (remind.ShowDialog() == DialogResult.OK)
                        {
                            item.AlarmDate = DateTime.Now.AddMinutes(Pub.SnoozeValue);
                            item.AlarmStatus = true;
                        }
                        else
                        {
                            //关闭了提醒窗口，处理当前闹钟信息
                            if(item.AlarmRepeatInterval.Once)
                            {
                                item.AlarmStatus = false;
                            }
                        }
                    }
                }

            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                NotifyIcon1.Icon = Properties.Resources.Alarm_Normal_32;
                NotifyIcon1.Visible = true;
                //不在任务管理器的“应用程序”选项卡中显示
                SetVisibleCore(false);
                RegisterHotkey();
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.SetVisibleCore(true);
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.NotifyIcon1.Visible = false;
                this.Activate();
                RegisterHotkey();
            }
        }

        private void Btn_EditAlarm_Click(object sender, EventArgs e)
        {
            if(Pub.CurrentSelectedItem != null)
            {
                EditCurrentItem();
            }
        }
        /// <summary>
        /// TODO：编辑当前选择的项目
        /// </summary>
        private void EditCurrentItem()
        {
            Wnd_AddAlarm addAlarm = new Wnd_AddAlarm(Pub.CurrentSelectedItem.AlarmInfo);
            addAlarm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要关闭 Free Alarm 吗？", "关闭确认", buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Pub.dbHelper.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
