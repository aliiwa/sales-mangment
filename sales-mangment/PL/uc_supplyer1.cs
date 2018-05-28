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
    public partial class uc_supplyer1 : UserControl
    {
        BL.CLS_Supplay supp = new BL.CLS_Supplay();
        string state = "save";

        public uc_supplyer1()
        {
            InitializeComponent();
            this.dgv_supplay.DataSource = supp.GET_ALL_SUPPLAY();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == "save")
            {
                supp.ADD_SUPPLAY(Convert.ToString(txt_supp_code.Text), txt_supp_name.Text, Convert.ToInt32(txt_supp_phone.Text), txt_supp_addrees.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_supplay.DataSource = supp.GET_ALL_SUPPLAY();
                clearBox();


            }
            else
            {
                supp.UPDATE_SUPPLAY(Convert.ToString(txt_supp_code.Text), txt_supp_name.Text, Convert.ToInt32(txt_supp_phone.Text), txt_supp_addrees.Text);

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.dgv_supplay.DataSource = supp.GET_ALL_SUPPLAY();
                clearBox();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearBox();
            txt_supp_code.Text = supp.MAX_SUPP_ID().Rows[0][0].ToString();
            btn_save.Enabled = true;
        }


        private void clearBox()
        {
            txt_supp_code.Clear();
            txt_supp_name.Clear();
            txt_supp_phone.Clear();
            txt_supp_addrees.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            state = "update";
            btn_save.Enabled = true;
            txt_supp_code.Text = this.dgv_supplay.CurrentRow.Cells[0].Value.ToString();
            txt_supp_name.Text = this.dgv_supplay.CurrentRow.Cells[1].Value.ToString();
            txt_supp_phone.Text = this.dgv_supplay.CurrentRow.Cells[2].Value.ToString();
            txt_supp_addrees.Text = this.dgv_supplay.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                supp.DELETE_SUPPLAY(this.dgv_supplay.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_supplay.DataSource = supp.GET_ALL_SUPPLAY();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_supp_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = supp.SEARCH_SUPPLAY(txt_supp_search.Text);
            this.dgv_supplay.DataSource = dt;
        }
    }
}
