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
    public partial class uc_rep_product : UserControl

    {
        BL.CLS_Report rpt = new BL.CLS_Report();
        DataTable Dt = new DataTable();
        public uc_rep_product()
        {
            InitializeComponent();
            this.dgv_products.DataSource = rpt.GET_ALL_PRODUCT();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            RPT.rpt_products rpt_1 = new RPT.rpt_products();
            RPT.frm_report frm1 = new RPT.frm_report();
            

            rpt_1.SetDataSource(rpt.GET_ALL_PRODUCT());
            frm1.crystalReportViewer1.ReportSource = rpt_1;

            frm1.ShowDialog();
        }
    }
}
