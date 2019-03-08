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
        Environment env;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            /*
             * This code is where you would load an environment if you wanted more users involved that what
             * is in the current json file
            
            User newUser = new User("user", "123");
            EnvironmentBuilder environment = new EnvironmentBuilder("Building1");
            environment.users.Add(newUser);
            environment.SaveEnvironment();
            */
            /*
             * This code loads any environment Specified in the LoadEnvironment("ENV")
             * function
             * */
            JsonService js = new JsonService();
            env = new Environment();
            env.LoadEnvironment("Environment1");
        }
    }
}
