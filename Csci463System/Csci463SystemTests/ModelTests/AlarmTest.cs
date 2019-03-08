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
            alarm.Message = "Alarm Message";
            Assert.AreEqual(alarm.Message, "Alarm Message");
        }
    }
}
