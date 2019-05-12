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
            AlarmUtil.REPEATINTERVAL interval = new AlarmUtil.REPEATINTERVAL();
            interval.Daily = false;
            interval.Monthly = true;
            interval.DayOfMonth = 12;
            AlarmUtil.ALARMINFO info = new AlarmUtil.ALARMINFO();
            info.AlarmContents = "无备注";
            info.AlarmDate = DateTime.Now;
            info.AlarmName = "测试";
            info.CreateDate = DateTime.Now;
            info.RepeatInterval = interval;

            string xmlStr = AlarmUtil.GetRepeatIntervalString(info.RepeatInterval);
            //Debug.WriteLine(xmlStr);
            var x = AlarmUtil.GetRepeatInfo(xmlStr);
            Assert.AreEqual(12,x.DayOfMonth);
            Assert.AreEqual(true, x.Monthly);
            Assert.AreEqual(false, interval.Once);
        }
    }
}
