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


namespace sales_mangment.PL
{
    public partial class uc_point_sales1 : UserControl
    {
        BL.CLS_inoies inv = new BL.CLS_inoies();
        BL.CLS_Product pro = new BL.CLS_Product();
        BL.CLS_Customer cut = new BL.CLS_Customer();
       
        DataTable Dt = new DataTable();
        //string state = "save";

        // اجراء لانشاء datatable
        void CreateDataTable()
        {
            Dt.Columns.Add("رقم الصنف");
            Dt.Columns.Add("اسم الصنف");
            Dt.Columns.Add("الوحدة");
            Dt.Columns.Add("السعر");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("الاجمالي");
            Dt.Columns.Add("اجمالي التكلفة");
            //Dt.Columns.Add("اجمالي الربح");
            
            dgv_invoies.DataSource = Dt;
            dgv_invoies.Columns[6].Visible = false;
        }

        public uc_point_sales1()
        {
            InitializeComponent();

            CreateDataTable();
            /* كومبو بوكس التصنيفات */
            cmb_customer.DataSource = cut.GET_ALL_CUSTOMER();
            cmb_customer.DisplayMember = "cust_name";
            cmb_customer.ValueMember = "cust_id";

           // this.myTableAdapter.Fill(this.myDataSet.someTable);
            //cmb_customer.SelectedItem = null;
            //cmb_customer.SelectedText = "-- اختار --";

            

            dgv_search.DataSource = inv.GET_ONE_PRODUCT();
        }

        /*************************************************************************************************************/

        // اجراء الحفظ
        private void btn_save_Click(object sender, EventArgs e)
        {
            /* if (state == "save")
             {
                
             */

            if(rdo_sales.Checked == true)
            {
                Double rdoSales = 1;
            inv.ADD_INVOIES(txt_inv_code1.Text, dt_inv_date1.Value, Convert.ToDouble(txt_inv_discount1.Text)
                , Convert.ToDouble(txt_inv_extra2.Text), Convert.ToInt32(cmb_customer.SelectedValue), Convert.ToDouble(txt_inv_total1.Text),
                Convert.ToDouble(txt_prid.Text),rdoSales, Convert.ToDouble(txt_total_cost.Text), Convert.ToDouble(total_profit1.Text)
                ,Convert.ToDouble(txt_prid.Text),txt_prid_ar.Text,Convert.ToDouble(txt_remain.Text),txt_remain_ar.Text );

            for (int i = 0; i < dgv_invoies.Rows.Count - 1; i++)
            {
                inv.ADD_INOIES_DETEALS(
                    txt_inv_code1.Text,
                    dgv_invoies.Rows[i].Cells[0].Value.ToString(),
                    dgv_invoies.Rows[i].Cells[1].Value.ToString(),
                    dgv_invoies.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToDouble(dgv_invoies.Rows[i].Cells[3].Value.ToString()),
                    Convert.ToInt32(dgv_invoies.Rows[i].Cells[4].Value.ToString()),
                    Convert.ToDouble(dgv_invoies.Rows[i].Cells[5].Value.ToString())
                    );
            }
                dgv_invoies.Rows.Clear();
            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Double rdoSales = 0;
                inv.ADD_INVOIES(txt_inv_code1.Text, dt_inv_date.Value, Convert.ToDouble(txt_inv_discount1.Text)
                    , Convert.ToDouble(txt_inv_extra2.Text), Convert.ToInt32(cmb_customer.SelectedValue),
                    Convert.ToDouble(txt_inv_total1.Text), Convert.ToDouble(txt_prid.Text), rdoSales, Convert.ToDouble(txt_total_cost.Text),
                    Convert.ToDouble(total_profit1.Text), Convert.ToDouble(txt_prid.Text), txt_prid_ar.Text, Convert.ToDouble(txt_remain.Text), txt_remain_ar.Text);

                for (int i = 0; i < dgv_invoies.Rows.Count - 1; i++)
                {
                    inv.ADD_INOIES_DETEALS2(
                        txt_inv_code1.Text,
                        dgv_invoies.Rows[i].Cells[0].Value.ToString(),
                        dgv_invoies.Rows[i].Cells[1].Value.ToString(),
                        dgv_invoies.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToDouble(dgv_invoies.Rows[i].Cells[3].Value.ToString()),
                        Convert.ToInt32(dgv_invoies.Rows[i].Cells[4].Value.ToString()),
                        Convert.ToDouble(dgv_invoies.Rows[i].Cells[5].Value.ToString())
                        );
                }
                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //dgv_spend.DataSource = Dt;
            //ClearBoxes();
            //txt_spend_code.Clear();
            //Dt.Rows.Clear();



            //}
            //else
            //{
            //    pro.UPDATE_PRODUCT(txt_pro_code.Text, txt_pro_name.Text, Convert.ToInt32(cmb_pro_uint.SelectedValue), Convert.ToInt32(cmb_pro_category.SelectedValue)
            //        , txt_pro_contry.Text, txt_pro_company.Text, Convert.ToDouble(txt_pro_pay.Text), Convert.ToDouble(txt_pro_sale.Text));

            //    MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.dgv_product.DataSource = pro.GET_ALL_PRODUCT();
            //    clearBox();
            //}*/
        }


        // زر جديد
        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_inv_code1.Text = inv.GET_MAX_INVOIES_ID().Rows[0][0].ToString();
            dgv_invoies.DataSource = Dt;
            Dt.Rows.Clear();
            dgv_invoies.Refresh();
        }

