using Csci463System.Models;
using Csci463System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System
{
    public class EnvironmentC
    {
        public Zone building;
        public List<User> users;
        public EnvironmentC(string BuildingName)
        {
            building = new Zone(0, BuildingName);
            users = new List<User>();
        }
        public EnvironmentC()
        {
            building = new Zone();
            users = new List<User>();
        }
    }
}
