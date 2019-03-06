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

        public void triggerSensor()
        {
            throw new NotImplementedException();
        }

        public int getSensorUID()
        {
            return UID;
        }
    }
}
