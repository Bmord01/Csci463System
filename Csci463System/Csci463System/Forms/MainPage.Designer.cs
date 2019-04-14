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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorButton1 = new System.Windows.Forms.Button();
            this.floorButton2 = new System.Windows.Forms.Button();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::Csci463System.Properties.Resources.Floor1;
            this.pictureBox1.Image = global::Csci463System.Properties.Resources.Floor1;
            this.pictureBox1.Location = new System.Drawing.Point(333, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 564);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // floorLabel
            // 
            this.floorLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.floorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.floorLabel.Location = new System.Drawing.Point(399, 583);
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
            this.floorButton1.Location = new System.Drawing.Point(653, 583);
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
            this.floorButton2.Location = new System.Drawing.Point(728, 583);
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
            this.treeView.ForeColor = System.Drawing.SystemColors.Info;
            this.treeView.LineColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(12, 102);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(315, 462);
            this.treeView.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(1059, 601);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.Button floorButton1;
        private System.Windows.Forms.Button floorButton2;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button exitButton;
    }
}

