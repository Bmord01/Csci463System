using Csci463System.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests.ModelTests
{
    [TestClass]
    public class SensorTest
    {
        [TestMethod]
        public void TestCreator()
        {
            LightSensor ls = new LightSensor();
            Assert.IsNotNull(ls);
            FireSensor fs = new FireSensor();
            Assert.IsNotNull(fs);
            DoorSensor ds = new DoorSensor();
            Assert.IsNotNull(ds);
        }
        [TestMethod]
        public void CheckStatusTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            DoorSensor ds = new DoorSensor();
            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();
            Assert.IsFalse(lsStatus);
            Assert.IsFalse(fsStatus);
            Assert.IsFalse(dsStatus);
        }
        [TestMethod]
        public void GetUIDTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            LightSensor ls2 = new LightSensor();
            FireSensor fs2 = new FireSensor();
            DoorSensor ds = new DoorSensor();
            DoorSensor ds2 = new DoorSensor();
            Assert.AreNotEqual(ls.getSensorUID(), ls2.getSensorUID());
            Assert.AreNotEqual(fs.getSensorUID(), fs2.getSensorUID());
            Assert.AreNotEqual(ds.getSensorUID(), ds2.getSensorUID());
        }
        [TestMethod]
        public void TriggerSensorTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            DoorSensor ds = new DoorSensor();

            Alarm lsA = ls.triggerSensor();
            Alarm fsA = fs.triggerSensor();
            Alarm dsA = ds.triggerSensor();

            Assert.IsNotNull(lsA);
            Assert.IsNotNull(fsA);
            Assert.IsNotNull(dsA);

            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();

            Assert.IsTrue(lsStatus);
            Assert.IsTrue(fsStatus);
            Assert.IsTrue(dsStatus);
        }
        [TestMethod]
        public void SupressSensorTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            DoorSensor ds = new DoorSensor();

            Alarm lsA = ls.triggerSensor();
            Alarm fsA = fs.triggerSensor();
            Alarm dsA = ds.triggerSensor();

            ls.SupressSensor();
            fs.SupressSensor();
            ds.SupressSensor();

            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();

            Assert.IsFalse(lsStatus);
            Assert.IsFalse(fsStatus);
            Assert.IsFalse(dsStatus);
        }
    }
}
