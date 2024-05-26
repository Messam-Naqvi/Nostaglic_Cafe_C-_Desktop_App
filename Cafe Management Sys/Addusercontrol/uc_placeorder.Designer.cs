namespace WindowsFormsApp1.Addusercontrol
{
    partial class uc_placeorder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtquantityupdown = new System.Windows.Forms.NumericUpDown();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.btndata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantityupdown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(26, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(256, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(256, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Amount :";
            // 
            // txtItemname
            // 
            this.txtItemname.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtItemname.Location = new System.Drawing.Point(30, 63);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(173, 25);
            this.txtItemname.TabIndex = 13;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtprice.Location = new System.Drawing.Point(260, 63);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(161, 25);
            this.txtprice.TabIndex = 14;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txttotal.Location = new System.Drawing.Point(260, 138);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(161, 25);
            this.txttotal.TabIndex = 15;
            // 
            // txtquantityupdown
            // 
            this.txtquantityupdown.Location = new System.Drawing.Point(30, 136);
            this.txtquantityupdown.Name = "txtquantityupdown";
            this.txtquantityupdown.Size = new System.Drawing.Size(175, 27);
            this.txtquantityupdown.TabIndex = 16;
            this.txtquantityupdown.ValueChanged += new System.EventHandler(this.txtquantityupdown_ValueChanged);
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.RosyBrown;
            this.btnaddtocart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddtocart.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnaddtocart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaddtocart.Location = new System.Drawing.Point(174, 182);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(112, 29);
            this.btnaddtocart.TabIndex = 17;
            this.btnaddtocart.Text = "Add to Cart";
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnaddtocart);
            this.panel1.Controls.Add(this.txtquantityupdown);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtItemname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(235, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 221);
            this.panel1.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(219, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 151);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnremove.ForeColor = System.Drawing.Color.IndianRed;
            this.btnremove.Location = new System.Drawing.Point(235, 423);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(119, 29);
            this.btnremove.TabIndex = 18;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnprint.ForeColor = System.Drawing.Color.IndianRed;
            this.btnprint.Location = new System.Drawing.Point(593, 423);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(119, 29);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(417, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = " Grand Total :";
            // 
            // labeltotal
            // 
            this.labeltotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labeltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeltotal.Font = new System.Drawing.Font("Comic Sans MS", 11.2F);
            this.labeltotal.Location = new System.Drawing.Point(415, 423);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(119, 35);
            this.labeltotal.TabIndex = 21;
            this.labeltotal.Text = "Rs . 0.0";
            this.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combocategory
            // 
            this.combocategory.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "Main Course ",
            "Appetizer",
            "Breakfast",
            "Beverage",
            "Bakery",
            "Fast Food",
            "Chinese",
            "Italian",
            "Pakistani",
            "Desert",
            "Sandwich",
            "Burger",
            "Side Dish",
            "Soft Drink"});
            this.combocategory.Location = new System.Drawing.Point(7, 67);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(180, 30);
            this.combocategory.TabIndex = 22;
            this.combocategory.SelectedIndexChanged += new System.EventHandler(this.combocategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Category :";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtsearch.Location = new System.Drawing.Point(7, 117);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(148, 25);
            this.txtsearch.TabIndex = 18;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // listbox1
            // 
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 16;
            this.listbox1.Location = new System.Drawing.Point(7, 160);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(180, 244);
            this.listbox1.TabIndex = 24;
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listbox1_SelectedIndexChanged);
            // 
            // btndata
            // 
            this.btndata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndata.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btndata.ForeColor = System.Drawing.Color.IndianRed;
            this.btndata.Location = new System.Drawing.Point(36, 426);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(119, 29);
            this.btndata.TabIndex = 25;
            this.btndata.Text = "Add to List";
            this.btndata.UseVisualStyleBackColor = false;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // uc_placeorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.btndata);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "uc_placeorder";
            this.Size = new System.Drawing.Size(767, 489);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantityupdown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.NumericUpDown txtquantityupdown;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button btndata;
    }
}
