
namespace Eauth_CS_Winform_Example
{
    partial class eauthLOGIN
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
            this.signupBTN = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.signinBTN = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signupBTN
            // 
            this.signupBTN.Animated = true;
            this.signupBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.signupBTN.BorderRadius = 10;
            this.signupBTN.BorderThickness = 2;
            this.signupBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.signupBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.signupBTN.ForeColor = System.Drawing.Color.White;
            this.signupBTN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.signupBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.signupBTN.Location = new System.Drawing.Point(12, 310);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.PressedColor = System.Drawing.Color.DodgerBlue;
            this.signupBTN.Size = new System.Drawing.Size(300, 53);
            this.signupBTN.TabIndex = 12;
            this.signupBTN.Text = "Create Account";
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // passwordTXT
            // 
            this.passwordTXT.Animated = true;
            this.passwordTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.passwordTXT.BorderRadius = 6;
            this.passwordTXT.BorderThickness = 2;
            this.passwordTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTXT.DefaultText = "";
            this.passwordTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.passwordTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.passwordTXT.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold);
            this.passwordTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.passwordTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTXT.Location = new System.Drawing.Point(12, 178);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '●';
            this.passwordTXT.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTXT.PlaceholderText = "Password";
            this.passwordTXT.SelectedText = "";
            this.passwordTXT.Size = new System.Drawing.Size(300, 40);
            this.passwordTXT.TabIndex = 10;
            this.passwordTXT.UseSystemPasswordChar = true;
            // 
            // usernameTXT
            // 
            this.usernameTXT.Animated = true;
            this.usernameTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(30)))));
            this.usernameTXT.BorderRadius = 6;
            this.usernameTXT.BorderThickness = 2;
            this.usernameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTXT.DefaultText = "";
            this.usernameTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.usernameTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.usernameTXT.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold);
            this.usernameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTXT.Location = new System.Drawing.Point(12, 123);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.PasswordChar = '\0';
            this.usernameTXT.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usernameTXT.PlaceholderText = "Username";
            this.usernameTXT.SelectedText = "";
            this.usernameTXT.Size = new System.Drawing.Size(300, 40);
            this.usernameTXT.TabIndex = 9;
            // 
            // signinBTN
            // 
            this.signinBTN.Animated = true;
            this.signinBTN.BorderRadius = 10;
            this.signinBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signinBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signinBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.signinBTN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.signinBTN.ForeColor = System.Drawing.Color.White;
            this.signinBTN.Location = new System.Drawing.Point(12, 238);
            this.signinBTN.Name = "signinBTN";
            this.signinBTN.PressedColor = System.Drawing.Color.DodgerBlue;
            this.signinBTN.Size = new System.Drawing.Size(300, 53);
            this.signinBTN.TabIndex = 8;
            this.signinBTN.Text = "LOG IN";
            this.signinBTN.Click += new System.EventHandler(this.signinBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eauth_CS_Winform_Example.Properties.Resources.Eauth;
            this.pictureBox1.Location = new System.Drawing.Point(109, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // eauthLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(324, 422);
            this.Controls.Add(this.signupBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.signinBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "eauthLOGIN";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eauthLOGIN_FormClosed);
            this.Load += new System.EventHandler(this.eauthLOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button signupBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTXT;
        private Guna.UI2.WinForms.Guna2TextBox usernameTXT;
        private Guna.UI2.WinForms.Guna2Button signinBTN;
    }
}

