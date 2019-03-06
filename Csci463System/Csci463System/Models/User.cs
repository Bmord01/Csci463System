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
        private string Password;
        public Permissions userPermissions;

        public User()
        {
            userPermissions = new Permissions();
        }
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
    }
}
