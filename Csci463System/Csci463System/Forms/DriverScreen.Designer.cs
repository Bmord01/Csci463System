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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.environmentsToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.environmentsToolStripMenuItem.Text = "Environments";
            // 
            // environment1ToolStripMenuItem
            // 
            this.environment1ToolStripMenuItem.Name = "environment1ToolStripMenuItem";
            this.environment1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.environment1ToolStripMenuItem.Text = "Environment1";
            this.environment1ToolStripMenuItem.Click += new System.EventHandler(this.environment1ToolStripMenuItem_Click);
            // 
            // environment2ToolStripMenuItem
            // 
            this.environment2ToolStripMenuItem.Name = "environment2ToolStripMenuItem";
            this.environment2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.environment2ToolStripMenuItem.Text = "Environment2";
            this.environment2ToolStripMenuItem.Click += new System.EventHandler(this.environment2ToolStripMenuItem_Click);
            // 
            // environment3ToolStripMenuItem
            // 
            this.environment3ToolStripMenuItem.Name = "environment3ToolStripMenuItem";
            this.environment3ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.environment3ToolStripMenuItem.Text = "Environment3";
            this.environment3ToolStripMenuItem.Click += new System.EventHandler(this.environment3ToolStripMenuItem_Click);
            // 
            // DriverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DriverScreen";
            this.Text = "Form1";
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
    }
}