using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;

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

            ///TODO: 如何解析。
            ///例如： add 10 min, add 10 hour, add 10 day
            ///at 1/20 20:35， 每年的1月20日重复
            ///at 20:35，每天的20:35分重复
            info.CreateDate = DateTime.Now;
            info.AlarmDate = DateTime.Now.AddMinutes(5);
            info.AlarmContents = "";
            info.Enable = true;
            info.AlarmName = "Quick Add Alarm";
            info.RepeatInterval.Once = true;
            info.RepeatInterval.Daily = false;
            info.RepeatInterval.Monthly = false;
            info.RepeatInterval.Weekly = false;
            return info;
        }
    }
}
