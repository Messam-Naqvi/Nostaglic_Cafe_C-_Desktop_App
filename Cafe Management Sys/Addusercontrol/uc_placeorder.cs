using DGVPrinterHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1.Addusercontrol
{
    
    public partial class uc_placeorder : UserControl
    {
        function fn = new function();
        String query;
        string query1;
        public uc_placeorder()
        {
            InitializeComponent();
        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category=combocategory.Text;
            query = "Select name from items where category = '" + category + "'";
            showitemlist(query);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String category = combocategory.Text;
            query = "Select name from items where category = '" + category + "' and name like '"+txtsearch.Text+"%'";
            showitemlist(query);
        }

        private void showitemlist(String query)
        {
            listbox1.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listbox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantityupdown.ResetText();
            txttotal.Clear();

            String text = listbox1.GetItemText(listbox1.SelectedItem); //GetItemText(listbox1.SelectedIndex);
            txtItemname.Text = text;
            query = "select price from items where name = '" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtquantityupdown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtquantityupdown.Value.ToString());
            Int64 price = Int64.Parse(txtprice.Text);
            txttotal.Text=(quan*price).ToString();


        }
        protected int n, total;

        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch { }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);


            }
            catch { }
            total -= amount;
            labeltotal.Text = "Rs. " + total;
        }
        private string ShowInputDialog(string title, string prompt)
{
    Form inputForm = new Form();
    inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
    inputForm.StartPosition = FormStartPosition.CenterScreen;
    inputForm.MaximizeBox = false;
    inputForm.MinimizeBox = false;
    inputForm.ClientSize = new Size(300, 120);
    inputForm.Text = title;

    TextBox textBox = new TextBox();
    textBox.Size = new Size(200, 23);
    textBox.Location = new Point(50, 30);
    inputForm.Controls.Add(textBox);

    Button okButton = new Button();
    okButton.DialogResult = DialogResult.OK;
    okButton.Name = "okButton";
    okButton.Size = new Size(75, 23);
    okButton.Text = "OK";
    okButton.Location = new Point(100, 70);
    inputForm.Controls.Add(okButton);

    inputForm.AcceptButton = okButton;

    if (inputForm.ShowDialog() == DialogResult.OK)
    {
        return textBox.Text;
    }
    else
    {
        return null;
    }
}

        private void btnprint_Click(object sender, EventArgs e)
        {
                  string customerName = ShowInputDialog("Customer Name", "Enter your name:");
        if (string.IsNullOrEmpty(customerName))
        {
        MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
         }

    // Get today's date
            string currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

            query1="insert into customerr values('"+ customerName+"',"+txttotal.Text+" , '" + currentDate+"')";
            fn.SetData(query1);
            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + labeltotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            total = 0;
            dataGridView1.Rows.Clear();
            labeltotal.Text = "Rs. " + total;
        }

        private void btndata_Click(object sender, EventArgs e)
        {
       
 // Show custom input dialog box to enter customer's name
        string customerName = ShowInputDialog("Customer Name", "Enter your name:");
        if (string.IsNullOrEmpty(customerName))
        {
        MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
         }

    // Get today's date
            string currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

            query1="insert into customerr values('"+ customerName+"',"+txttotal.Text+" , '" + currentDate+"')";
            fn.SetData(query1);

            query = "insert into orderrs(name, price, quantity, total) values('" + txtItemname.Text+ "' , " + txtprice.Text + " , "+txtquantityupdown.Text+" , "+txttotal.Text+")";
            fn.SetData(query);
            clearAll();
        }
        public void clearAll()
        {
            //txtcategory.SelectedIndex = -1;
            txtItemname.Clear();
            txtprice.Clear();
            txttotal.Clear();
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if(txttotal.Text != "0" && txttotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemname.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtprice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtquantityupdown.Text;
                dataGridView1.Rows[n].Cells[3].Value = txttotal.Text;

                total += int.Parse(txttotal.Text);
                labeltotal.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity should be 1 ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
