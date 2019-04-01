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
            LoginPage form = new LoginPage("Environment3" );
            form.Show();
            this.Hide();
        }

        private void DriverScreen_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void createEnvironment()
        {
            Environment env = new Environment("Default Building");
            env.building.AddKeypad();
            env.building.AddKeypad();
            env.building.AddSensor(2);
            env.building.AddSensor(2);

            //make 2 users: one supervisor, one not

            //building zone 1
            //list[0]
            env.building.AddInnerZone(1);

            //building zone 2
            //list[1]
            env.building.AddInnerZone(1);

            //building zone 3
            //list[2]
            env.building.AddInnerZone(1);
            
            List<Zone> zones = env.building.GetZones();

            //zone 1
            zones.ElementAt(0).AddInnerZone(2);
            zones.ElementAt(0).AddInnerZone(2);
            zones.ElementAt(0).AddInnerZone(2); //room with locked door
            zones.ElementAt(0).AddInnerZone(2); //main room
            List<Zone> zone1Zones = zones.ElementAt(0).GetZones();  //zones of zone 1
            //keypad and door for locked room
            zone1Zones.ElementAt(2).AddKeypad();
            zone1Zones.ElementAt(2).AddSensor(2);
            //all the fire and light sensors
            zone1Zones.ElementAt(0).AddSensor(0);
            zone1Zones.ElementAt(0).AddSensor(1);
            zone1Zones.ElementAt(1).AddSensor(0);
            zone1Zones.ElementAt(1).AddSensor(1);
            zone1Zones.ElementAt(2).AddSensor(0);
            zone1Zones.ElementAt(2).AddSensor(1);
            zone1Zones.ElementAt(3).AddSensor(0);
            zone1Zones.ElementAt(3).AddSensor(1);

            //zone 2
            //the 6 doors into zone 2
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddKeypad();
            zones.ElementAt(1).AddSensor(2);
            zones.ElementAt(1).AddSensor(2);
            zones.ElementAt(1).AddSensor(2);
            zones.ElementAt(1).AddSensor(2);
            zones.ElementAt(1).AddSensor(2);
            zones.ElementAt(1).AddSensor(2);

            zones.ElementAt(1).AddInnerZone(3); //south hallway
            zones.ElementAt(1).AddInnerZone(3); //north hallway
            zones.ElementAt(1).AddInnerZone(2); //main room
            List<Zone> zone2Zones = zones.ElementAt(1).GetZones();  //zones of zone 2
            //hallways and main rooms light and fire sensors
            zone2Zones.ElementAt(0).AddSensor(0);
            zone2Zones.ElementAt(0).AddSensor(1);
            zone2Zones.ElementAt(1).AddSensor(0);
            zone2Zones.ElementAt(1).AddSensor(1);
            zone2Zones.ElementAt(2).AddSensor(0);
            zone2Zones.ElementAt(2).AddSensor(1);
            zone2Zones.ElementAt(1).AddInnerZone(2);    //little closet on north hallway
            //little meeting rooms
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones.ElementAt(2).AddInnerZone(2);
            List<Zone> zone2MeetingRooms = zone2Zones.ElementAt(2).GetZones();  //little meeting rooms of zone 2
            List<Zone> zone2Closet = zone2Zones.ElementAt(1).GetZones();  //closet of zone 2
            //little closet's keypad and sensors
            zone2Closet.ElementAt(0).AddKeypad();
            zone2Closet.ElementAt(0).AddSensor(2);
            zone2Closet.ElementAt(0).AddSensor(0);
            zone2Closet.ElementAt(0).AddSensor(1);
            //meeting room's keypads and sensors
            zone2MeetingRooms.ElementAt(0).AddKeypad();
            zone2MeetingRooms.ElementAt(1).AddKeypad();
            zone2MeetingRooms.ElementAt(2).AddKeypad();
            zone2MeetingRooms.ElementAt(3).AddKeypad();
            zone2MeetingRooms.ElementAt(0).AddSensor(2);
            zone2MeetingRooms.ElementAt(0).AddSensor(2);
            zone2MeetingRooms.ElementAt(0).AddSensor(2);
            zone2MeetingRooms.ElementAt(0).AddSensor(2);
            zone2MeetingRooms.ElementAt(0).AddSensor(0);
            zone2MeetingRooms.ElementAt(0).AddSensor(0);
            zone2MeetingRooms.ElementAt(0).AddSensor(0);
            zone2MeetingRooms.ElementAt(0).AddSensor(0);
            zone2MeetingRooms.ElementAt(0).AddSensor(1);
            zone2MeetingRooms.ElementAt(0).AddSensor(1);
            zone2MeetingRooms.ElementAt(0).AddSensor(1);
            zone2MeetingRooms.ElementAt(0).AddSensor(1);

            //zone 3
            zones.ElementAt(2).AddInnerZone(4); //stairs
            zones.ElementAt(2).AddInnerZone(5); //elevator
            zones.ElementAt(2).AddInnerZone(3); //main room
            List<Zone> zone3Zones = zones.ElementAt(2).GetZones();
            //keyads and door sensors for elevator/stairs
            zone3Zones.ElementAt(0).AddKeypad();
            zone3Zones.ElementAt(0).AddKeypad();
            zone3Zones.ElementAt(0).AddSensor(2);
            zone3Zones.ElementAt(0).AddSensor(2);
            zone3Zones.ElementAt(1).AddKeypad();
            zone3Zones.ElementAt(1).AddKeypad();
            zone3Zones.ElementAt(1).AddSensor(2);
            zone3Zones.ElementAt(1).AddSensor(2);
            //fire and light sensors
            zone3Zones.ElementAt(0).AddSensor(0);
            zone3Zones.ElementAt(0).AddSensor(1);
            zone3Zones.ElementAt(1).AddSensor(0);
            zone3Zones.ElementAt(1).AddSensor(1);
            zone3Zones.ElementAt(2).AddSensor(0);
            zone3Zones.ElementAt(2).AddSensor(1);
        }
    }
}
