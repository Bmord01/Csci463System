using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csci463System.Interfaces;

namespace Csci463System.Models
{
    public class DoorSensor : ISensor
    {
        public bool Activated;
        private static int uid = 1;
        public int UID;

        public DoorSensor()
        {
            UID = uid++;
            Activated = false;
        }

        public void checkConnection()
        {
            throw new NotImplementedException();
        }

        public bool checkStatus()
        {
            return Activated;
        }

        public int getSensorUID()
        {
            return UID;
        }

        public Alarm triggerSensor()
        {
            Alarm alarm = new Alarm();
            alarm.Message = "Fire Sensor Activated";
            alarm.Severity = (Alarm.AlarmType.Security);
            Activated = true;
            return alarm;
        }
        public void SupressSensor()
        {
            Activated = false;
        }
    }
}
