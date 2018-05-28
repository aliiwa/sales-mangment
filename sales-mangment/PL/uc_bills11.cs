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
    public partial class uc_bills11 : UserControl
    {
        BL.CLS_bills bil = new BL.CLS_bills();

        DataTable Dt = new DataTable();

        public uc_bills11()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_bills_no.Clear();
            txt_amount.Clear();
            txt_amount_ar.Clear();
            txt_sup_id.Clear();
            txt_sup_name.Clear();
            txt_descrption.Clear();
            btn_save.Enabled = true;
            txt_bills_no.Text = bil.GET_MAX_BILLS1().Rows[0][0].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bil.ADD_BILLS_1(txt_bills_no.Text, dt_time.Value, Convert.ToDouble(txt_amount.Text), txt_amount_ar.Text, txt_descrption.Text, Convert.ToInt32(txt_sup_id.Text), txt_sup_name.Text);
            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_choose_Click(object sender, EventArgs e)
        {
            frm_choose_supplay frm = new frm_choose_supplay();
            frm.ShowDialog();
            txt_sup_id.Text= frm.dgv_customer.CurrentRow.Cells[1].Value.ToString();
            txt_sup_name.Text = frm.dgv_customer.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
