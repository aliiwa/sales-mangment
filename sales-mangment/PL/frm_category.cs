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
    public partial class frm_category : Form
    {
        BL.CLS_Product pro = new BL.CLS_Product();
        string state1 = "save";
        public frm_category()
        {
            InitializeComponent();
            this.dgv_category.DataSource = pro.GET_ALL_CATEGORY();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
           
            txt_category_id.Clear();
            txt_category_name.Clear();
            btn_save.Enabled = true;
            this.txt_category_id.Text = pro.GET_MAX_CAT_ID().Rows[0][0].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state1 == "save")
            {
                pro.ADD_CATEGORY(txt_category_name.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_category.DataSource = pro.GET_ALL_CATEGORY();
                txt_category_id.Clear();
                txt_category_name.Clear();
            }
            else 
            {
                pro.UPDATE_CATEGORY(txt_category_name.Text, Convert.ToInt32(txt_category_id.Text));

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_category.DataSource = pro.GET_ALL_CATEGORY();
                txt_category_id.Clear();
                txt_category_name.Clear();
             }
         }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_category_id.Text = this.dgv_category.CurrentRow.Cells[0].Value.ToString();
            txt_category_name.Text = this.dgv_category.CurrentRow.Cells[1].Value.ToString();
            btn_save.Enabled = true;
            state1 = "udate";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pro.DELETE_CATEGORY(Convert.ToInt32(this.dgv_category.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_category.DataSource = pro.GET_ALL_CATEGORY();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
