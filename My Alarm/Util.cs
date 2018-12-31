using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Alarm
{
    public class Util
    {
        /// <summary>
        /// 存储闹钟信息的结构体
        /// </summary>
        public struct ALARMINFO
        {
            public DateTime CreateDate;
            public DateTime AlarmDate;
            public string AlarmName;
            public string AlarmContents;
            public string AlarmSound;
            public REPEATINTERVAL RepeatInterval;
            public bool Enable;
        }
        /// <summary>
        /// 重复周期
        /// </summary>
        public struct REPEATINTERVAL
        {
            public bool Once;
            public bool Weekly;
            public bool Monday;
            public bool Tuesday;
            public bool Wednesday;
            public bool Thursday;
            public bool Friday;
            public bool Saturday;
            public bool Sunday;
            public bool Monthly;
            public int DayOfMonth;
        }
        public static string[] GetStringArrayFromAlarmInfo(ALARMINFO info)
        {
            string[] arr = new string[]
            {
                info.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"),
                info.AlarmDate.ToString("yyyy-MM-dd HH:mm:ss"),
                "false",
                info.RepeatInterval.ToString(),
                info.AlarmName,
                info.AlarmContents,
                info.AlarmSound,
                "0",
                "true"
            };

            return arr;
        }
    }
}
