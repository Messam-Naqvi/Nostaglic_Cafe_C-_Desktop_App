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
    public partial class uc_additem : UserControl
    {
        function fn =new function();
        String query;
        public uc_additem()
        {
            InitializeComponent();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {

            query = "insert into items (name , category , price) values('" + txtitemname.Text + "' , '" + txtcategory.Text + "' , " + txtprice.Text + ")";
            fn.SetData(query);
            clearAll();
            //try
            //{

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = "data source = DESKTOP-LPU86NR\\SQLEXPRESS ; database = cafe ; Integrated Security = true ";
            //    //SqlConnection con = new SqlConnection();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    con.Open();
            //   // query= "insert into items (name , category , price) values(\" + txtitem.Text + \"','\" + txtcategory.Text + \\\"','\\\" + txtprice.Text + \\\")\";
            //    cmd.CommandText = "insert into items (name , category , price) values(\" + txtitem.Text + \"','\" + txtcategory.Text + \"','\" + txtprice.Text + \")";
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Procced Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    //  MessageBox.Show("hy");
            //}
            //catch (Exception ex) { MessageBox.Show("Data Procced Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //clearAll();

        }
        public void clearAll()
        {
            txtcategory.SelectedIndex = -1;
            txtitemname.Clear();
            txtprice.Clear();   
        }

        private void uc_additem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
