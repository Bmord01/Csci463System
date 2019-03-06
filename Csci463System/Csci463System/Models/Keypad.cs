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
        private readonly string Passcode = "1234";
        public bool Locked = true;

        public Keypad()
        {
            UID = uid++;
        }

        public bool Unlock(string userCode)
        {
            return (Passcode == userCode);
        }
    }
}
