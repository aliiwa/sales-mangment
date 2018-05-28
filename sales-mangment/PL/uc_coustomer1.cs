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
    public partial class uc_coustomer1 : UserControl
    {
        BL.CLS_Customer cust = new BL.CLS_Customer();
        string state = "save";
        public uc_coustomer1()
        {
            InitializeComponent();
            this.dgv_cust.DataSource = cust.GET_ALL_CUSTOMER();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearBox();
            txt_cust_code.Text = cust.GET_MAX_CUSTOMER_ID().Rows[0][0].ToString();
            btn_save.Enabled = true;

        }


        private void clearBox()
        {
            txt_cust_code.Clear();
            txt_cust_name.Clear();
            txt_cust_phone.Clear();
            txt_cust_addrees.Clear();
        }

        private void chk_status_OnChange(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            

            if (state == "save")
            {
                cust.ADD_CUSTOMER(Convert.ToString( txt_cust_code.Text), txt_cust_name.Text, Convert.ToInt32(txt_cust_phone.Text), txt_cust_addrees.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cust.DataSource = cust.GET_ALL_CUSTOMER();
                clearBox();


            }
            else
            {
                cust.UPDATE_CUSTOMER(txt_cust_code.Text, txt_cust_name.Text, Convert.ToInt32(txt_cust_phone.Text), txt_cust_addrees.Text);

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cust.DataSource = cust.GET_ALL_CUSTOMER();
                clearBox();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            state = "update";
            btn_save.Enabled = true;
            txt_cust_code.Text = this.dgv_cust.CurrentRow.Cells[1].Value.ToString();
            txt_cust_name.Text = this.dgv_cust.CurrentRow.Cells[2].Value.ToString();
            txt_cust_phone.Text = this.dgv_cust.CurrentRow.Cells[3].Value.ToString();
            txt_cust_addrees.Text = this.dgv_cust.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cust.DELETE_CUSTOMER(this.dgv_cust.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cust.DataSource = cust.GET_ALL_CUSTOMER();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cust.SEARCH_CUSTOMER(txt_search.Text);
            this.dgv_cust.DataSource = dt;
        }
    }
}
