using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace sales_mangment.PL.users
{
    public partial class uc_user_control : UserControl
    {
        BL.CLS_users us = new BL.CLS_users();
        DataTable dt = new DataTable();
        public string state = "add";
        public uc_user_control()
        {
            InitializeComponent();
            dgv_users.DataSource = us.GET_ALL_USERS();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string hashPass = SHA512(txt_password.Text);

            if (state == "add")
            {
                if (txt_user_id.Text != string.Empty && txt_full_name.Text != string.Empty && txt_user_name.Text != string.Empty && txt_password.Text != string.Empty)
                {
                    us.ADD_USERS(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text, hashPass);

                    MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv_users.DataSource = us.GET_ALL_USERS();
                }
            }
            else
            {
                hashPass = SHA512(txt_password.Text);

                if (txt_password.Text != string.Empty)
                {
                    us.UPDATE_USERS(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text, hashPass);

                    MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv_users.DataSource = us.GET_ALL_USERS();
                }
                else
                {
                    us.UPDATE_USER_EX(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text);

                    MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgv_users.DataSource = us.GET_ALL_USERS();
                }
            }
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            clearBox();
            txt_user_id.Text = us.MAX_USER_ID().Rows[0][0].ToString();
            btn_save.Enabled = true;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_user_id.Text = this.dgv_users.CurrentRow.Cells[0].Value.ToString();
            txt_full_name.Text = this.dgv_users.CurrentRow.Cells[1].Value.ToString();
            txt_user_name.Text = this.dgv_users.CurrentRow.Cells[2].Value.ToString();

            btn_save.Enabled = true;
            state = "ubdate";
        }

        /****************************** دالة التشفير ******************************************/

        private string SHA512(string password)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] hash = System.Text.Encoding.UTF8.GetBytes(password);
            hash = SHA512.ComputeHash(hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


        /********************************** اجراءات عالمة *****************************************/

        private void clearBox()
        {
            txt_user_id.Clear();
            txt_full_name.Clear();
            txt_user_name.Clear();
            txt_password.Clear();


            //btn_new.Enabled = true;
        }


    }
}
