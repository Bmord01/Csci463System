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
            env.building.AddInnerZone(6);
            //List<Zone> floors = env.building.GetZones();
            env.building.AddKeypad();
            env.building.AddKeypad();
            env.building.AddSensor(2);
            env.building.AddSensor(2);

            //adding elevator and stairs
            env.building.AddInnerZone(4);
            env.building.AddInnerZone(5);

            List<Zone> floors = env.building.GetZones();
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
            floors.ElementAt(0).AddInnerZone(1);

            //ground floor zone 2
            //list[1]
            floors.ElementAt(0).AddInnerZone(1);

            //ground floor zone 3
            //list[2]
            floors.ElementAt(0).AddInnerZone(1);

            //2nd floor zone 1
            //list[0]
            floors.ElementAt(1).AddInnerZone(1);

            //2nd floor zone 2
            //list[1]
            floors.ElementAt(1).AddInnerZone(1);

            //2nd floor zone 3
            //list[2]
            floors.ElementAt(1).AddInnerZone(1);

            //Begin first floor
            //*************************************************
            List<Zone> zones = floors.ElementAt(0).GetZones();

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
            List<Zone> zonesF2 = floors.ElementAt(1).GetZones();

            //zone 1
            zonesF2.ElementAt(0).AddInnerZone(2);
            zonesF2.ElementAt(0).AddInnerZone(2);
            zonesF2.ElementAt(0).AddInnerZone(2); //room with locked door
            zonesF2.ElementAt(0).AddInnerZone(2); //main room
            List<Zone> zone1ZonesF2 = zonesF2.ElementAt(0).GetZones();  //zones of zone 1
            //keypad and door for locked room
            zone1ZonesF2.ElementAt(2).AddKeypad();
            zone1ZonesF2.ElementAt(2).AddSensor(2);
            //all the fire and light sensors
            zone1ZonesF2.ElementAt(0).AddSensor(0);
            zone1ZonesF2.ElementAt(0).AddSensor(1);
            zone1ZonesF2.ElementAt(1).AddSensor(0);
            zone1ZonesF2.ElementAt(1).AddSensor(1);
            zone1ZonesF2.ElementAt(2).AddSensor(0);
            zone1ZonesF2.ElementAt(2).AddSensor(1);
            zone1ZonesF2.ElementAt(3).AddSensor(0);
            zone1ZonesF2.ElementAt(3).AddSensor(1);

            //zone 2
            //the 6 doors into zone 2
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddKeypad();
            zonesF2.ElementAt(1).AddSensor(2);
            zonesF2.ElementAt(1).AddSensor(2);
            zonesF2.ElementAt(1).AddSensor(2);
            zonesF2.ElementAt(1).AddSensor(2);
            zonesF2.ElementAt(1).AddSensor(2);
            zonesF2.ElementAt(1).AddSensor(2);

            zonesF2.ElementAt(1).AddInnerZone(3); //south hallway
            zonesF2.ElementAt(1).AddInnerZone(3); //north hallway
            zonesF2.ElementAt(1).AddInnerZone(2); //main room
            List<Zone> zone2ZonesF2 = zones.ElementAt(1).GetZones();  //zones of zone 2
            //hallways and main rooms light and fire sensors
            zone2ZonesF2.ElementAt(0).AddSensor(0);
            zone2ZonesF2.ElementAt(0).AddSensor(1);
            zone2ZonesF2.ElementAt(1).AddSensor(0);
            zone2ZonesF2.ElementAt(1).AddSensor(1);
            zone2ZonesF2.ElementAt(2).AddSensor(0);
            zone2ZonesF2.ElementAt(2).AddSensor(1);
            zone2ZonesF2.ElementAt(1).AddInnerZone(2);    //little closet on north hallway
            //little meeting rooms
            zone2ZonesF2.ElementAt(2).AddInnerZone(2);
            zone2ZonesF2.ElementAt(2).AddInnerZone(2);
            zone2ZonesF2.ElementAt(2).AddInnerZone(2);
            zone2ZonesF2.ElementAt(2).AddInnerZone(2);
            List<Zone> zone2MeetingRoomsF2 = zone2Zones.ElementAt(2).GetZones();  //little meeting rooms of zone 2
            List<Zone> zone2ClosetF2 = zone2Zones.ElementAt(1).GetZones();  //closet of zone 2
            //little closet's keypad and sensors
            zone2ClosetF2.ElementAt(0).AddKeypad();
            zone2ClosetF2.ElementAt(0).AddSensor(2);
            zone2ClosetF2.ElementAt(0).AddSensor(0);
            zone2ClosetF2.ElementAt(0).AddSensor(1);
            //meeting room's keypads and sensors
            zone2MeetingRoomsF2.ElementAt(0).AddKeypad();
            zone2MeetingRoomsF2.ElementAt(1).AddKeypad();
            zone2MeetingRoomsF2.ElementAt(2).AddKeypad();
            zone2MeetingRoomsF2.ElementAt(3).AddKeypad();
            zone2MeetingRoomsF2.ElementAt(0).AddSensor(2);
            zone2MeetingRoomsF2.ElementAt(1).AddSensor(2);
            zone2MeetingRoomsF2.ElementAt(2).AddSensor(2);
            zone2MeetingRoomsF2.ElementAt(3).AddSensor(2);
            zone2MeetingRoomsF2.ElementAt(0).AddSensor(0);
            zone2MeetingRoomsF2.ElementAt(1).AddSensor(0);
            zone2MeetingRoomsF2.ElementAt(2).AddSensor(0);
            zone2MeetingRoomsF2.ElementAt(3).AddSensor(0);
            zone2MeetingRoomsF2.ElementAt(0).AddSensor(1);
            zone2MeetingRoomsF2.ElementAt(1).AddSensor(1);
            zone2MeetingRoomsF2.ElementAt(2).AddSensor(1);
            zone2MeetingRoomsF2.ElementAt(3).AddSensor(1);

            //zone 3
            zonesF2.ElementAt(2).AddInnerZone(3); //main room
            List<Zone> zone3ZonesF2 = zonesF2.ElementAt(2).GetZones();
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
