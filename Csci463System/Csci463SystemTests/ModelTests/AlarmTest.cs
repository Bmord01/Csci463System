using Csci463System.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests
{
    [TestClass]
    public class AlarmTest
    {
        [TestMethod]
        public void TestCreator()
        {
            Alarm alarm = new Alarm();
            Assert.IsNotNull(alarm);
            
        }
        [TestMethod]
        public void ChangeMessageTest()
        {
            Alarm alarm = new Alarm();
            alarm.Message = "Alarm Message";
            Assert.AreEqual(alarm.Message, "Alarm Message");
        }
        [TestMethod]
        public void UpgradeSeverityTest()
        {
            Alarm alarm = new Alarm();
            alarm.UpgradeSeverity(3);
            Assert.AreEqual(alarm.Severity, Alarm.AlarmType.Fire);
        }
        [TestMethod]
        public void DowngradeSeverityTest()
        {
            Alarm alarm = new Alarm();
            alarm.UpgradeSeverity(3);
            Assert.AreEqual(alarm.Severity, Alarm.AlarmType.Fire);
            alarm.DowngradeSeverity();
            Assert.AreEqual(alarm.Severity, Alarm.AlarmType.None);
        }
    }
}
