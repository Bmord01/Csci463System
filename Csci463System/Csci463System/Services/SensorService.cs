using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csci463System.Interfaces;
using Csci463System.Models;

namespace Csci463System.Services
{
    public class SensorService
    {
        public enum SensorType
        {
            SmokeSensor,
            LightSensor
        };
        public int sensorType;

        public ISensor CreateSensor(int inType)
        {
            ISensor sensor;

            switch ((SensorType) inType)
            {
                case SensorType.SmokeSensor:
                    sensor = new FireSensor();
                    break;
                case SensorType.LightSensor:
                    sensor = new LightSensor();
                    break;
                default:
                    sensor = null;
                    break;
            }
            return sensor;
        }
    }
}
