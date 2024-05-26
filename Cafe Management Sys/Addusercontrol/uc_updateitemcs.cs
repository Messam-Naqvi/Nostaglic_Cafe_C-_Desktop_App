using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Addusercontrol
{
    public partial class uc_updateitemcs : UserControl
    {
        function fn = new function();
        String query;
        public uc_updateitemcs()
        {
            InitializeComponent();
        }
        private void uc_updateitemcs_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata(){

            query = "select * from items";
            DataSet ds = fn.getData(query);
        dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtsearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtcategory.Text = category;
            txtname.Text = name;
            txtprice.Text = price.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            query = "update items(name,category,price) set name = '" + txtname.Text + "', category = '" + txtcategory.Text + "', price = " + txtprice.Text + " where id =" + id + "";
            fn.SetData(query);
            loaddata();

            txtname.Clear();
            txtcategory.Clear();
            txtprice.Clear();
        }
    }
}
