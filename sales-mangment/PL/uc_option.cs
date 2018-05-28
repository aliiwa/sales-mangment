using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL
{
    public partial class uc_option : UserControl
    {
        public uc_option()
        {
            InitializeComponent();
        }

        private void chk_point_sales_OnChange(object sender, EventArgs e)
        {
            chk_point_sales.Checked = true;
            chk_bills.Checked = false;
            uc_option_connect1.BringToFront();
        }

        private void chk_bills_OnChange(object sender, EventArgs e)
        {
            chk_point_sales.Checked = false;
            chk_bills.Checked = true;
            uc_option_db1.BringToFront();
        }
    }
}
