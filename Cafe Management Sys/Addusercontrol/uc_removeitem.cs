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
    public partial class uc_removeitem : UserControl
    {
        function fn = new function();
        String query;
        public uc_removeitem()
        {
            InitializeComponent();
        }

        private void uc_removeitem_Load(object sender, EventArgs e)
        {
            labeldelete.Text = "How to Delete ?";
            labeldelete.ForeColor = Color.Maroon;
            loaddata();
        }

        public void loaddata()
        {
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query ="delete from items where id = "+id+"";
                fn.SetData(query);
                loaddata();
            }
        }

        private void labeldelete_Click(object sender, EventArgs e)
        {
            labeldelete.ForeColor= Color.DarkBlue;
            labeldelete.Text = "*Click on Row to delete Item.";
        }

        private void uc_removeitem_Enter(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
