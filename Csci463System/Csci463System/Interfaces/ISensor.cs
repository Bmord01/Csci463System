using Csci463System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Interfaces
{
    public interface ISensor
    {
        bool checkStatus();
        void checkConnection();
        Alarm triggerSensor();
        int getSensorUID();
        void SupressSensor();
    }
}
