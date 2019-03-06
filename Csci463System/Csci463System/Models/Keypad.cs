using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class Keypad
    {
        public static int uid = 1;
        public int UID;
        private readonly string Passcode;
        public bool Locked = true;

        public Keypad()
        {
            UID = uid++;
            Passcode = "1234";
        }
        
        public Keypad(string Passcode)
        {
            UID = uid++;
            this.Passcode = Passcode;
        }

        public bool Unlock(string userCode)
        {
            return (Passcode == userCode);
        }
    }
}
