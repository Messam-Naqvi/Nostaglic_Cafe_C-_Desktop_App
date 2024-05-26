using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btncontinue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard ds = new dashboard("Sign Up");
            ds.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Mahnoor" && txtpassword.Text == "1234")
            {
                dashboard ds = new dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            else if (txtusername.Text == "Muneeb" && txtpassword.Text == "1234")
            {
                dashboard ds = new dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            else if (txtusername.Text == "Messam" && txtpassword.Text == "1234")
            {
                dashboard ds = new dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
