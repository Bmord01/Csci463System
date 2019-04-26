namespace Csci463System.Forms
{
    partial class LoginPage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.lnklblForgotPwd = new System.Windows.Forms.LinkLabel();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.testCasesButton = new System.Windows.Forms.Button();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(11, 130);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(306, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(8, 19);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 76);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(85, 18);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(85, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg.Location = new System.Drawing.Point(12, 42);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(575, 17);
            this.lblWelcomeMsg.TabIndex = 5;
            this.lblWelcomeMsg.Text = "Welcome to the Fire Alarm Monitoring System!  To monitor the system, you must log" +
    "in first.";
            this.lblWelcomeMsg.Click += new System.EventHandler(this.lblWelcomeMsg_Click);
            // 
            // lnklblForgotPwd
            // 
            this.lnklblForgotPwd.AutoSize = true;
            this.lnklblForgotPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblForgotPwd.Location = new System.Drawing.Point(122, 165);
            this.lnklblForgotPwd.Name = "lnklblForgotPwd";
            this.lnklblForgotPwd.Size = new System.Drawing.Size(92, 13);
            this.lnklblForgotPwd.TabIndex = 6;
            this.lnklblForgotPwd.TabStop = true;
            this.lnklblForgotPwd.Text = "Forgot Password?";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.lnklblForgotPwd);
            this.grpControls.Controls.Add(this.txtPassword);
            this.grpControls.Controls.Add(this.txtUsername);
            this.grpControls.Controls.Add(this.lblPassword);
            this.grpControls.Controls.Add(this.lblUsername);
            this.grpControls.Controls.Add(this.btnLogin);
            this.grpControls.Location = new System.Drawing.Point(126, 97);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(330, 199);
            this.grpControls.TabIndex = 7;
            this.grpControls.TabStop = false;
            // 
            // testCasesButton
            // 
            this.testCasesButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.testCasesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testCasesButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.testCasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testCasesButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCasesButton.Location = new System.Drawing.Point(11, 322);
            this.testCasesButton.Margin = new System.Windows.Forms.Padding(2);
            this.testCasesButton.Name = "testCasesButton";
            this.testCasesButton.Size = new System.Drawing.Size(91, 33);
            this.testCasesButton.TabIndex = 7;
            this.testCasesButton.Text = "Test Cases";
            this.testCasesButton.UseVisualStyleBackColor = false;
            this.testCasesButton.Click += new System.EventHandler(this.testCasesButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.testCasesButton);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblWelcomeMsg;
        private System.Windows.Forms.LinkLabel lnklblForgotPwd;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button testCasesButton;
    }
}