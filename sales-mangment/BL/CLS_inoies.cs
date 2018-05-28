using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sales_mangment.BL
{
    class CLS_inoies
    {

        /********************************* GET ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_ONE_PRODUCT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ONE_PRODUCT", null);
            DAL.close();
            return Dt;
        }

        /********************************* MAX ID ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_INVOIES_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_INVOIES_ID", null);
            DAL.close();
            return Dt;
        }



        /******************************** ADD ******************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_INVOIES(string sales_code, DateTime sales_date, Double sales_discount, Double sales_exstra
                        , int cust_id, Double total_invoes, Double pro_sale, Double sales_type,Double total_cost, Double total_profit)

        {
            /*, Double pro_pay, Double pro_sale*/
            /*, int cust_id*/
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@sales_code", SqlDbType.NVarChar, 50);
            param[0].Value = sales_code;

            param[1] = new SqlParameter("@sales_date", SqlDbType.DateTime);
            param[1].Value = sales_date;

            param[2] = new SqlParameter("@sales_discount", SqlDbType.Float);
            param[2].Value = sales_discount;

            param[3] = new SqlParameter("@sales_exstra", SqlDbType.Float);
            param[3].Value = sales_exstra;

            param[4] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[4].Value = cust_id;

            param[5] = new SqlParameter("@total_invoes", SqlDbType.Float);
            param[5].Value = total_invoes;

            param[6] = new SqlParameter("@total_cost", SqlDbType.Float);
            param[6].Value = total_cost;

            param[7] = new SqlParameter("@total_profit", SqlDbType.Float);
            param[7].Value = total_profit;



            param[8] = new SqlParameter("@pro_sale", SqlDbType.Float);
            param[8].Value = pro_sale;

            param[9] = new SqlParameter("@sales_type", SqlDbType.Float);
            param[9].Value = sales_type;

            DAL.ExcuteCommand("ADD_INVOIES", param);
            DAL.close();

        }


        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_INOIES_DETEALS(string sales_code, string pro_code, string pro_name, string pro_unit
                        , Double pro_sale, int pro_quntity,Double inv_total)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@sales_code", SqlDbType.NVarChar, 50);
            param[0].Value = sales_code;

            param[1] = new SqlParameter("@pro_code", SqlDbType.NVarChar,50);
            param[1].Value = pro_code;

            param[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar,50);
            param[2].Value = pro_name;

            param[3] = new SqlParameter("@pro_unit", SqlDbType.NVarChar,50);
            param[3].Value = pro_unit;

            param[4] = new SqlParameter("@pro_sale", SqlDbType.Float);
            param[4].Value = pro_sale;

            param[5] = new SqlParameter("@pro_quntity", SqlDbType.Int);
            param[5].Value = pro_quntity;

            param[6] = new SqlParameter("@inv_total", SqlDbType.Float);
            param[6].Value = inv_total;

            DAL.ExcuteCommand("ADD_INOIES_DETEALS", param);
            DAL.close();

        }

        public void ADD_INOIES_DETEALS2(string sales_code, string pro_code, string pro_name, string pro_unit
                        , Double pro_sale, int pro_quntity, Double inv_total)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@sales_code", SqlDbType.NVarChar, 50);
            param[0].Value = sales_code;

            param[1] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[1].Value = pro_code;

            param[2] = new SqlParameter("@pro_name", SqlDbType.NVarChar, 50);
            param[2].Value = pro_name;

            param[3] = new SqlParameter("@pro_unit", SqlDbType.NVarChar, 50);
            param[3].Value = pro_unit;

            param[4] = new SqlParameter("@pro_sale", SqlDbType.Float);
            param[4].Value = pro_sale;

            param[5] = new SqlParameter("@pro_quntity", SqlDbType.Int);
            param[5].Value = pro_quntity;

            param[6] = new SqlParameter("@inv_total", SqlDbType.Float);
            param[6].Value = inv_total;

            DAL.ExcuteCommand("ADD_INOIES_DETEALS2", param);
            DAL.close();

        }

        /******************************** Verify ******************************************/



        // اجراء التاكد من الكمية  
        public DataTable VerifyQuantity(string pro_code, int quantity_entered)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[0].Value = pro_code;

            param[1] = new SqlParameter("@quantity_entered", SqlDbType.Int);
            param[1].Value = quantity_entered;

            Dt = DAL.SelectData("VerifyQuantity", param);

            DAL.close();
            return Dt;
        }

        /******************************** SEARCH ****************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_QUICK_LIST(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_QUICK_LIST", param);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_INVOIES_NO(string text_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_search", SqlDbType.NVarChar, 50);
            param[0].Value = text_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_INVOIES_NO", param);
            DAL.close();
            return Dt;
        }


    }
}
