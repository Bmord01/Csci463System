namespace Csci463System
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorButton1 = new System.Windows.Forms.Button();
            this.floorButton2 = new System.Windows.Forms.Button();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.currentFloorLabel = new System.Windows.Forms.Label();
            this.legend1 = new System.Windows.Forms.Button();
            this.legend3 = new System.Windows.Forms.Button();
            this.legend2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visualDoorSensor38 = new System.Windows.Forms.PictureBox();
            this.visualLightSensor30 = new System.Windows.Forms.PictureBox();
            this.visualFireSensor29 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualDoorSensor38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualLightSensor30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualFireSensor29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // floorLabel
            // 
            this.floorLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.floorLabel.Location = new System.Drawing.Point(597, 582);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(225, 60);
            this.floorLabel.TabIndex = 1;
            this.floorLabel.Text = "Floor:";
            this.floorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorButton1
            // 
            this.floorButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.floorButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.floorButton1.Location = new System.Drawing.Point(851, 582);
            this.floorButton1.Name = "floorButton1";
            this.floorButton1.Size = new System.Drawing.Size(69, 60);
            this.floorButton1.TabIndex = 2;
            this.floorButton1.Text = "1";
            this.floorButton1.UseVisualStyleBackColor = false;
            this.floorButton1.Click += new System.EventHandler(this.floorButton1_Click);
            // 
            // floorButton2
            // 
            this.floorButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.floorButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.floorButton2.Location = new System.Drawing.Point(926, 582);
            this.floorButton2.Name = "floorButton2";
            this.floorButton2.Size = new System.Drawing.Size(69, 60);
            this.floorButton2.TabIndex = 3;
            this.floorButton2.Text = "2";
            this.floorButton2.UseVisualStyleBackColor = false;
            this.floorButton2.Click += new System.EventHandler(this.floorButton2_Click);
            // 
            // buildingLabel
            // 
            this.buildingLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buildingLabel.Location = new System.Drawing.Point(12, 9);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(315, 77);
            this.buildingLabel.TabIndex = 5;
            this.buildingLabel.Text = "Building";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.DimGray;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.White;
            this.treeView.LineColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(12, 102);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(315, 462);
            this.treeView.TabIndex = 6;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(1072, 591);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 42);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Log Out";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentFloorLabel
            // 
            this.currentFloorLabel.AutoSize = true;
            this.currentFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFloorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentFloorLabel.Location = new System.Drawing.Point(711, 9);
            this.currentFloorLabel.Name = "currentFloorLabel";
            this.currentFloorLabel.Size = new System.Drawing.Size(58, 20);
            this.currentFloorLabel.TabIndex = 9;
            this.currentFloorLabel.Text = "Floor 1";
            this.currentFloorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.Enabled = false;
            this.legend1.Location = new System.Drawing.Point(236, 600);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(36, 33);
            this.legend1.TabIndex = 12;
            this.legend1.UseVisualStyleBackColor = false;
            // 
            // legend3
            // 
            this.legend3.BackColor = System.Drawing.Color.Goldenrod;
            this.legend3.Enabled = false;
            this.legend3.Location = new System.Drawing.Point(343, 600);
            this.legend3.Name = "legend3";
            this.legend3.Size = new System.Drawing.Size(36, 33);
            this.legend3.TabIndex = 14;
            this.legend3.UseVisualStyleBackColor = false;
            // 
            // legend2
            // 
            this.legend2.BackColor = System.Drawing.Color.Red;
            this.legend2.Enabled = false;
            this.legend2.Location = new System.Drawing.Point(289, 600);
            this.legend2.Name = "legend2";
            this.legend2.Size = new System.Drawing.Size(36, 33);
            this.legend2.TabIndex = 15;
            this.legend2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(236, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clear";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(333, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Disabled";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(290, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alert";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visualDoorSensor38
            // 
            this.visualDoorSensor38.BackColor = System.Drawing.Color.Yellow;
            this.visualDoorSensor38.Image = global::Csci463System.Properties.Resources.door1;
            this.visualDoorSensor38.Location = new System.Drawing.Point(654, 384);
            this.visualDoorSensor38.Name = "visualDoorSensor38";
            this.visualDoorSensor38.Size = new System.Drawing.Size(42, 61);
            this.visualDoorSensor38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visualDoorSensor38.TabIndex = 25;
            this.visualDoorSensor38.TabStop = false;
            this.visualDoorSensor38.Visible = false;
            // 
            // visualLightSensor30
            // 
            this.visualLightSensor30.BackColor = System.Drawing.Color.Yellow;
            this.visualLightSensor30.Image = global::Csci463System.Properties.Resources.lightbulb;
            this.visualLightSensor30.Location = new System.Drawing.Point(1110, 89);
            this.visualLightSensor30.Name = "visualLightSensor30";
            this.visualLightSensor30.Size = new System.Drawing.Size(62, 107);
            this.visualLightSensor30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visualLightSensor30.TabIndex = 23;
            this.visualLightSensor30.TabStop = false;
            this.visualLightSensor30.Visible = false;
            // 
            // visualFireSensor29
            // 
            this.visualFireSensor29.BackColor = System.Drawing.Color.Yellow;
            this.visualFireSensor29.Image = global::Csci463System.Properties.Resources.fire;
            this.visualFireSensor29.Location = new System.Drawing.Point(1040, 89);
            this.visualFireSensor29.Name = "visualFireSensor29";
            this.visualFireSensor29.Size = new System.Drawing.Size(64, 107);
            this.visualFireSensor29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visualFireSensor29.TabIndex = 22;
            this.visualFireSensor29.TabStop = false;
            this.visualFireSensor29.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::Csci463System.Properties.Resources.Floor1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(333, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 564);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(268, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Legend:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visualDoorSensor38);
            this.Controls.Add(this.visualLightSensor30);
            this.Controls.Add(this.visualFireSensor29);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legend2);
            this.Controls.Add(this.legend3);
            this.Controls.Add(this.legend1);
            this.Controls.Add(this.currentFloorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.floorButton2);
            this.Controls.Add(this.floorButton1);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security System";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualDoorSensor38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualLightSensor30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualFireSensor29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.Button floorButton1;
        private System.Windows.Forms.Button floorButton2;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label currentFloorLabel;
        private System.Windows.Forms.Button legend1;
        private System.Windows.Forms.Button legend3;
        private System.Windows.Forms.Button legend2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox visualFireSensor29;
        private System.Windows.Forms.PictureBox visualLightSensor30;
        private System.Windows.Forms.PictureBox visualDoorSensor38;
        private System.Windows.Forms.Label label2;
    }
}