        // اجراء البحث 
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = inv.SEARCH_QUICK_LIST(txt_search.Text);
            this.dgv_search.DataSource = dt;
        }


        /**************************************اجراءات عامة ******************************************************/

        // تعئة القيمة من الداتا قيرد فيؤ البحث الي الفاتور
        private void dgv_search_DoubleClick(object sender, EventArgs e)
        {
            txt_pro_code.Text = dgv_search.CurrentRow.Cells[0].Value.ToString();
            txt_pro_name.Text = dgv_search.CurrentRow.Cells[1].Value.ToString();
            txt_pro_unit.Text = dgv_search.CurrentRow.Cells[2].Value.ToString();
            txt_pro_price.Text = dgv_search.CurrentRow.Cells[4].Value.ToString();
            txt_pay.Text = dgv_search.CurrentRow.Cells[7].Value.ToString();
            txt_pro_quantati.Focus();

        }

        private void dgv_invoies_DoubleClick(object sender, EventArgs e)
        {
            txt_pro_code.Text = dgv_invoies.CurrentRow.Cells[0].Value.ToString();
            txt_pro_name.Text = dgv_invoies.CurrentRow.Cells[1].Value.ToString();
            txt_pro_unit.Text = dgv_invoies.CurrentRow.Cells[2].Value.ToString();
            txt_pro_price.Text = dgv_invoies.CurrentRow.Cells[3].Value.ToString();
            txt_pro_quantati.Text = dgv_invoies.CurrentRow.Cells[4].Value.ToString();
            txt_pro_total.Text = dgv_invoies.CurrentRow.Cells[5].Value.ToString();
            
            txt_pro_quantati.Focus();
        }



