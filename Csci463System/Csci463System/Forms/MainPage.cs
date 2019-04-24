﻿using Csci463System.Forms;
using Csci463System.Interfaces;
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
using Microsoft.VisualBasic;

namespace Csci463System
{
    public partial class MainPage : Form
    {
        private TreeView treeView1;
        private Button showCheckedNodesButton;
        private TreeViewCancelEventHandler checkForCheckedChildren;
        public EnvironmentC env;
        public List<ISensor> issueS;
        public List<Alarm> issueA;
        public User CurrentUser;
        public string envS;
        public MainPage(EnvironmentC inEnv,User CurrentUser,string inEnvS)
        {
            env = inEnv;
            this.CurrentUser = CurrentUser;
            envS = inEnvS;
            InitializeComponent();
            if (this.CurrentUser.userPermissions.canAddObserver)
            {
                this.button1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddKeypadNodToTree(List<Keypad> inK,TreeNode inNode)
        {
            foreach(Keypad k in inK)
            {
                inNode.Nodes.Add("Keypad " + k.UID);
            }
        }
        private void AddSensorNodeToTree(List<ISensor> inIS,TreeNode inNode)
        {
            foreach(ISensor s in inIS)
            {
                TreeNode newNode = new TreeNode((s.GetSensorType() + s.getSensorUID().ToString()));
                if(s.GetActive())
                {
                    newNode.ForeColor = Color.Red;
                    //MessageBox.Show("Found issue with Sensor" +s.getSensorUID());
                }
                inNode.Nodes.Add(newNode);  
                if(newNode.ForeColor == Color.Red)
                {
                    newNode.Parent.ForeColor = Color.Red;
                }   
            }
        }

        private void AddZoneNodeToTree(List<Zone> inZ,TreeNode inNode)
        {
            int i = 0;
            foreach(Zone z in inZ)
            {
                inNode.Nodes.Add(z.ZoneName);
                AddZoneNodeToTree(z.zones, inNode.Nodes[i]);
                AddSensorNodeToTree(z.GetAllSensors(),inNode.Nodes[i]);
                AddKeypadNodToTree(z.keypads, inNode.Nodes[i]);
                foreach(TreeNode n in inNode.Nodes)
                {
                    if(n.ForeColor == Color.Red)
                    {
                        inNode.ForeColor = Color.Red;
                    }
                }
                i++;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            issueS = new List<ISensor>(env.building.CheckSensors().Item1);
            issueA = new List<Alarm>(env.building.CheckSensors().Item2);
            treeView.Nodes.Add(env.building.ZoneName);
            AddZoneNodeToTree(env.building.zones,treeView.Nodes[0]);
            // Initializing Tree to view all the building systems.
            //treeView.Nodes.Add("Floor 1");
            //treeView.Nodes.Add("Floor 2");

            //// -------------------------------------

            //treeView.Nodes[0].Nodes.Add("Room 1");
            //treeView.Nodes[0].Nodes.Add("Room 2");
            //treeView.Nodes[0].Nodes.Add("Room 3");
            //treeView.Nodes[0].Nodes.Add("Room 4");

            //treeView.Nodes[1].Nodes.Add("Room 1");
            //treeView.Nodes[1].Nodes.Add("Room 2");
            //treeView.Nodes[1].Nodes.Add("Room 3");
            //treeView.Nodes[1].Nodes.Add("Room 4");

            //// -------------------------------------

            //treeView.Nodes[0].Nodes[0].Nodes.Add("Doors");
            //treeView.Nodes[0].Nodes[0].Nodes.Add("Sensors");
            //treeView.Nodes[0].Nodes[0].Nodes.Add("Cameras");

            //treeView.Nodes[0].Nodes[1].Nodes.Add("Doors");
            //treeView.Nodes[0].Nodes[1].Nodes.Add("Sensors");
            //treeView.Nodes[0].Nodes[1].Nodes.Add("Cameras");

            //treeView.Nodes[0].Nodes[2].Nodes.Add("Doors");
            //treeView.Nodes[0].Nodes[2].Nodes.Add("Sensors");
            //treeView.Nodes[0].Nodes[2].Nodes.Add("Cameras");

            //treeView.Nodes[0].Nodes[3].Nodes.Add("Doors");
            //treeView.Nodes[0].Nodes[3].Nodes.Add("Sensors");
            //treeView.Nodes[0].Nodes[3].Nodes.Add("Cameras");


            //// -------------------------------------

            //treeView.Nodes[1].Nodes[0].Nodes.Add("Doors");
            //treeView.Nodes[1].Nodes[0].Nodes.Add("Sensors");
            //treeView.Nodes[1].Nodes[0].Nodes.Add("Cameras");

            //treeView.Nodes[1].Nodes[1].Nodes.Add("Doors");
            //treeView.Nodes[1].Nodes[1].Nodes.Add("Sensors");
            //treeView.Nodes[1].Nodes[1].Nodes.Add("Cameras");

            //treeView.Nodes[1].Nodes[2].Nodes.Add("Doors");
            //treeView.Nodes[1].Nodes[2].Nodes.Add("Sensors");
            //treeView.Nodes[1].Nodes[2].Nodes.Add("Cameras");

            //treeView.Nodes[1].Nodes[3].Nodes.Add("Doors");
            //treeView.Nodes[1].Nodes[3].Nodes.Add("Sensors");
            //treeView.Nodes[1].Nodes[3].Nodes.Add("Cameras");


        }

        // These functions change the colors of the floor buttons to show which one you are currently on.
        private void floorButton1_Click(object sender, EventArgs e)
        {
            floorButton1.BackColor = Color.MidnightBlue;
            floorButton2.BackColor = Color.DodgerBlue;
        }

        private void floorButton2_Click(object sender, EventArgs e)
        {
            floorButton1.BackColor = Color.DodgerBlue;
            floorButton2.BackColor = Color.MidnightBlue;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            SaveEnvironmentService ses = new SaveEnvironmentService();
            ses.SaveEnvironmentToFile(env, envS);
            LoginPage lg = new LoginPage(envS);
            lg.Show();
            this.Close();
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = treeView.SelectedNode;
            try
            {
                string[] name = tn.Text.Split(' ');
                string[] issue;
                for (int i = 0; i < issueS.Count; i++)
                {
                    issue = issueA[i].Message.Split(' ');
                    if (tn.ForeColor==Color.Red && issue[0]==name[0])
                    {
                        var result = MessageBox.Show(issueA[i].Message+", Alert Emergency Services?","Warning",MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            MessageBox.Show("Emergency services have been Alerted");
                            tn.ForeColor = Color.White;
                            checkParentColor(tn.Parent);
                        }
                        else
                        {
                            var result2=MessageBox.Show("Disable Sensor?", "Warning", MessageBoxButtons.YesNo);
                            if (result2 == DialogResult.Yes)
                            {
                                tn.ForeColor = Color.White;
                                checkParentColor(tn.Parent);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return;
        }
        private void checkParentColor(TreeNode inNode)
        {
            foreach(TreeNode n in inNode.Nodes)
            {
                if (n.ForeColor == Color.Red)
                {
                    return;
                }
                inNode.ForeColor = Color.White;
            }
            checkParentColor(inNode.Parent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentUser.userPermissions.canAddObserver)
            {
                var result = MessageBox.Show("Are You Sure you Want to Add an Observer?","Add Observer",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string Username = Interaction.InputBox("Add Observer", "Username: ", "");
                    string Password = Interaction.InputBox("Add Observer", "Password: ", "");
                    User newUser = new User(Username,Password);
                    env.users.Add(newUser);
                    SaveEnvironmentService ses = new SaveEnvironmentService();
                    ses.SaveEnvironmentToFile(env, envS);
                    return;
                }
                result = MessageBox.Show("Are You Sure you Want to Add an Supervisor?", "Add Supervisor", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string Username = Interaction.InputBox("Add Supervisor", "Username: ", "");
                    string Password = Interaction.InputBox("Add Supervisor", "Password: ", "");
                    User newUser = new User(Username, Password);
                    newUser.MakeSupervisor();
                    env.users.Add(newUser);
                    SaveEnvironmentService ses = new SaveEnvironmentService();
                    ses.SaveEnvironmentToFile(env, envS);
                    return;
                }
            }
        }
    }
}
