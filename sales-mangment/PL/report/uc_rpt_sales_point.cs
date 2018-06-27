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
    public partial class uc_rpt_sales_point : UserControl
    {
        BL.CLS_Report rep = new BL.CLS_Report();
        public uc_rpt_sales_point()
        {
            InitializeComponent();
            dgv_date.DataSource = rep.GET_INV_DATE();
            // dgv_products.DataSource = ( from  select SUM(total_invoes)from TP_invoies);
        }

        private void dgv_date_Click(object sender, EventArgs e)
        {
            dgv_rep_inv.DataSource = rep.GET_INV_CODE(Convert.ToDateTime(dgv_date.CurrentRow.Cells[0].Value.ToString()));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RPT.rpt_sales_point rpt_1 = new RPT.rpt_sales_point();
            RPT.frm_report frm1 = new RPT.frm_report();
           

            rpt_1.SetDataSource(rep.GET_INV_CODE(Convert.ToDateTime(dgv_date.CurrentRow.Cells[0].Value.ToString())));
            frm1.crystalReportViewer1.ReportSource = rpt_1;

            frm1.ShowDialog();
        }

        private void btn_print_all_Click(object sender, EventArgs e)
        {
            RPT.rpt_inv_details rpt_1 = new RPT.rpt_inv_details();
            RPT.frm_report frm1 = new RPT.frm_report();


            rpt_1.SetDataSource(rep.RPT_SALES_POINT(Convert.ToDateTime(dgv_date.CurrentRow.Cells[0].Value.ToString())));
            frm1.crystalReportViewer1.ReportSource = rpt_1;

            frm1.ShowDialog();
        }
    }
}
