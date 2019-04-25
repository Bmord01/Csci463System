using Csci463System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class FireSensor : ISensor
    {
        public bool Activated;
        private static int uid = 1;
        public int UID;
        public Alarm alarm;

        public FireSensor()
        {
            UID = uid++;
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

        public Alarm triggerSensor()
        {
            Alarm a = new Alarm
            {
                Message = "Fire Alarm Activated",
                Severity = (Alarm.AlarmType)1
            };
            return a;
        }

        public int getSensorUID()
        {
            return UID;
        }

        public void Activate()
        {
            alarm = triggerSensor();
            Activated = true;
        }

        public void Deactivate()
        {
            alarm = null;
            Activated = false;
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
            return "Fire Sensor ";
        }
        public void SetActive()
        {
            Activated = false;
        }
    }
}
