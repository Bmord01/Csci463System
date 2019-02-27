using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csci463System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests
{
    [TestClass]
    public class ZoneTest
    {
        [TestMethod]
        public void TestCreator()
        {

            Elevator elevator = new Elevator();
            Zone zone = new Zone(0);
            Assert.AreNotEqual(elevator, null);
            Assert.AreNotEqual(zone, null);
            Assert.AreNotEqual(zone.zones, null);
            Assert.AreEqual(zone.zoneType, Zone.ZoneType.Building);
        }
        [TestMethod]
        public void GetSensorTest()
        {
            Zone zone = new Zone(0);
            List<Sensor> sensors = zone.GetSensors();
            Assert.AreNotEqual(sensors, null);
            Assert.AreEqual(sensors, zone.sensors);
        }
        [TestMethod]
        public void GetZonesTest()
        {
            Zone zone = new Zone(0);
            List<Zone> zones = zone.GetZones();
            Assert.AreNotEqual(zones, null);
            Assert.AreEqual(zones, zone.zones);
        }
        [TestMethod]
        public void GetKeypadsTest()
        {
            Zone zone = new Zone(0);
            List<Keypad> keypads = zone.GetKeypads();
            Assert.AreNotEqual(keypads, null);
            Assert.AreEqual(keypads, zone.keypads);
        }
        
    }
}
