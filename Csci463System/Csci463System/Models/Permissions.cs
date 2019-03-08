using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class Permissions
    {
        public bool canAddSupervisor;
        public bool canAddObserver;
        public bool canUnlockZone;
        public bool canLockdownZone;

        public Permissions()
        {
            canAddSupervisor = false;
            canAddObserver = false;
            canUnlockZone = true;
            canLockdownZone = true;
        }

        public void isSupervisor()
        {
            canAddObserver = true;
            canAddSupervisor = true;
        }

        public void isObserver()
        {
            canAddObserver = false;
            canAddSupervisor = false;
        }
    }
}
