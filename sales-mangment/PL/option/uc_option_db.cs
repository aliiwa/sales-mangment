using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sales_mangment.PL.option
{
    public partial class uc_option_db : UserControl
    {
        SqlConnection con = new SqlConnection(@"Server = ALIWA-PC,1433; DataBase = master; Integrated Security = true");
        SqlCommand cmd;
        public uc_option_db()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            string fileName = txt_fileName.Text + "\\" + Properties.Settings.Default.Database + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string srtQuery = "Backup Database seles_db to Disk ='" + fileName + ".bak'";
            cmd = new SqlCommand(srtQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء النسخة", "انشاء النسخة الاحتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_fileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_chooes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_re_fileName.Text = openFileDialog1.FileName;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string srtQuery = "ALTER database seles_db set OFFLINE with rollback immediate; Restore Database seles_db from Disk ='" + txt_re_fileName.Text + "'";
            cmd = new SqlCommand(srtQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة", "استعادة النسخة الاحتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
