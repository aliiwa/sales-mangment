using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL.report
{
    public partial class frm_close_balance : Form
    {
        BL.CLS_Report rpt = new BL.CLS_Report();
        DataTable Dt = new DataTable();
        public frm_close_balance()
        {
            InitializeComponent();
        }

        private void btn_add_balance_Click(object sender, EventArgs e)
        {

            rpt.ADD_PALANCE(dt_balance.Value);
            uc_rep_balance us = new uc_rep_balance();
            us.dgv_balance.DataSource = rpt.GET_ALL_PALANCE();
            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
