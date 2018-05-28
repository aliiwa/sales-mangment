using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tap_Click(object sender, EventArgs e)
        {

            indicator.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            indicator.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            Label1.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            
            // CTL_Event.BringToFront();

        }

        private void btn_point_selas_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_point_sales11.BringToFront();
        }

        private void btn_supplyer_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_supplyer11.BringToFront();
        }

        private void btn_coutomer_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_coustomer11.BringToFront();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_procduct11.BringToFront();
        }

        private void btn_bills_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            bills11.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_report1.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_option1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
            uc_users1.BringToFront();
        }
    }
}
