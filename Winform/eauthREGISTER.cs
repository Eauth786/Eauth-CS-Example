using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eauth_CS_Winform_Example
{
    public partial class eauthREGISTER : Form
    {
        eauth auth = new eauth();
        public eauthREGISTER()
        {
            InitializeComponent();
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTXT.Text) && !string.IsNullOrEmpty(passwordTXT.Text) && !string.IsNullOrEmpty(licenseTXT.Text))
            {
                auth.signup(usernameTXT.Text.ToString(), passwordTXT.Text.ToString(), licenseTXT.Text.ToString());
            }
        }

        private void signinBTN_Click(object sender, EventArgs e)
        {
            eauthLOGIN signinForm = new eauthLOGIN();
            signinForm.Show();
            this.Hide();
        }

        private void eauthREGISTER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void eauthREGISTER_Load(object sender, EventArgs e)
        {
            auth.init();
        }
    }
}
