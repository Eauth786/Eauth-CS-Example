using System;
using System.Windows.Forms;

namespace Eauth_CS_Winform_Example
{
    public partial class eauthLOGIN : Form
    {
        eauth auth = new eauth();
        public eauthLOGIN()
        {
            InitializeComponent();
        }

        private void signinBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTXT.Text) && !string.IsNullOrEmpty(passwordTXT.Text))
            {
                auth.signin(usernameTXT.Text.ToString(), passwordTXT.Text.ToString());
                if (auth.login)
                {
                    eauthDASH dashForm = new eauthDASH();
                    dashForm.Username = auth.Username;
                    dashForm.Createdate = auth.Createdate;
                    dashForm.Expiredate = auth.Expiredate;
                    dashForm.HardwareID = auth.HardwareID;
                    dashForm.Rank = auth.Rank;
                    dashForm.ApplicationName = auth.ApplicationName;
                    dashForm.Show();
                    this.Hide();
                }
            }
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            eauthREGISTER signupForm = new eauthREGISTER();
            signupForm.Show();
            this.Hide();
        }

        private void eauthLOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void eauthLOGIN_Load(object sender, EventArgs e)
        {
            auth.init();
        }
    }
}
