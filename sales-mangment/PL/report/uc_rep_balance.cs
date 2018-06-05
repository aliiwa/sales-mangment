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

        private void dgv_balance_DoubleClick(object sender, EventArgs e)
        {

            dgv_product.DataSource = rpt.GET_ALL_PALANCE_DETAILS( Convert.ToDateTime( this.dgv_balance.CurrentRow.Cells[0].Value.ToString()));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RPT.rpt_palance_1 rpt_1 = new RPT.rpt_palance_1();
            RPT.frm_report frm1 = new RPT.frm_report();
            DateTime date_1 = Convert.ToDateTime(this.dgv_balance.CurrentRow.Cells[0].Value.ToString());

            rpt_1.SetDataSource(rpt.GET_ALL_PALANCE_DETAILS(date_1));
            frm1.crystalReportViewer1.ReportSource = rpt_1;
           
            frm1.ShowDialog();
        }
    }
}
