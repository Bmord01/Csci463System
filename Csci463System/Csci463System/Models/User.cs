using Csci463System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Models
{
    public class User
    {
        public string Username;
        public string Password;
        public Permissions userPermissions;
        /****************** Constructers ************************/
        public User()
        {
            userPermissions = new Permissions();
        }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
            userPermissions = new Permissions();
        }
        /********************************************************/
        /***************** Get / Set ****************************/
        public Permissions getPermissions()
        {
            return userPermissions;
        }
        public string getUsername()
        {
            return Username;
        }
        private void setUsername(string inUsername)
        {
            Username = inUsername;
        }
        private string getPassword()
        {
            return Password;
        }
        private void setPassword(string inPassword)
        {
            Password = inPassword;
        }
        /********************************************************/
        /********************  Funcitons ************************/
        public void MakeSupervisor()
        {
            userPermissions.isSupervisor();
        }
        public void MakeObserver()
        {
            userPermissions.isObserver();
        }

        public bool ValidateLogin(string inPassword)
        {
            return (inPassword == this.Password);
        }
    }
}
