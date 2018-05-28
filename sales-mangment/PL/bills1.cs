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
    public partial class bills1 : UserControl
    {
        public bills1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(comboBox1.SelectedValue == "ايصال قبض")
            {
                groupBox1.Visible = true;
            }
            else if (comboBox1.SelectedValue == "ايصال صرف")
            {
                groupBox2.Visible = true;
            }*/
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true )
            {
               uc_bills121.BringToFront();
                bunifuCheckbox2.Checked = false;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox2.Checked == true)
            {
                
               uc_bills111.BringToFront();
                bunifuCheckbox1.Checked = false;
            }
        }

        
    }
}
