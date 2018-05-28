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
    public partial class frm_unit : Form
    {
        BL.CLS_Product pro = new BL.CLS_Product();
        string state2 = "save";
        public frm_unit()
        {
            InitializeComponent();
            this.dgv_unit.DataSource = pro.GET_ALL_UNITS();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
            btn_save.Enabled = true;
            txt_unit_id.Clear();
            txt_unit_name.Clear();
            this.txt_unit_id.Text = pro.GET_MAX_UNIT_ID().Rows[0][0].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state2 == "save")
            {
                pro.ADD_UNIT(txt_unit_name.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = pro.GET_ALL_UNITS();
                txt_unit_id.Clear();
                txt_unit_name.Clear();
            }
            else
            {
                pro.UPDATE_UNIT(txt_unit_name.Text,Convert.ToInt32(txt_unit_id.Text));

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = pro.GET_ALL_UNITS();
                txt_unit_id.Clear();
                txt_unit_name.Clear();
            }
            
        }
     
        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_unit_id.Text = this.dgv_unit.CurrentRow.Cells[0].Value.ToString();
            txt_unit_name.Text = this.dgv_unit.CurrentRow.Cells[1].Value.ToString();
            btn_save.Enabled = true;
            state2 = "udate";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                pro.DELETE_UNIT(Convert.ToInt32( this.dgv_unit.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = pro.GET_ALL_UNITS();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_unit_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
