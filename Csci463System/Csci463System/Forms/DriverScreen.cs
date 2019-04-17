using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csci463System.Models;
using Csci463System.Services;

namespace Csci463System.Forms
{
    public partial class DriverScreen : Form
    {
        public DriverScreen()
        {
            InitializeComponent();
            createEnvironment();
        }

        private void environment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new LoginPage("Env.txt");
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
            createEnvironment();            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }        
        private void createEnvironment()
        {
            User supervisor = new User("Supervisor", "1234");
            supervisor.MakeSupervisor();
            User generic = new User("Generic", "1234");


            EnvironmentC env = new EnvironmentC("Default Building");
            env.users.Add(supervisor);
            env.users.Add(generic);

            env.building.AddInnerZone(6);
            env.building.zones[0].ZoneName = "Floor 1";
            env.building.AddInnerZone(6);
            env.building.zones[1].ZoneName = "Floor 2";
            //List<Zone> floors = env.building.GetZones();
            env.building.AddKeypad();
            env.building.AddKeypad();
            env.building.AddSensor(2);
            env.building.AddSensor(2);

            //adding elevator and stairs
            env.building.AddInnerZone(4);
            env.building.zones[2].ZoneName = "Elevator";
            env.building.AddInnerZone(5);
            env.building.zones[3].ZoneName = "Stairs";

            List<Zone> floors = new List<Zone>(env.building.GetZones());
            //Elements 2 and 3 are not floors, but the elevator and the stairs

            //elevator and stairs keypads and door sensors
            floors.ElementAt(2).AddKeypad();
            floors.ElementAt(2).AddKeypad();
            floors.ElementAt(2).AddSensor(2);
            floors.ElementAt(2).AddSensor(2);
            floors.ElementAt(3).AddKeypad();
            floors.ElementAt(3).AddKeypad();
            floors.ElementAt(3).AddSensor(2);
            floors.ElementAt(3).AddSensor(2);
            //fire and light sensors
            floors.ElementAt(2).AddSensor(0);
            floors.ElementAt(2).AddSensor(1);
            floors.ElementAt(3).AddSensor(0);
            floors.ElementAt(3).AddSensor(1);

            //make 2 users: one supervisor, one not

            //ground floor zone 1
            //list[0]
            floors[0].AddInnerZone(1);
            floors[0].zones[0].ZoneName = "Zone 1";

            //ground floor zone 2
            //list[1]
            floors[0].AddInnerZone(1);
            floors[0].zones[1].ZoneName = "Zone 2";
            //ground floor zone 3
            //list[2]
            floors[0].AddInnerZone(1);
            floors[0].zones[2].ZoneName = "Zone 3";
            //2nd floor zone 1
            //list[0]
            floors[1].AddInnerZone(1);
            floors[1].zones[0].ZoneName = "Zone 1";
            //2nd floor zone 2
            //list[1]
            floors[1].AddInnerZone(1);
            floors[1].zones[1].ZoneName = "Zone 2";
            //2nd floor zone 3
            //list[2]
            floors[1].AddInnerZone(1);
            floors[1].zones[2].ZoneName = "Zone 3";
            //Begin first floor
            //*************************************************
            List<Zone> zones = floors.ElementAt(0).GetZones();

            //zone 1
            zones.ElementAt(0).AddInnerZone(2);
            zones[0].zones[0].ZoneName = "Room 1";
            zones.ElementAt(0).AddInnerZone(2);
            zones[0].zones[1].ZoneName = "Room 2";
            zones.ElementAt(0).AddInnerZone(2); //room with locked door
            zones[0].zones[2].ZoneName = "Room 3";
            zones.ElementAt(0).AddInnerZone(2); //main room
            zones[0].zones[3].ZoneName = "Room 4";
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
            zones[1].zones[0].ZoneName = "Hallway 1";
            zones.ElementAt(1).AddInnerZone(3); //north hallway
            zones[1].zones[1].ZoneName = "Hallway 2";
            zones.ElementAt(1).AddInnerZone(2); //main room
            zones[1].zones[2].ZoneName = "Main Room";
            List<Zone> zone2Zones = zones.ElementAt(1).GetZones();  //zones of zone 2
            //hallways and main rooms light and fire sensors
            zone2Zones.ElementAt(0).AddSensor(0);
            zone2Zones.ElementAt(0).AddSensor(1);
            zone2Zones.ElementAt(1).AddSensor(0);
            zone2Zones.ElementAt(1).AddSensor(1);
            zone2Zones.ElementAt(2).AddSensor(0);
            zone2Zones.ElementAt(2).AddSensor(1);
            zone2Zones.ElementAt(1).AddInnerZone(2);    //little closet on north hallway
            zone2Zones[1].zones[0].ZoneName = "Closet";
            //little meeting rooms
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones[2].zones[0].ZoneName = "Little Room 1";
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones[2].zones[1].ZoneName = "Little Room 2";
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones[2].zones[2].ZoneName = "Little Room 3";
            zone2Zones.ElementAt(2).AddInnerZone(2);
            zone2Zones[2].zones[3].ZoneName = "Little Room 4";
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
            zone2MeetingRooms.ElementAt(1).AddSensor(2);
            zone2MeetingRooms.ElementAt(2).AddSensor(2);
            zone2MeetingRooms.ElementAt(3).AddSensor(2);
            zone2MeetingRooms.ElementAt(0).AddSensor(0);
            zone2MeetingRooms.ElementAt(1).AddSensor(0);
            zone2MeetingRooms.ElementAt(2).AddSensor(0);
            zone2MeetingRooms.ElementAt(3).AddSensor(0);
            zone2MeetingRooms.ElementAt(0).AddSensor(1);
            zone2MeetingRooms.ElementAt(1).AddSensor(1);
            zone2MeetingRooms.ElementAt(2).AddSensor(1);
            zone2MeetingRooms.ElementAt(3).AddSensor(1);

            //zone 3
            List<Zone> zone3Zones = zones.ElementAt(2).GetZones();
            //zone3Zones.ElementAt(2).AddSensor(0);
            //zone3Zones.ElementAt(2).AddSensor(1);
            //End first floor
            //************************************************

            //Begin second floor
            //*******************************************
            List<Zone> zones2F = floors.ElementAt(1).GetZones();

            //zone 1
            zones2F.ElementAt(0).AddInnerZone(2);
            zones2F[0].zones[0].ZoneName = "Room 1";
            zones2F.ElementAt(0).AddInnerZone(2);
            zones2F[0].zones[1].ZoneName = "Room 2";
            zones2F.ElementAt(0).AddInnerZone(2); //room with locked door
            zones2F[0].zones[2].ZoneName = "Room 3";
            zones2F.ElementAt(0).AddInnerZone(2); //main room
            zones2F[0].zones[3].ZoneName = "Room 4";
            List<Zone> zone1Zones2F = zones2F.ElementAt(0).GetZones();  //zones of zone 1
            //keypad and door for locked room
            zone1Zones2F.ElementAt(2).AddKeypad();
            zone1Zones2F.ElementAt(2).AddSensor(2);
            //all the fire and light sensors
            zone1Zones2F.ElementAt(0).AddSensor(0);
            zone1Zones2F.ElementAt(0).AddSensor(1);
            zone1Zones2F.ElementAt(1).AddSensor(0);
            zone1Zones2F.ElementAt(1).AddSensor(1);
            zone1Zones2F.ElementAt(2).AddSensor(0);
            zone1Zones2F.ElementAt(2).AddSensor(1);
            zone1Zones2F.ElementAt(3).AddSensor(0);
            zone1Zones2F.ElementAt(3).AddSensor(1);

            //zone 2
            //the 6 doors into zone 2
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddKeypad();
            zones2F.ElementAt(1).AddSensor(2);
            zones2F.ElementAt(1).AddSensor(2);
            zones2F.ElementAt(1).AddSensor(2);
            zones2F.ElementAt(1).AddSensor(2);
            zones2F.ElementAt(1).AddSensor(2);
            zones2F.ElementAt(1).AddSensor(2);

            zones2F.ElementAt(1).AddInnerZone(3); //south hallway
            zones2F[1].zones[0].ZoneName = "Hallway 1";
            zones2F.ElementAt(1).AddInnerZone(3); //north hallway
            zones2F[1].zones[1].ZoneName = "Hallway 2";
            zones2F.ElementAt(1).AddInnerZone(2); //main room
            zones2F[1].zones[2].ZoneName = "Main Room";
            List<Zone> zone2Zones2F = zones2F.ElementAt(1).GetZones();  //zones of zone 2
            //hallways and main rooms light and fire sensors
            zone2Zones2F.ElementAt(0).AddSensor(0);
            zone2Zones2F.ElementAt(0).AddSensor(1);
            zone2Zones2F.ElementAt(1).AddSensor(0);
            zone2Zones2F.ElementAt(1).AddSensor(1);
            zone2Zones2F.ElementAt(2).AddSensor(0);
            zone2Zones2F.ElementAt(2).AddSensor(1);
            zone2Zones2F.ElementAt(1).AddInnerZone(2);    //little closet on north hallway
            zone2Zones2F[1].zones[0].ZoneName = "Closet";
            //little meeting rooms
            zone2Zones2F.ElementAt(2).AddInnerZone(2);
            zone2Zones2F[2].zones[0].ZoneName = "Little Room 1";
            zone2Zones2F.ElementAt(2).AddInnerZone(2);
            zone2Zones2F[2].zones[1].ZoneName = "Little Room 2";
            zone2Zones2F.ElementAt(2).AddInnerZone(2);
            zone2Zones2F[2].zones[2].ZoneName = "Little Room 3";
            zone2Zones2F.ElementAt(2).AddInnerZone(2);
            zone2Zones2F[2].zones[3].ZoneName = "Little Room 4";
            List<Zone> zone2MeetingRooms2F = zone2Zones.ElementAt(2).GetZones();  //little meeting rooms of zone 2
            List<Zone> zone2Closet2F = zone2Zones.ElementAt(1).GetZones();  //closet of zone 2
            //little closet's keypad and sensors
            zone2Closet2F.ElementAt(0).AddKeypad();
            zone2Closet2F.ElementAt(0).AddSensor(2);
            zone2Closet2F.ElementAt(0).AddSensor(0);
            zone2Closet2F.ElementAt(0).AddSensor(1);
            //meeting room's keypads and sensors
            zone2MeetingRooms2F.ElementAt(0).AddKeypad();
            zone2MeetingRooms2F.ElementAt(1).AddKeypad();
            zone2MeetingRooms2F.ElementAt(2).AddKeypad();
            zone2MeetingRooms2F.ElementAt(3).AddKeypad();
            zone2MeetingRooms2F.ElementAt(0).AddSensor(2);
            zone2MeetingRooms2F.ElementAt(1).AddSensor(2);
            zone2MeetingRooms2F.ElementAt(2).AddSensor(2);
            zone2MeetingRooms2F.ElementAt(3).AddSensor(2);
            zone2MeetingRooms2F.ElementAt(0).AddSensor(0);
            zone2MeetingRooms2F.ElementAt(1).AddSensor(0);
            zone2MeetingRooms2F.ElementAt(2).AddSensor(0);
            zone2MeetingRooms2F.ElementAt(3).AddSensor(0);
            zone2MeetingRooms2F.ElementAt(0).AddSensor(1);
            zone2MeetingRooms2F.ElementAt(1).AddSensor(1);
            zone2MeetingRooms2F.ElementAt(2).AddSensor(1);
            zone2MeetingRooms2F.ElementAt(3).AddSensor(1);

            //zone 3
            List<Zone> zone3Zones2F = zones2F.ElementAt(2).GetZones();
            //zone3ZonesF2.ElementAt(2).AddSensor(0);
            //zone3ZonesF2.ElementAt(2).AddSensor(1);
            //End second floor
            //************************************************

            SaveEnvironmentService ses = new SaveEnvironmentService();
            ses.SaveEnvironmentToFile(env, "env.txt");
        }
        private void btnTest1_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Env.txt");
            form.Show();
            this.Hide();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Env2.txt");
            form.Show();
            this.Hide();
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            LoginPage form = new LoginPage("Env3.txt");
            form.Show();
            this.Hide();
        }
    }
}
