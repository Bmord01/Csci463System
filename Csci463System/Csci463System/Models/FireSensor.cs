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
            Alarm alarm = new Alarm();
            alarm.Message = "Fire Sensor Activated";
            alarm.Severity = (Alarm.AlarmType)1;
            Activated = true;
            return alarm;
        }

        public int getSensorUID()
        {
            return UID;
        }

        public void SupressSensor()
        {
            Activated = false;
        }
    }
}
