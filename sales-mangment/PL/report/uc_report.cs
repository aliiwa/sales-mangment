using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL.report
{
    public partial class uc_report : UserControl
    {
        public uc_report()
        {
            InitializeComponent();
        }

        private void chk_point_sales_OnChange(object sender, EventArgs e)
        {
            uc_rpt_sales_point1.BringToFront();
            chk_point_sales.Checked = true;
            chk_bills.Checked = false;
            chk_supplyer.Checked = false;
            chk_coutomer.Checked = false;
            chk_product.Checked = false;
            chk_balance.Checked = false;
        }

        private void chk_bills_OnChange(object sender, EventArgs e)
        {
            chk_point_sales.Checked = false;
            chk_bills.Checked = true;
            chk_supplyer.Checked = false;
            chk_coutomer.Checked = false;
            chk_product.Checked = false;
            chk_balance.Checked = false;
        }

        private void chk_supplyer_OnChange(object sender, EventArgs e)
        {
            chk_point_sales.Checked = false;
            chk_bills.Checked = false;
            chk_supplyer.Checked = true;
            chk_coutomer.Checked = false;
            chk_product.Checked = false;
            chk_balance.Checked = false;
        }

        private void chk_coutomer_OnChange(object sender, EventArgs e)
        {
            chk_point_sales.Checked = false;
            chk_bills.Checked = false;
            chk_supplyer.Checked = false;
            chk_coutomer.Checked = true;
            chk_product.Checked = false;
            chk_balance.Checked = false;
        }

        private void chk_product_OnChange(object sender, EventArgs e)
        {
            uc_rep_product1.BringToFront();
            chk_point_sales.Checked = false;
            chk_bills.Checked = false;
            chk_supplyer.Checked = false;
            chk_coutomer.Checked = false;
            chk_product.Checked = true;
            chk_balance.Checked = false;
        }

        private void chk_balance_OnChange(object sender, EventArgs e)
        {
            uc_rep_balance1.BringToFront();
            chk_point_sales.Checked = false;
            chk_bills.Checked = false;
            chk_supplyer.Checked = false;
            chk_coutomer.Checked = false;
            chk_product.Checked = false;
            chk_balance.Checked = true;
        }


    }
}
