using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.Data;

namespace My_Alarm
{
    /// <summary>
    /// 定义的结构体和一些常用方法
    /// </summary>
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
            public int AlarmID;
        }
        /// <summary>
        /// 重复周期
        /// </summary>
        public struct REPEATINTERVAL
        {
            public bool Once;
            public bool Weekly;
            public bool Daily;
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
        /// <summary>
        /// 将AlarmInfo结构转换为字符串数组
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static string[] GetStringArrayFromAlarmInfo(ALARMINFO info)
        {
            GetRepeatInfo(GetRepeatIntervalString(info.RepeatInterval));
            string[] arr = new string[]
            {
                info.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"), //CreateTime
                info.AlarmDate.ToString("yyyy-MM-dd HH:mm:ss"), //AlarmDate
                "false", //IsExpired
                GetRepeatIntervalString(info.RepeatInterval), //Recurrence
                info.AlarmName, //Title
                info.AlarmContents, //Contents
                info.AlarmSound, //Sound
                "0", //DelayTime
                "true" //Enable
            };

            return arr;
        }
        /// <summary>
        /// 将RepeatInterval结构体写入字符串
        /// </summary>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static string GetRepeatIntervalString(REPEATINTERVAL interval)
        {
            string result = "<?xml version=\"1.0\" encoding=\"utf-8\"?><RepeatInterval><Once>" +
                interval.Once + "</Once>" + "<Monthly Status=\"" + interval.Monthly + "\"><DayOfMonth>" +
                (interval.Monthly == true ? interval.DayOfMonth : 0) + "</DayOfMonth></Monthly>" +
                "<Daily>" + interval.Daily + "</Daily><Weekly Status=\"" + interval.Weekly + "\"><Monday>" +
                interval.Monday + "</Monday><Tuesday>" + interval.Tuesday + "</Tuesday><Wednesday>" +
                interval.Wednesday + "</Wednesday><Thursday>" + interval.Thursday + "</Thursday><Friday>" +
                interval.Friday + "</Friday><Saturday>" + interval.Saturday + "</Saturday><Sunday>" +
                interval.Sunday + "</Sunday></Weekly></RepeatInterval>";
            return result ;
        }
        /// <summary>
        /// 从XML文件中读取Interval的值
        /// </summary>
        /// <param name="str">一个xml字符串</param>
        /// <returns></returns>
        public static REPEATINTERVAL GetRepeatInfo(string str)
        {
            REPEATINTERVAL interval = new REPEATINTERVAL();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(str);
            XmlNode node;
            XmlElement element;
            XmlAttribute attr;
            //选择指定的节点
            node = doc.SelectSingleNode("/RepeatInterval/Daily");
            interval.Daily = bool.Parse(node.InnerText);
            
            node = doc.SelectSingleNode("/RepeatInterval/Once");
            interval.Once = bool.Parse(node.InnerText);

            //选择属性，Weekly包含一个名为Status的属性
            node = doc.SelectSingleNode("/RepeatInterval/Weekly");
            element = (XmlElement)node;
            attr = element.GetAttributeNode("Status");
            interval.Weekly = bool.Parse(attr.InnerText);
            
            node = doc.SelectSingleNode("/RepeatInterval/Monthly");
            element = (XmlElement)node;
            attr = element.GetAttributeNode("Status");
            interval.Monthly = bool.Parse(attr.InnerText);
            
            node = doc.SelectSingleNode("/RepeatInterval/Monthly/DayOfMonth");
            interval.DayOfMonth = int.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Monday");
            interval.Monday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Tuesday");
            interval.Tuesday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Wednesday");
            interval.Wednesday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Thursday");
            interval.Thursday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Friday");
            interval.Friday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Saturday");
            interval.Saturday = bool.Parse(node.InnerText);

            node = doc.SelectSingleNode("/RepeatInterval/Weekly/Sunday");
            interval.Sunday = bool.Parse(node.InnerText);
            return interval;
        }

        public static ALARMINFO ParseAlarmInfo(string str)
        {
            ALARMINFO info = new ALARMINFO();
            info.CreateDate = DateTime.Now;
            info.AlarmName = "Alarm";
            info.AlarmContents = "";
            info.Enable = true;
            info.RepeatInterval.Once = true;
            info.RepeatInterval.Daily = false;
            info.RepeatInterval.Monthly = false;
            info.RepeatInterval.Weekly = false;
            /// TODO: 如何解析。
            /// 这里只提供快速添加功能，所以不需要判断add之类的词
            /// 例如： add 10 min, add 10 hour, add 10 day
            /// at 1/20 20:35， 每年的1月20日重复
            /// at 20:35，每天的20:35分重复
            var t = str.Split(' ');
            int value = 0;
            if(int.TryParse(t[0],out value))
            {
                //时间无效
                if(!(value > 0))
                {
                    info.Enable = false;
                    return info;
                }
                DateTime now;
                
                if(t[1].ToLower() == "min" || t[1].ToLower() == "m")
                {
                    now = DateTime.Now.AddMinutes(value);
                    //分钟
                    info.AlarmDate = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                }
                if(t[1].ToLower() == "hour" || t[1].ToLower() == "h")
                {
                    //小时
                    now = DateTime.Now.AddHours(value);
                    info.AlarmDate = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                }
                if(t[1].ToLower() == "day" || t[1].ToLower() == "d")
                {
                    //天
                    now = DateTime.Now.AddDays(value);
                    info.AlarmDate = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                }
                if(t.Length > 2)
                {
                    //有标题
                    info.AlarmName = t[2];
                    if(t.Length > 3)
                    {
                        //有备注
                        info.AlarmContents = t[3];
                    }
                }
            }
            else
            {
                info.Enable = false;
            }

            return info;
        }
        /// <summary>
        /// 从数据表中解析Alarm信息
        /// </summary>
        /// <param name="table">一个数据表，ref引用</param>
        /// <returns>返回一个List的AlarmInfo</returns>
        public List<ALARMINFO> GetAlarmInfoFromTable(ref DataTable table)
        {
            List<ALARMINFO> Alarms = new List<ALARMINFO>();
            ALARMINFO info = new ALARMINFO();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                info.AlarmID = int.Parse(table.Rows[i]["AlarmID"].ToString()); //ID
                info.CreateDate = DateTime.Parse(table.Rows[i]["CreateTime"].ToString()); //创建日期
                info.AlarmDate = DateTime.Parse(table.Rows[i]["AlarmDate"].ToString()); //提醒日期
                info.RepeatInterval = GetRepeatInfo(table.Rows[i]["Recurrence"].ToString()); //重复周期
                info.AlarmName = table.Rows[i]["Title"].ToString(); //标题
                info.AlarmContents = table.Rows[i]["Contents"].ToString(); //备注
                info.AlarmSound = table.Rows[i]["Sound"].ToString(); //声音路径
                info.Enable = int.Parse(table.Rows[i]["Enable"].ToString()) == 1 ? true : false; //是否启用
                Alarms.Add(info);
            }
            return Alarms;
        }
        /// <summary>
        /// 提醒窗口的显示模式
        /// </summary>
        public enum RemindWindowDisplayMode
        {
            /// <summary>
            /// 右下角弹窗
            /// </summary>
            PopFromBottomRightCorner,
            /// <summary>
            /// 全屏
            /// </summary>
            Fullscreen,
            /// <summary>
            /// 屏幕中间弹窗
            /// </summary>
            CenterScreen
        }
    }
}
