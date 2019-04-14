﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csci463System
{
    public partial class MainPage : Form
    {
        private TreeView treeView1;
        private Button showCheckedNodesButton;
        private TreeViewCancelEventHandler checkForCheckedChildren;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Initializing Tree to view all the building systems.
            treeView.Nodes.Add("Floor 1");
            treeView.Nodes.Add("Floor 2");

            // -------------------------------------

            treeView.Nodes[0].Nodes.Add("Room 1");
            treeView.Nodes[0].Nodes.Add("Room 2");
            treeView.Nodes[0].Nodes.Add("Room 3");
            treeView.Nodes[0].Nodes.Add("Room 4");

            treeView.Nodes[1].Nodes.Add("Room 1");
            treeView.Nodes[1].Nodes.Add("Room 2");
            treeView.Nodes[1].Nodes.Add("Room 3");
            treeView.Nodes[1].Nodes.Add("Room 4");

            // -------------------------------------

            treeView.Nodes[0].Nodes[0].Nodes.Add("Doors");
            treeView.Nodes[0].Nodes[0].Nodes.Add("Sensors");
            treeView.Nodes[0].Nodes[0].Nodes.Add("Cameras");

            treeView.Nodes[0].Nodes[1].Nodes.Add("Doors");
            treeView.Nodes[0].Nodes[1].Nodes.Add("Sensors");
            treeView.Nodes[0].Nodes[1].Nodes.Add("Cameras");

            treeView.Nodes[0].Nodes[2].Nodes.Add("Doors");
            treeView.Nodes[0].Nodes[2].Nodes.Add("Sensors");
            treeView.Nodes[0].Nodes[2].Nodes.Add("Cameras");


            // -------------------------------------

            treeView.Nodes[1].Nodes[0].Nodes.Add("Doors");
            treeView.Nodes[1].Nodes[0].Nodes.Add("Sensors");
            treeView.Nodes[1].Nodes[0].Nodes.Add("Cameras");

            treeView.Nodes[1].Nodes[1].Nodes.Add("Doors");
            treeView.Nodes[1].Nodes[1].Nodes.Add("Sensors");
            treeView.Nodes[1].Nodes[1].Nodes.Add("Cameras");

            treeView.Nodes[1].Nodes[2].Nodes.Add("Doors");
            treeView.Nodes[1].Nodes[2].Nodes.Add("Sensors");
            treeView.Nodes[1].Nodes[2].Nodes.Add("Cameras");

            treeView.Nodes[1].Nodes[3].Nodes.Add("Doors");
            treeView.Nodes[1].Nodes[3].Nodes.Add("Sensors");
            treeView.Nodes[1].Nodes[3].Nodes.Add("Cameras");


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
            Application.Exit();
        }
    }
}
