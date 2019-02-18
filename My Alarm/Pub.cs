using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Alarm
{
    class Pub
    {
        public static Util.ALARMINFO AlarmInfo;
        public static string QuickAlarmInfo;
        public static int SnoozeValue;
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        public static DBAssistant dbHelper;
        /// <summary>
        /// 当前选择的AlarmInfo
        /// </summary>
        public static AlarmItem CurrentSelectedItem;
    }
}
