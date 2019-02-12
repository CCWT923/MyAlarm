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
    /// <summary>
    /// 以图形化的方式来显示一周中激活的星期
    /// </summary>
    public partial class WeekView : UserControl
    {
        public WeekView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 默认背景色
        /// </summary>
        private Color _DefaultBackColor_WeekView = Color.White;
        /// <summary>
        /// 激活的背景色
        /// </summary>
        private Color _SelectedBackColor = Color.Violet;
        /// <summary>
        /// 今天的星期
        /// </summary>
        private Color _IsTodayBackColor = Color.GreenYellow;

        /// <summary>
        /// 设置WeekView控件默认的背景色
        /// </summary>
        public Color DefaultBackColor_WeekView
        {
            get
            {
                return _DefaultBackColor_WeekView;
            }
            set
            {
                _DefaultBackColor_WeekView = value;
            }
        }
        /// <summary>
        /// 设置或获取被选择的星期的背景色
        /// </summary>
        public Color SelectedBackColor { get => _SelectedBackColor; set => _SelectedBackColor = value; }
        /// <summary>
        /// 设置或获取当天星期的背景色
        /// </summary>
        public Color IsTodayBackColor { get => _IsTodayBackColor; set => _IsTodayBackColor = value; }
        /// <summary>
        /// 设置各个星期
        /// </summary>
        public void Active1()
        {
            WeekView_Lbl_Monday.BackColor = _SelectedBackColor;
        }
        public void Active2()
        {
            WeekView_Lbl_Tuesday.BackColor = _SelectedBackColor;
        }
        public void Active3()
        {
            WeekView_Lbl_Wednesday.BackColor = _SelectedBackColor;
        }
        public void Active4()
        {
            WeekView_Lbl_Thursday.BackColor = _SelectedBackColor;
        }
        public void Active5()
        {
            WeekView_Lbl_Friday.BackColor = _SelectedBackColor;
        }
        public void Active6()
        {
            WeekView_Lbl_Saturday.BackColor = _SelectedBackColor;
        }
        public void Active7()
        {
            WeekView_Lbl_Sunday.BackColor = _SelectedBackColor;
        }
        /// <summary>
        /// 设置今天是星期几
        /// </summary>
        /// <param name="day"></param>
        public void SelectToday(int day)
        {
            if(day == 1)
            {
                WeekView_Lbl_Monday.BackColor = _IsTodayBackColor;
            }
            if(day == 2)
            {
                WeekView_Lbl_Tuesday.BackColor = _IsTodayBackColor;
            }
            if (day == 3)
            {
                WeekView_Lbl_Wednesday.BackColor = _IsTodayBackColor;
            }
            if (day == 4)
            {
                WeekView_Lbl_Thursday.BackColor = _IsTodayBackColor;
            }
            if (day == 5)
            {
                WeekView_Lbl_Friday.BackColor = _IsTodayBackColor;
            }
            if (day == 6)
            {
                WeekView_Lbl_Saturday.BackColor = _IsTodayBackColor; 
            }
            if (day == 7)
            {
                WeekView_Lbl_Sunday.BackColor = _IsTodayBackColor;
            }
        }
    }
}
