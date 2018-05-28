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
    public partial class uc_rep_balance : UserControl
    {
        BL.CLS_Report rpt = new BL.CLS_Report();
        DataTable Dt = new DataTable();
        public uc_rep_balance()
        {
            InitializeComponent();
            dgv_balance.DataSource = rpt.GET_ALL_PALANCE();
        }

        private void btn_close_balance_Click(object sender, EventArgs e)
        {
            frm_close_balance frm = new frm_close_balance();
            frm.ShowDialog();
        }
    }
}
