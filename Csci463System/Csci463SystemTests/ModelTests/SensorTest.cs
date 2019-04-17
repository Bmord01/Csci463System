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
        public void ActivateTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            DoorSensor ds = new DoorSensor();

            ls.Activate();
            fs.Activate();
            ds.Activate();

            Assert.IsNotNull(ls.alarm);
            Assert.IsNotNull(fs.alarm);
            Assert.IsNotNull(ds.alarm);

            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();

            Assert.IsTrue(lsStatus);
            Assert.IsTrue(fsStatus);
            Assert.IsTrue(dsStatus);
        }
        [TestMethod]
        public void DeactivateTest()
        {
            LightSensor ls = new LightSensor();
            FireSensor fs = new FireSensor();
            DoorSensor ds = new DoorSensor();

            ls.Activate();
            fs.Activate();
            ds.Activate();

            Assert.IsNotNull(ls.alarm);
            Assert.IsNotNull(fs.alarm);
            Assert.IsNotNull(ds.alarm);

            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();

            Assert.IsTrue(lsStatus);
            Assert.IsTrue(fsStatus);
            Assert.IsTrue(dsStatus);

            ls.Deactivate();
            fs.Deactivate();
            ds.Deactivate();

            Assert.IsNull(ls.alarm);
            Assert.IsNull(fs.alarm);
            Assert.IsNull(ds.alarm);

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

            ls.Deactivate();
            fs.Deactivate();
            ds.Deactivate();

            bool lsStatus = ls.checkStatus();
            bool fsStatus = fs.checkStatus();
            bool dsStatus = ds.checkStatus();

            Assert.IsFalse(lsStatus);
            Assert.IsFalse(fsStatus);
            Assert.IsFalse(dsStatus);
        }
    }
}
