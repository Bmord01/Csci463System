using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class Alarm
    {
        public string Message { set ; get ; }
        public AlarmType Severity;
        public enum AlarmType
        {
            None,
            Light,
            Security,
            Fire
        };
        public enum AlarmSeverity
        {
            NoThreat,
            MinorThreat,
            MajorThreat
        };
        public Alarm()
        {
            Message = "";
            Severity = 0;
        }
        public void UpgradeSeverity(int Problem)
        {
            Severity = (AlarmType)Problem;
        }
        public void DowngradeSeverity()
        {
            Severity = AlarmType.None;
        }
    }
}
