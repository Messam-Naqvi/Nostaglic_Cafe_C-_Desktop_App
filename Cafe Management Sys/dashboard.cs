using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        public dashboard(String user)
        {
            InitializeComponent();
            if (user == "Sign Up")
            {
                btnplaceorder.Show();
                btnadditem.Hide();
                btnremoveitem.Hide();
                btnupdateitem.Hide();
            }
            else if (user == "Admin")
            {
                btnadditem.Show();
                btnupdateitem.Show();
                btnremoveitem.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {

        }

        private void btnplaceorder_Click_1(object sender, EventArgs e)
        {
            uc_welcome1.SendToBack();
            uc_placeorder1.Visible = true;
            uc_placeorder1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uc_additem1.Visible = false;
            uc_placeorder1.Visible=false;
           uc_updateitemcs1.Visible = false;
            uc_removeitem1.Visible = false;
            
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            uc_additem1.Visible = true;
            uc_additem1.BringToFront();

        }

        private void btnupdateitem_Click(object sender, EventArgs e)
        {
            uc_updateitemcs1.Visible = true;
            uc_updateitemcs1.BringToFront();
        }

        private void btnremoveitem_Click(object sender, EventArgs e)
        {
            uc_removeitem1.Visible = true;
            uc_removeitem1.BringToFront();
        }

       
    }
}
