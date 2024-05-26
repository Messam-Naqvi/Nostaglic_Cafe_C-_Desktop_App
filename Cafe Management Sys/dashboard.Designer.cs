namespace WindowsFormsApp1
{
    partial class dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnremoveitem = new System.Windows.Forms.Button();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.btnadditem = new System.Windows.Forms.Button();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.uc_updateitemcs1 = new WindowsFormsApp1.Addusercontrol.uc_updateitemcs();
            this.uc_placeorder1 = new WindowsFormsApp1.Addusercontrol.uc_placeorder();
            this.uc_additem1 = new WindowsFormsApp1.uc_additem();
            this.uc_welcome1 = new WindowsFormsApp1.Addusercontrol.uc_welcome();
            this.uc_removeitem1 = new WindowsFormsApp1.Addusercontrol.uc_removeitem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.uc_removeitem1);
            this.panel2.Controls.Add(this.uc_updateitemcs1);
            this.panel2.Controls.Add(this.uc_placeorder1);
            this.panel2.Controls.Add(this.uc_additem1);
            this.panel2.Controls.Add(this.uc_welcome1);
            this.panel2.Location = new System.Drawing.Point(221, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 480);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.btnremoveitem);
            this.panel3.Controls.Add(this.btnupdateitem);
            this.panel3.Controls.Add(this.btnadditem);
            this.panel3.Controls.Add(this.btnplaceorder);
            this.panel3.Location = new System.Drawing.Point(32, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 480);
            this.panel3.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(63, 409);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 23);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnremoveitem
            // 
            this.btnremoveitem.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnremoveitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnremoveitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveitem.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnremoveitem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnremoveitem.Location = new System.Drawing.Point(25, 318);
            this.btnremoveitem.Name = "btnremoveitem";
            this.btnremoveitem.Size = new System.Drawing.Size(158, 46);
            this.btnremoveitem.TabIndex = 7;
            this.btnremoveitem.Text = "Remove Item";
            this.btnremoveitem.UseVisualStyleBackColor = false;
            this.btnremoveitem.Click += new System.EventHandler(this.btnremoveitem_Click);
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnupdateitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupdateitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateitem.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnupdateitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdateitem.Location = new System.Drawing.Point(25, 232);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Size = new System.Drawing.Size(158, 46);
            this.btnupdateitem.TabIndex = 6;
            this.btnupdateitem.Text = "Update Item";
            this.btnupdateitem.UseVisualStyleBackColor = false;
            this.btnupdateitem.Click += new System.EventHandler(this.btnupdateitem_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnadditem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadditem.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnadditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadditem.Location = new System.Drawing.Point(25, 140);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(158, 46);
            this.btnadditem.TabIndex = 5;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = false;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnplaceorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnplaceorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplaceorder.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnplaceorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnplaceorder.Location = new System.Drawing.Point(25, 51);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(158, 46);
            this.btnplaceorder.TabIndex = 4;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = false;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(947, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(35, 29);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // uc_updateitemcs1
            // 
            this.uc_updateitemcs1.BackColor = System.Drawing.Color.RosyBrown;
            this.uc_updateitemcs1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uc_updateitemcs1.Location = new System.Drawing.Point(4, 1);
            this.uc_updateitemcs1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uc_updateitemcs1.Name = "uc_updateitemcs1";
            this.uc_updateitemcs1.Size = new System.Drawing.Size(767, 489);
            this.uc_updateitemcs1.TabIndex = 3;
            // 
            // uc_placeorder1
            // 
            this.uc_placeorder1.BackColor = System.Drawing.Color.RosyBrown;
            this.uc_placeorder1.Location = new System.Drawing.Point(10, 0);
            this.uc_placeorder1.Name = "uc_placeorder1";
            this.uc_placeorder1.Size = new System.Drawing.Size(767, 489);
            this.uc_placeorder1.TabIndex = 2;
            // 
            // uc_additem1
            // 
            this.uc_additem1.BackColor = System.Drawing.Color.RosyBrown;
            this.uc_additem1.Location = new System.Drawing.Point(10, 0);
            this.uc_additem1.Name = "uc_additem1";
            this.uc_additem1.Size = new System.Drawing.Size(761, 481);
            this.uc_additem1.TabIndex = 1;
            // 
            // uc_welcome1
            // 
            this.uc_welcome1.BackColor = System.Drawing.Color.Silver;
            this.uc_welcome1.Location = new System.Drawing.Point(10, 0);
            this.uc_welcome1.Name = "uc_welcome1";
            this.uc_welcome1.Size = new System.Drawing.Size(751, 481);
            this.uc_welcome1.TabIndex = 0;
            // 
            // uc_removeitem1
            // 
            this.uc_removeitem1.BackColor = System.Drawing.Color.RosyBrown;
            this.uc_removeitem1.Location = new System.Drawing.Point(10, 0);
            this.uc_removeitem1.Name = "uc_removeitem1";
            this.uc_removeitem1.Size = new System.Drawing.Size(767, 489);
            this.uc_removeitem1.TabIndex = 4;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1004, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnremoveitem;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.Button btnexit;
        private Addusercontrol.uc_welcome uc_welcome1;
        private uc_additem uc_additem1;
        private Addusercontrol.uc_placeorder uc_placeorder1;
        private Addusercontrol.uc_updateitemcs uc_updateitemcs1;
        private Addusercontrol.uc_removeitem uc_removeitem1;
    }
}