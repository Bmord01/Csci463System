using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Services
{
    public class LoadEnvironmentService
    {
        public string LoadEnvironmentOjbect(string File)
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] splitUser = username.Split('\\');

            return System.IO.File.ReadAllText(@"C:\Users\" + splitUser[1] + @"\JSON\" + File);
        }
    }
}
