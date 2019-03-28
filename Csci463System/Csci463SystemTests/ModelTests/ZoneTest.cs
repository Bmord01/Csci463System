using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csci463System.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Csci463System.Interfaces;
using Csci463System.Services;

namespace Csci463SystemTests
{
    [TestClass]
    public class ZoneTest
    {
        [TestMethod]
        public void TestCreator()
        {

            Zone zone = new Zone(0, "room1");
            Assert.AreNotEqual(zone, null);
            Assert.AreNotEqual(zone.zones, null);
            Assert.AreEqual(zone.zoneType, Zone.ZoneType.Building);
        }
        [TestMethod]
        public void GetSensorTest()
        {
            Zone zone = new Zone(0,"room1");
            List<ISensor> sensors = zone.GetSensors();
            Assert.AreNotEqual(sensors, null);
            Assert.AreEqual(sensors, zone.sensors);
        }
        [TestMethod]
        public void GetZonesTest()
        {
            Zone zone = new Zone(0,"room1");
            List<Zone> zones = zone.GetZones();
            Assert.AreNotEqual(zones, null);
            Assert.AreEqual(zones, zone.zones);
        }
        [TestMethod]
        public void GetKeypadsTest()
        {
            Zone zone = new Zone(0, "room1");
            List<Keypad> keypads = zone.GetKeypads();
            Assert.AreNotEqual(keypads, null);
            Assert.AreEqual(keypads, zone.keypads);
        }
        [TestMethod]
        public void AddSensorTest()
        {
            Zone zone = new Zone(0, "room1");
            zone.AddSensor(0);
            Assert.IsNotNull(zone.sensors[0]);
            List<ISensor> sensors = zone.GetSensors();
            Assert.AreEqual(sensors[0], zone.sensors[0]);
        }
        [TestMethod]
        public void AddInnerZoneTest()
        {
            Zone zone = new Zone(0, "room1");
            zone.AddInnerZone(1);
            List<Zone> zones = zone.zones;
            Assert.AreEqual(zones[0], zone.zones[0]);
            Assert.IsNotNull(zone.zones[0]);
            Assert.AreEqual(zone.zones[0].zoneType, Zone.ZoneType.BuildingZone);
        }
        [TestMethod]
        public void AddKeypadTest()
        {
            Zone zone = new Zone(0, "room1");
            zone.AddKeypad();
            Keypad keypad = zone.keypads[0];
            Assert.IsNotNull(zone.keypads[0]);
            Assert.AreEqual(zone.keypads[0], keypad);
        }
        [TestMethod]
        public void LockDownTest()
        {
            Zone zone = new Zone(0, "room1");
            zone.LockDown();
            Assert.AreEqual(zone.LockedDown, true);
        }
        [TestMethod]
        public void UnlockTest()
        {
            Zone zone = new Zone(0, "room1");
            zone.LockDown();
            zone.Unlock();
            Assert.AreEqual(zone.LockedDown, false);
        }
        [TestMethod]
        public void LockDownElevatorTest()
        {
            Zone zone = new Zone(5, "room1");
            zone.LockDown();
            Assert.AreEqual(zone.LockedDown, false);
            Assert.AreEqual(zone.ElevatorActive, false);
        }
        [TestMethod]
        public void UnlockElevatorTest()
        {
            Zone zone = new Zone(5, "room1");
            zone.LockDown();
            zone.Unlock();
            Assert.AreEqual(zone.LockedDown, false);
            Assert.AreEqual(zone.ElevatorActive, true);
        }
    }
}
