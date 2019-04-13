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
        public Alarm alarm;

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
            Alarm a = new Alarm {
                Message = "Fire Sensor Activated",
                Severity = (Alarm.AlarmType.Security),
            };
            return a;
        }
        public void SupressSensor()
        {
            Activated = false;
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
    }
}
