using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Interfaces
{
    public interface IZone
    {
        void AddSensor(int type);
        void AddInnerZone();
        void AddKeypad();
        void LockDown();
        void Unlock();
        void Activate();
        void Deactivate();
    }
}
