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
    public partial class uc_procduct1 : UserControl
    {
        BL.CLS_Product pro = new BL.CLS_Product();
        string state = "save";
        public uc_procduct1()
        {
            InitializeComponent();
            this.dgv_product.DataSource = pro.GET_ALL_PRODUCT();


            /*  تعبئة الكومبو بوكس */
            /* كومبو بكوس الوحدات */
            cmb_pro_uint.DataSource = pro.GET_ALL_UNITS();
            cmb_pro_uint.DisplayMember = "unit_name";
            cmb_pro_uint.ValueMember = "unit_id";


            
            /* كومبو بوكس التصنيفات */
            cmb_pro_category.DataSource = pro.GET_ALL_CATEGORY();
            cmb_pro_category.DisplayMember = "cat_name";
            cmb_pro_category.ValueMember = "cat_id";

            txt_pro_name.Focus();
        }

     

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_unit un = new frm_unit();
            un.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frm_category cat = new frm_category();
            cat.ShowDialog();
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {

            /*if (pn_search.Visible == false)
            {
                pn_search.Visible = true;
            }
            else
            {
                pn_search.Visible = false;
            }*/
        }

        private void clearBox()
        {

            txt_pro_code.Clear();
            txt_pro_name.Clear();
            txt_pro_pay.Clear();
            txt_pro_sale.Clear();
            txt_pro_contry.Clear();
            txt_pro_company.Clear();
            txt_pro_barcode.Clear();
            
        }

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    if (state == "save")
        //    {
        //        pro.ADD_PRODUCT(txt_pro_code.Text, txt_pro_name.Text, Convert.ToInt32(cmb_pro_uint.SelectedValue), Convert.ToInt32(cmb_pro_category.SelectedValue)
        //            , txt_pro_contry.Text, txt_pro_company.Text/*, Convert.ToInt32(txt_pro_pay.Text), Convert.ToInt32(txt_pro_sale.Text)*/);
        //        clearBox();
        //        MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.dgv_product.DataSource = pro.GET_ALL_CATEGORY();

        //    }
        //    else
        //    {
        //        pro.UPDATE_PRODUCT(txt_pro_code.Text, txt_pro_name.Text, Convert.ToInt32(cmb_pro_uint.SelectedValue), Convert.ToInt32(cmb_pro_category.SelectedValue)
        //            , txt_pro_contry.Text, txt_pro_company.Text, Convert.ToInt32(txt_pro_pay.Text), Convert.ToInt32(txt_pro_sale.Text));
        //        clearBox();
        //        MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.dgv_product.DataSource = pro.GET_ALL_CATEGORY();

        //    }
        //}

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearBox();
            this.txt_pro_code.Text =  pro.GET_MAX_PRODUCT_ID().Rows[0][0].ToString();
            btn_save.Enabled = true;
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (state == "save")
            {
                pro.ADD_PRODUCT(txt_pro_code.Text, txt_pro_name.Text, Convert.ToInt32(cmb_pro_uint.SelectedValue), Convert.ToInt32(cmb_pro_category.SelectedValue)
                    , txt_pro_contry.Text, txt_pro_company.Text, Convert.ToDouble(txt_pro_pay.Text), Convert.ToDouble(txt_pro_sale.Text));

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_product.DataSource = pro.GET_ALL_PRODUCT();
                clearBox();


            }
            else
            {
                pro.UPDATE_PRODUCT(txt_pro_code.Text, txt_pro_name.Text, Convert.ToInt32(cmb_pro_uint.SelectedValue), Convert.ToInt32(cmb_pro_category.SelectedValue)
                    , txt_pro_contry.Text, txt_pro_company.Text, Convert.ToDouble(txt_pro_pay.Text), Convert.ToDouble(txt_pro_sale.Text));

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_product.DataSource = pro.GET_ALL_PRODUCT();
                clearBox();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            txt_pro_code.Text = this.dgv_product.CurrentRow.Cells[0].Value.ToString();
            txt_pro_name.Text = this.dgv_product.CurrentRow.Cells[1].Value.ToString();
            cmb_pro_uint.Text = this.dgv_product.CurrentRow.Cells[2].Value.ToString();
            cmb_pro_category.Text = this.dgv_product.CurrentRow.Cells[3].Value.ToString();
            txt_pro_pay.Text = this.dgv_product.CurrentRow.Cells[4].Value.ToString();
            txt_pro_sale.Text = this.dgv_product.CurrentRow.Cells[5].Value.ToString();
            txt_pro_company.Text = this.dgv_product.CurrentRow.Cells[7].Value.ToString();
            txt_pro_contry.Text = this.dgv_product.CurrentRow.Cells[6].Value.ToString();
            txt_pro_barcode.Text = this.dgv_product.CurrentRow.Cells[8].Value.ToString();
            state = "update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pro.DELETE_PRODUCT(Convert.ToInt32(this.dgv_product.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_product.DataSource = pro.GET_ALL_PRODUCT();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pro.SEARCH_PRODUCT(txt_search.Text);
            this.dgv_product.DataSource = dt;
        }
    }
}
