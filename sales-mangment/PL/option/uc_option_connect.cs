using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_mangment.PL.option
{
    public partial class uc_option_connect : UserControl
    {
        public uc_option_connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_server_name.Text;
            Properties.Settings.Default.Database = txt_db_name.Text;
            Properties.Settings.Default.mode = rdo_sql.Checked == true ? "SQL" : "windows";
            Properties.Settings.Default.id = txt_username.Text;
            Properties.Settings.Default.password = txt_password.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح", "حفظ الاعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdo_sql_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_sql.Checked)
            {
                txt_username.ReadOnly = false;
                txt_password.ReadOnly = false;
            }
            else
            {
                txt_username.ReadOnly = true;
                txt_password.ReadOnly = true;
            }
        }
    }
}
