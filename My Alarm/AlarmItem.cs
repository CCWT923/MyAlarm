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
        public AlarmItem(string AlarmTitle, DateTime AlarmDate)
        {
            InitializeComponent();
            ++_Counter;
            this.AlarmDate = AlarmDate;
            this.AlarmTitle = AlarmTitle;
            this.ItemNumber = _Counter;
        }

        #region 私有字段
        private DateTime _AlarmDate;
        private string _AlarmTitle;
        private string _AlarmContents;
        private string _AlarmSoundPath;
        private int _ItemNumber;
        private static int _Counter;
        #endregion

        #region 公共属性
        /// <summary>
        /// 闹钟的日期时间
        /// </summary>
        public DateTime AlarmDate
        {
            get { return _AlarmDate; }
            set
            {
                _AlarmDate = value;
                Lbl_AlarmDate.Text = _AlarmDate.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        /// <summary>
        /// 闹钟备注信息
        /// </summary>
        public string AlarmContents
        {
            get { return _AlarmContents; }
            set
            {
                _AlarmContents = value;
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
            get;
            set;
        }
        /// <summary>
        /// 设置序号
        /// </summary>
        public int ItemNumber
        {
            get { return _ItemNumber; }
            set
            {
                _ItemNumber = value;
                Lbl_Number.Text = _ItemNumber.ToString();
            }
        }
        #endregion

        private void AlarmItem_Load(object sender, EventArgs e)
        {
            //设置为父控件大小
            this.Width = Parent.ClientRectangle.Width ;
        }
    }
}
