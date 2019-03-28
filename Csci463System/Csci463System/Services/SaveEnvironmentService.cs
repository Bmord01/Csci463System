using Csci463System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Services
{
    public class SaveEnvironmentService
    {
        public SaveEnvironmentService()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] splitUser = username.Split('\\');

            System.IO.Directory.CreateDirectory(@"C:\Users\"+splitUser[1]+@"\JSON");
        }
        public void SaveEnvironmentToFile(object obj, string File)
        {
            JsonService JS = new JsonService();
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] splitUser = username.Split('\\');
            string jString = JS.Serialize(obj);
            System.IO.File.WriteAllText(@"C:\Users\" + splitUser[1] + @"\JSON\" + File,jString);
        }
        public void SaveEnvironmentToFile<T>(List<T> list, string File)
        {
            JsonService JS = new JsonService();
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] splitUser = username.Split('\\');
            string jString = JS.Serialize(list);
            System.IO.File.WriteAllText(@"C:\Users\" + splitUser[1] + @"\JSON\" + File, jString);
        }
    }
}
