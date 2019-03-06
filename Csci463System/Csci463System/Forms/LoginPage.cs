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
        public string loadedJson;
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
            

        }
    }
}
