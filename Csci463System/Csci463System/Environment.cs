using Csci463System.Models;
using Csci463System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System
{
    public class Environment
    {
        public Zone building;
        public List<User> users;
        public Environment(string BuildingName)
        {
            building = new Zone(0, BuildingName);
            users = new List<User>();
        }
        public Environment()
        {
            building = new Zone();
            users = new List<User>();
        }
        public void SaveEnvironment(string inEnv)
        {
            
            SaveEnvironmentService ses = new SaveEnvironmentService();
            ses.SaveEnvironmentToFile(this, (inEnv + ".txt"));
        }
        public void LoadEnvironment(string inEnv)
        {
            LoadEnvironmentService les = new LoadEnvironmentService();
            JsonService js = new JsonService();
            building = js.Deserialize<Environment>(les.LoadEnvironmentOjbect(inEnv + ".txt")).building;
            users = js.Deserialize<Environment>(les.LoadEnvironmentOjbect(inEnv + ".txt")).users;
        }
    }
}
