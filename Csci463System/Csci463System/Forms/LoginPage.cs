using Csci463System.Models;
using Csci463System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csci463System.Forms
{
    public partial class LoginPage : Form
    {
        public Environment env;
        public string inEnv;
        public LoginPage(string Env)
        {
            inEnv = Env;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
             * Code for checking login information of the users in the environment loaded
             * by the form load event.
             * This can be added back in if you use:
             * Username = user
             * Passwrod = 123
             * */
            /*foreach(User u in env.users)
            {
                if(u.Username == txtUsername.Text)
                {
                    if (u.Password == txtPassword.Text)
                    {
                        MainPage form = new MainPage();
                        form.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Incorrect Login Information");
            return;
            */
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            /*
             * This code is where you would load an environment if you wanted more users involved that what
             * is in the current json file
            */
            /*
            User newUser = new User("user", "123");
            Environment environment = new Environment("Building1");
            environment.users.Add(newUser);
            environment.SaveEnvironment(inEnv);
            */
            /*
             * This code loads any environment Specified in the LoadEnvironment("ENV")
             * function
             * */
            JsonService js = new JsonService();
            env = new Environment();
            env.LoadEnvironment(inEnv);
        }
    }
}
