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
 
    public partial class uc_welcome : UserControl
    {
        public uc_welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                btnour.Location = new Point(90, 340);
                btnour.ForeColor = Color.Purple;
                num++;
            }
            else if (num == 1)
            {
                btnour.Location = new Point(160, 340);
                btnour.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                btnour.Location = new Point(260, 340);
                btnour.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void uc_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnour_Click(object sender, EventArgs e)
        {

        }
    }
}
