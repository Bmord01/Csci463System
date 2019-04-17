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
    public partial class DriverScreen : Form
    {
        public DriverScreen()
        {
            InitializeComponent();
        }

        private void environment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment1");
            form.Show();
            this.Hide();
        }

        private void environment2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment2");
            form.Show();
            this.Hide();
        }

        private void environment3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment3");
            form.Show();
            this.Hide();
        }

        private void DriverScreen_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment1");
            form.Show();
            this.Hide();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment2");
            form.Show();
            this.Hide();
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Environment3");
            form.Show();
            this.Hide();
        }
    }
}
