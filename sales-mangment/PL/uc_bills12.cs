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


    public partial class uc_bills12 : UserControl
    {
        BL.CLS_bills bil = new BL.CLS_bills();

        DataTable Dt = new DataTable();
        public uc_bills12()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_bills2_no.Clear();
            txt_amount.Clear();
            txt_amount_ar.Clear();
            txt_cut_id.Clear();
            txt_customer.Clear();
            txt_descrption.Clear();
            btn_save.Enabled = true;
            txt_bills2_no.Text = bil.GET_MAX_BILLS2().Rows[0][0].ToString();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            frm_choose_coustomer frm = new frm_choose_coustomer();
            frm.ShowDialog();
            txt_cut_id.Text = frm.dgv_customer.CurrentRow.Cells[0].Value.ToString();
            txt_customer.Text = frm.dgv_customer.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (txt_amount.Text == string.Empty)
            {

                txt_amount.Text = Convert.ToString(0);
                txt_amount_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_amount.Text), "دينار", "درهم");
            }
            else
            {
                txt_amount_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_amount.Text), "دينار", "درهم");
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bil.ADD_BILLS_2(txt_bills2_no.Text, dt_time.Value, Convert.ToDouble(txt_amount.Text), txt_amount_ar.Text, txt_descrption.Text, Convert.ToInt32(txt_cut_id.Text), txt_customer.Text);
            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
