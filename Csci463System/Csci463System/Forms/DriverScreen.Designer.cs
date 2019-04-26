namespace Csci463System.Forms
{
    partial class DriverScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.environmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environment1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environment2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environment3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.environmentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // environmentsToolStripMenuItem
            // 
            this.environmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.environment1ToolStripMenuItem,
            this.environment2ToolStripMenuItem,
            this.environment3ToolStripMenuItem});
            this.environmentsToolStripMenuItem.Name = "environmentsToolStripMenuItem";
            this.environmentsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.environmentsToolStripMenuItem.Text = "Environments";
            // 
            // environment1ToolStripMenuItem
            // 
            this.environment1ToolStripMenuItem.Name = "environment1ToolStripMenuItem";
            this.environment1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.environment1ToolStripMenuItem.Text = "Environment1";
            this.environment1ToolStripMenuItem.Click += new System.EventHandler(this.environment1ToolStripMenuItem_Click);
            // 
            // environment2ToolStripMenuItem
            // 
            this.environment2ToolStripMenuItem.Name = "environment2ToolStripMenuItem";
            this.environment2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.environment2ToolStripMenuItem.Text = "Environment2";
            this.environment2ToolStripMenuItem.Click += new System.EventHandler(this.environment2ToolStripMenuItem_Click);
            // 
            // environment3ToolStripMenuItem
            // 
            this.environment3ToolStripMenuItem.Name = "environment3ToolStripMenuItem";
            this.environment3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.environment3ToolStripMenuItem.Text = "Environment3";
            this.environment3ToolStripMenuItem.Click += new System.EventHandler(this.environment3ToolStripMenuItem_Click);
            // 
            // btnTest1
            // 
            this.btnTest1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTest1.Location = new System.Drawing.Point(50, 85);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(86, 35);
            this.btnTest1.TabIndex = 1;
            this.btnTest1.Text = "Test 1";
            this.btnTest1.UseVisualStyleBackColor = false;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTest2.Location = new System.Drawing.Point(50, 166);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(86, 35);
            this.btnTest2.TabIndex = 2;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = false;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTest3.Location = new System.Drawing.Point(50, 247);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(86, 35);
            this.btnTest3.TabIndex = 3;
            this.btnTest3.Text = "Test 3";
            this.btnTest3.UseVisualStyleBackColor = false;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // DriverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(186, 366);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DriverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver Form";
            this.Load += new System.EventHandler(this.DriverScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem environmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environment1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environment2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environment3ToolStripMenuItem;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
    }
}