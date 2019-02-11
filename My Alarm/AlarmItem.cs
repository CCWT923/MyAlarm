using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Alarm
{
    public partial class AlarmItem : UserControl
    {
        public AlarmItem(ref Util.ALARMINFO alarmInfo)
        {
            InitializeComponent();
            ++_Counter;
            this.AlarmDate = alarmInfo.AlarmDate;
            this.AlarmTitle = alarmInfo.AlarmName;
            this.AlarmRepeatInterval = alarmInfo.RepeatInterval;
            this.AlarmContents = alarmInfo.AlarmContents;
            //this.ItemNumber = _Counter;
            this.BackColor = _DefaultBackgroundColor;
            this.Checked = false;
            this.AlarmID = alarmInfo.AlarmID;
        }

        #region 私有字段
        /// <summary>
        /// 闹钟日期
        /// </summary>
        private DateTime _AlarmDate;
        /// <summary>
        /// 闹钟标题
        /// </summary>
        private string _AlarmTitle;
        /// <summary>
        /// 闹钟备注
        /// </summary>
        private string _AlarmContents;
        /// <summary>
        /// 闹钟提示音路径
        /// </summary>
        private string _AlarmSoundPath;
        /// <summary>
        /// 闹钟序号
        /// </summary>
        private int _ItemNumber;
        /// <summary>
        /// 闹钟的重复周期
        /// </summary>
        private Util.REPEATINTERVAL _AlarmRepeatInterval;
        /// <summary>
        /// 计数器
        /// </summary>
        private static int _Counter;
        /// <summary>
        /// 默认背景色
        /// </summary>
        private Color _DefaultBackgroundColor = Color.White;
        /// <summary>
        /// 字体样式
        /// </summary>
        private Font _Font;
        /// <summary>
        /// 字体颜色
        /// </summary>
        private Color _FontColor;
        /// <summary>
        /// 闹钟的ID值
        /// </summary>
        private int _AlarmID;
        /// <summary>
        /// 高亮背景色，鼠标经过时的背景色
        /// </summary>
        private Color _HighlightBackgroundColor = Color.FromArgb(255,230,230,230);
        /// <summary>
        /// 选中状态下的背景色
        /// </summary>
        private Color _CheckedBackgroundColor = Color.FromArgb(255,200,200,200);
        /// <summary>
        /// 鼠标经过选中状态时的背景色
        /// </summary>
        private Color _HighlightBackgroundColor_Checked = Color.FromArgb(255,170,170,255);
        /// <summary>
        /// 该控件是否被选中
        /// </summary>
        private bool _Checked;
        /// <summary>
        /// 最大允许选择的数量
        /// </summary>
        private const int _MaxSelectLimite = 1;
        /// <summary>
        /// 当前已经选择的数量
        /// </summary>
        private static int _CurrentSelectNumber = 0;
        /// <summary>
        /// 上一个被选择对象的引用
        /// </summary>
        private static AlarmItem _LastSelectItem = null;
        #endregion


        #region 公共属性
        /// <summary>
        /// 获取或设置当前控件的选中状态
        /// </summary>
        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
            }
        }
        /// <summary>
        /// 默认背景色
        /// </summary>
        public Color DefaultBackgroundColor
        {
            get
            {
                return _DefaultBackgroundColor;
            }
            set
            {
                _DefaultBackgroundColor = value;
            }
        }
        /// <summary>
        /// 选中状态下的背景色
        /// </summary>
        public Color CheckedBackgroundColor
        {
            get
            {
                return _CheckedBackgroundColor;
            }
            set
            {
                _CheckedBackgroundColor = value;
            }
        }
        /// <summary>
        /// 鼠标经过时的高亮颜色
        /// </summary>
        public Color HighlightBackgroundColor
        {
            get
            {
                return _HighlightBackgroundColor;
            }
            set
            {
                _HighlightBackgroundColor = value;
            }
        }
        /// <summary>
        /// 闹钟的日期时间
        /// </summary>
        public DateTime AlarmDate
        {
            get { return _AlarmDate; }
            set
            {
                _AlarmDate = value;
                //是今天的日期，就只显示时间，否则，显示日期和时间
                if(_AlarmDate.Day == DateTime.Now.Day && _AlarmDate.Month == DateTime.Now.Month && _AlarmDate.Year == DateTime.Now.Year)
                {
                    Lbl_AlarmDate.Text = _AlarmDate.ToShortTimeString();
                }
                else
                {
                    Lbl_AlarmDate.Text = _AlarmDate.ToString("yyyy/MM/dd HH:mm");
                }
            }
        }
        /// <summary>
        /// 闹钟的ID值
        /// </summary>
        public int AlarmID
        {
            get
            {
                return _AlarmID;
            }
            set
            {
                _AlarmID = value;
                Lbl_AlarmID.Text = _AlarmID.ToString();
            }
        }
        /// <summary>
        /// 设置或获取闹钟备注信息
        /// </summary>
        public string AlarmContents
        {
            get { return _AlarmContents; }
            set
            {
                _AlarmContents = value;
                Lbl_AlarmContent.Text = _AlarmContents;
            }
        }
        /// <summary>
        /// 获取或设置闹钟的重复周期
        /// </summary>
        public Util.REPEATINTERVAL AlarmRepeatInterval
        {
            get
            {
                return _AlarmRepeatInterval;
            }
            set
            {
                _AlarmRepeatInterval = value;
                string ri = "";
                if(value.Daily)
                {
                    ri = "每天";
                }
                else if(value.Weekly)
                {
                    ri = "每周";
                }
                else if(value.Once)
                {
                    ri = "不重复";
                }
                else if(value.Monthly)
                {
                    ri = "每月";
                }
                Lbl_RepeatInterval.Text = ri;
            }
        }

        /// <summary>
        /// 闹钟标题
        /// </summary>
        public string AlarmTitle
        {
            get { return _AlarmTitle; }
            set
            {
                _AlarmTitle = value;
                Lbl_AlarmTitle.Text = _AlarmTitle;
            }
        }
        /// <summary>
        /// 闹钟的提示音路径
        /// </summary>
        public string AlarmSoundPath
        {
            get { return _AlarmSoundPath; }
            set
            {
                _AlarmSoundPath = value;
            }
        }

        /// <summary>
        /// 设置序号
        /// </summary>
        //public int ItemNumber
        //{
        //    get { return _ItemNumber; }
        //    set
        //    {
        //        _ItemNumber = value;
        //        Lbl_Number.Text = _ItemNumber.ToString();
        //    }
        //}

        /// <summary>
        /// 字体样式
        /// </summary>
        public new Font Font
        {
            get
            {
                return _Font;
            }
            set
            {
                _Font = value;
            }
        }
        /// <summary>
        /// 字体颜色
        /// </summary>
        public Color FontColor
        {
            get => _FontColor;
            set => _FontColor = value;
        }


        #endregion

        private void AlarmItem_Load(object sender, EventArgs e)
        {
            //设置为父控件大小
            ResizeWidth();
        }

        public void ResizeWidth()
        {
            this.Width = Parent.ClientRectangle.Width;
        }
        /// <summary>
        /// 鼠标进入时的事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmItem_MouseEnter(object sender, EventArgs e)
        {
            if(this.Checked)
            {
                return;
                //this.BackColor = _HighlightBackgroundColor_Checked;
            }
            else
            {
                this.BackColor = _HighlightBackgroundColor;

            }
        }
        /// <summary>
        /// 鼠标离开时的事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmItem_MouseLeave(object sender, EventArgs e)
        {
            //离开时未被选中，才将其设置位默认背景色
            if(!this.Checked)
            {
                this.BackColor = _DefaultBackgroundColor;
            }

        }
        /// <summary>
        /// 鼠标单击时的事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>只允许选择单个项目：记录上一个选择的控件ID，
        /// 通过一个变量来记录选择的数量如果超过最大选择数（这里设
        /// 定为1），那么就将上一个取消选择。</remarks>
        private void AlarmItem_Click(object sender, EventArgs e)
        {
            if (this.Checked)
            {
                this.Checked = false;
                this.BackColor = DefaultBackgroundColor;
            }
            else
            {
                //如果当前选中的项目还未到限制数量，则选择
                if (_CurrentSelectNumber < _MaxSelectLimite)
                {
                    this.Checked = true;
                    this.BackColor = CheckedBackgroundColor;
                    _LastSelectItem = this;
                    ++_CurrentSelectNumber;
                }
                else
                {
                    --_CurrentSelectNumber;
                    _LastSelectItem.Checked = false;
                    _LastSelectItem.BackColor = DefaultBackgroundColor;
                    this.Checked = true;
                    this.BackColor = CheckedBackgroundColor;
                    ++_CurrentSelectNumber;
                    _LastSelectItem = this;
                }
                System.Diagnostics.Debug.WriteLine("Last Select Item = " + _LastSelectItem.GetHashCode() + ", Current Select Item = " + this.GetHashCode());
            }
        }
    }
}
