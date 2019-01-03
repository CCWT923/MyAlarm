using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Alarm;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Util.REPEATINTERVAL interval = new Util.REPEATINTERVAL();
            interval.Daily = false;
            interval.Monthly = true;
            interval.DayOfMonth = 12;
            Util.ALARMINFO info = new Util.ALARMINFO();
            info.AlarmContents = "无备注";
            info.AlarmDate = DateTime.Now;
            info.AlarmName = "测试";
            info.CreateDate = DateTime.Now;
            info.RepeatInterval = interval;

            string xmlStr = Util.GetRepeatIntervalString(info.RepeatInterval);
            //Debug.WriteLine(xmlStr);
            var x = Util.GetRepeatInfo(xmlStr);
            Assert.AreEqual(12,x.DayOfMonth);
            Assert.AreEqual(true, x.Monthly);
            Assert.AreEqual(false, interval.Once);
        }
    }
}
