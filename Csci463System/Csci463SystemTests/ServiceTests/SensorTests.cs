using Csci463System.Interfaces;
using Csci463System.Models;
using Csci463System.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csci463SystemTests
{
    [TestClass]
    public class SensorTests
    {
        [TestMethod]
        public void TestUIDDifferent()
        {
            SensorService ss = new SensorService();
            ISensor Sensor1 = ss.CreateSensor(0);
            ISensor Sensor2 = ss.CreateSensor(0);
            ISensor Sensor3 = ss.CreateSensor(1);
            ISensor Sensor4 = ss.CreateSensor(1);
            Assert.AreNotEqual(Sensor1.getSensorUID(), Sensor2.getSensorUID());
            Assert.AreNotEqual(Sensor3.getSensorUID(), Sensor4.getSensorUID());
            
        }
    }
}