        // اجراء حساب مجموع سعر الصنف 
        void CalculateAmount()
        {
            if (txt_inv_discount1.Text == string.Empty)
            {
                txt_inv_discount1.Text = Convert.ToString(0);
            }
           

            if (txt_pro_price.Text != string.Empty && txt_pro_quantati.Text != string.Empty && txt_inv_extra2.Text != string.Empty)
            {
                if (chk_discount.Checked == true)
                {
                    double discount = Convert.ToDouble(txt_inv_discount1.Text);
                    Double Amount = Convert.ToDouble(txt_pro_price.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    Double totalAmount = Amount - (Amount * (discount / 100));
                    txt_pro_total.Text = totalAmount.ToString();

                    Double pay = Convert.ToDouble(txt_pay.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    txt_pay.Text = Convert.ToString(pay);

                    Double profit = totalAmount - pay;
                    txt_profit1.Text = Convert.ToString(profit);

                }
                else if (chk_discount.Checked == false)
                {
                    double discount = Convert.ToDouble(txt_inv_discount1.Text);
                    Double Amount = Convert.ToDouble(txt_pro_price.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    Double totalAmount = Amount - discount;
                    txt_pro_total.Text = totalAmount.ToString();

                    Double pay = Convert.ToDouble(txt_pay.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    txt_pay.Text = Convert.ToString(pay);

                    Double profit = totalAmount - pay;
                    txt_profit1.Text = Convert.ToString(profit);
                }

                /**********************************************************************************/

               

            }


            if (cmb_customer.SelectedIndex == 0)
            {
                txt_prid.Text = txt_inv_total1.Text;
                txt_remain.Text = Convert.ToString(00);
               
            }

        }

        void CalculateAmount2()
        {
            if (txt_inv_extra2.Text == string.Empty)
            {
                txt_inv_extra2.Text = Convert.ToString(0);
            }

            if (txt_pro_price.Text != string.Empty && txt_pro_quantati.Text != string.Empty && txt_inv_extra2.Text != string.Empty)
            {
                if (chk_extra.Checked == true)
                {
                    double discount = Convert.ToDouble(txt_inv_extra2.Text);
                    Double Amount = Convert.ToDouble(txt_pro_price.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    Double totalAmount = Amount + (Amount * (discount / 100));
                    txt_pro_total.Text = totalAmount.ToString();
                }
                else if (chk_extra.Checked == false)
                {
                    double discount = Convert.ToDouble(txt_inv_extra2.Text);
                    Double Amount = Convert.ToDouble(txt_pro_price.Text) * Convert.ToInt32(txt_pro_quantati.Text);
                    Double totalAmount = Amount + discount;
                    txt_pro_total.Text = totalAmount.ToString();
                }
            }

            if (cmb_customer.SelectedIndex == 0)
            {
                txt_prid.Text = txt_inv_total1.Text;
                txt_remain.Text = Convert.ToString(00);
                //txt_prid.ReadOnly = true;
            }
            else
            {
                txt_prid.Text = txt_inv_total1.Text;
                txt_remain.Text = Convert.ToString(00);
            }

        }

        private void calculate()
        {
            //if (cmb_customer.SelectedIndex != 0)
            //{
            //    Double total = Convert.ToDouble(txt_pro_total.Text);
            //    Double prid = Convert.ToDouble(txt_remain.Text);
            //    Double remain = total - prid;
            //    txt_prid.Text = remain.ToString();
            //}
        }

        // اجراء للتحقق من النص اذا كان رقم او حرف
        private void only_numper_KeyPress(object sender, KeyPressEventArgs e)
        {
          

                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                {
                    e.Handled = true;
                }
            

        }


        // اجراء تعبئة القيمة الي الداتا قيرد فيو والتحقق منها
        private void txt_pro_quantati_KeyDown(object sender, KeyEventArgs e)
        {
                   
                if (e.KeyCode == Keys.Enter && txt_pro_quantati.Text != string.Empty)
                {
                if (rdo_sales.Checked == true)
                {
                    if (inv.VerifyQuantity(txt_pro_code.Text, Convert.ToInt32(txt_pro_quantati.Text)).Rows.Count < 1 || Convert.ToInt32(txt_pro_quantati.Text) == 0 || Convert.ToInt32(txt_pro_quantati.Text) < 0)
                    {
                        MessageBox.Show(" الكمية المدخلة غير موحودة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_pro_quantati.Clear();
                        return;

                    }
                    DataRow r = Dt.NewRow();

                    for (int i = 0; i < dgv_invoies.Rows.Count - 1; i++)
                    {
                        if (dgv_invoies.Rows[i].Cells[0].Value.ToString() == txt_pro_code.Text)
                        {
                            MessageBox.Show("هذا الصنف موجد مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    r[0] = txt_pro_code.Text;
                    r[1] = txt_pro_name.Text;
                    r[2] = txt_pro_unit.Text;
                    r[3] = txt_pro_price.Text;
                    r[4] = txt_pro_quantati.Text;
                    r[5] = txt_pro_total.Text;
                    r[6] = txt_pay.Text;
                    //Dt.Rows.Clear();
                    Dt.Rows.Add(r);
                    dgv_invoies.DataSource = Dt;


                    txt_inv_total1.Text = (from DataGridViewRow row in dgv_invoies.Rows
                                           where row.Cells[5].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    txt_total_cost.Text = (from DataGridViewRow row in dgv_invoies.Rows
                                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                Double total_profit = Convert.ToDouble(txt_inv_total1.Text) - Convert.ToDouble(txt_total_cost.Text);
                total_profit1.Text = Convert.ToString(total_profit);
                clearBox();
                }
                else /*if (rdo_sales.Checked == true)*/
                {
                    DataRow r = Dt.NewRow();

                    for (int i = 0; i < dgv_invoies.Rows.Count - 1; i++)
                    {
                        if (dgv_invoies.Rows[i].Cells[0].Value.ToString() == txt_pro_code.Text)
                        {
                            MessageBox.Show("هذا الصنف موجد مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    r[0] = txt_pro_code.Text;
                    r[1] = txt_pro_name.Text;
                    r[2] = txt_pro_unit.Text;
                    r[3] = txt_pro_price.Text;
                    r[4] = txt_pro_quantati.Text;
                    r[5] = txt_pro_total.Text;
                    r[6] = txt_pay.Text;
                    //Dt.Rows.Clear();
                    Dt.Rows.Add(r);
                    dgv_invoies.DataSource = Dt;


                    txt_inv_total1.Text = (from DataGridViewRow row in dgv_invoies.Rows
                                           where row.Cells[5].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                    txt_total_cost.Text = (from DataGridViewRow row in dgv_invoies.Rows
                                           where row.Cells[6].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                    Double total_profit = Convert.ToDouble(txt_inv_total1.Text) - Convert.ToDouble(txt_total_cost.Text);
                    total_profit1.Text = Convert.ToString(total_profit);
                    clearBox();
                }
            }// end  if enter
           

        }// end txt_pro_quntity

        // اجراء تفقيط الاجماليات

        private void txt_prid_TextChanged(object sender, EventArgs e)
        {
            

            //txt_prid_ar.Text = cn2a.ConvertNumbersToArabicAlphabet(txt_prid.Text);
            if (txt_prid.Text == string.Empty)
            {

                txt_prid.Text = Convert.ToString(0);
                txt_prid_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_prid.Text), "دينار", "درهم");
            }
            else
            {

                calculate();
                txt_prid_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_prid.Text), "دينار", "درهم");
            }

            if (txt_remain_ar.Text == string.Empty)
            {
                txt_remain_ar.Text = "صفر";
            }

            if (txt_inv_total1.Text != null)
            {
                double total = Convert.ToDouble(txt_inv_total1.Text);
            double prid = Convert.ToDouble(txt_prid.Text);
            Double remain = total - prid;
            txt_remain.Text = Convert.ToString( remain);
            }
        }

        /************************************ ازرار **********************************************************/




        private void txt_pro_quantati_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateAmount2();
        }

        private void chk_discount_OnChange(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void txt_inv_discount1_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void chk_extra_OnChange(object sender, EventArgs e)
        {
            CalculateAmount2();
        }

        private void txt_inv_extra2_TextChanged(object sender, EventArgs e)
        {

            CalculateAmount2();
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmb_customer.SelectedIndex == 0 )
            {
                txt_prid.Text = txt_inv_total1.Text;
                txt_remain.Text = Convert.ToString(00);
            }
        }

        private void uc_point_sales1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_inv_discount1_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }



        /*******************************************************************************************/

        private void clearBox()
        {
            txt_pro_code.Clear();
            txt_pro_name.Clear();
            txt_pro_price.Clear();
            txt_pro_quantati.Clear();
            txt_pro_total.Clear();
            txt_pro_unit.Clear();
        }

        private void txt_remain_TextChanged(object sender, EventArgs e)
        {
            if (txt_remain.Text == string.Empty)
            {

                txt_remain.Text = Convert.ToString(0);
                txt_remain_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_remain.Text), "دينار", "درهم");
            }
            else
            {
                txt_remain_ar.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txt_remain.Text), "دينار", "درهم");
            }

            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dgv_invoies.Rows.RemoveAt(dgv_invoies.CurrentRow.Index);
        }
    }
}
