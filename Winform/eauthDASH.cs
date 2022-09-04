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
    public partial class eauthDASH : Form
    {
        eauth auth = new eauth();
        public string Username { get; set; }
        public string Createdate { get; set; }
        public string Expiredate { get; set; }
        public string HardwareID { get; set; }
        public string Rank { get; set; }
        public string ApplicationName { get; set; }
        public eauthDASH()
        {
            InitializeComponent();
        }

        private void eauthDASH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void eauthDASH_Load(object sender, EventArgs e)
        {
            label1.Text = "Username: " + Username;
            label2.Text = "Create Date: " + Createdate;
            label3.Text = "Expire Date: " + Expiredate;
            label4.Text = "Hardware ID: " + HardwareID;
            label5.Text = "Rank: " + Rank;
            label6.Text = "Application Name: " + ApplicationName;
            //label6.Text = "Variable: " + auth.grabvariable("your variable id here");
        }
    }
}
