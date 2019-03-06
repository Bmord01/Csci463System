using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class Alarm
    {
        public string Message { set => Message = value; get => Message; }

        public enum AlarmType
        {
            Security,
            Fire,
            Evacuation
        };
        public enum AlarmSeverity
        {
            NoThreat,
            MinorThreat,
            MajorThreat
        };
    }
}
