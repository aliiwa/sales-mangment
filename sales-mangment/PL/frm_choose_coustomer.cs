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
    public partial class frm_choose_coustomer : Form
    {
        BL.CLS_bills bil = new BL.CLS_bills();

        DataTable Dt = new DataTable();
        public frm_choose_coustomer()
        {
            InitializeComponent();
            dgv_customer.DataSource = bil.GET_ALL_CUSTOMER();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
       
            Dt = bil.SEARCH_CUSTOMER_(txt_search.Text);
            this.dgv_customer.DataSource = Dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_customer_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
