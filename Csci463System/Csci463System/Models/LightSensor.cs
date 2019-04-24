using Csci463System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class LightSensor : ISensor
    {
        public static int uid = 1;
        public int UID;
        public bool Activated;
        public Alarm alarm;
        public LightSensor()
        {
            Activated = false;
            UID = uid++;
        }

        public void Activate()
        {
            alarm = triggerSensor();
            Activated = true;
        }

        public void checkConnection()
        {
            /**
             * Code that would be implemented over ethernet connections
             * Outside of scope of this project
             * */
            throw new NotImplementedException();
        }

        public bool checkStatus()
        {
            return Activated;
        }

        public void Deactivate()
        {
            alarm = null;
            Activated = false;
        }

        public int getSensorUID()
        {
            return UID;
        }

        public Alarm triggerSensor()
        {
            Alarm a = new Alarm
            {
                Message = "Emergency Lights Activated",
                Severity = (Alarm.AlarmType.Light)
            };
            return a;
        }

        public bool GetActive()
        {
            return Activated;
        }
        public Alarm GetAlarm()
        {
            return alarm;
        }
        public string GetSensorType()
        {
            return "Light Sensor ";
        }
    }
}
