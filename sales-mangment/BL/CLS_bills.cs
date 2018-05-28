using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sales_mangment.BL
{
    class CLS_bills
    {


        /********************************* GET ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_ALL_CUSTOMER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMER", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_ALL_SUPPLAY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUPPLAY", null);
            DAL.close();
            return Dt;
        }

        /********************************* SEARCH ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_CUSTOMER_(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_CUSTOMER_", param);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_SUPPLAY_(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_SUPPLAY_", param);
            DAL.close();
            return Dt;
        }

        /********************************* MAX ID ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_BILLS2()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_BILLS2", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_BILLS1()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_BILLS1", null);
            DAL.close();
            return Dt;
        }

        /******************************** ADD ******************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_BILLS_2(string bills_no, DateTime bills_date, Double bills_amount, string bills_amount_ar
                        , string bills_descrption, int cust_id, string cust_name)

        {
            
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@bills_no", SqlDbType.NVarChar, 50);
            param[0].Value = bills_no;

            param[1] = new SqlParameter("@bills_date", SqlDbType.DateTime);
            param[1].Value = bills_date;

            param[2] = new SqlParameter("@bills_amount", SqlDbType.Float);
            param[2].Value = bills_amount;

            param[3] = new SqlParameter("@bills_amount_ar", SqlDbType.NVarChar,50);
            param[3].Value = bills_amount_ar;

            param[4] = new SqlParameter("@bills_descrption", SqlDbType.NVarChar,50);
            param[4].Value = bills_descrption;

            param[5] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[5].Value = cust_id;

            param[6] = new SqlParameter("@cust_name", SqlDbType.NVarChar,50);
            param[6].Value = cust_name;

            DAL.ExcuteCommand("ADD_BILLS_2", param);
            DAL.close();

        }

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_BILLS_1(string bills_no, DateTime bills_date, Double bills_amount, string bills_amount_ar
                        , string bills_descrption, int cust_id, string cust_name)

        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@bills_no", SqlDbType.NVarChar, 50);
            param[0].Value = bills_no;

            param[1] = new SqlParameter("@bills_date", SqlDbType.DateTime);
            param[1].Value = bills_date;

            param[2] = new SqlParameter("@bills_amount", SqlDbType.Float);
            param[2].Value = bills_amount;

            param[3] = new SqlParameter("@bills_amount_ar", SqlDbType.NVarChar, 50);
            param[3].Value = bills_amount_ar;

            param[4] = new SqlParameter("@bills_descrption", SqlDbType.NVarChar, 50);
            param[4].Value = bills_descrption;

            param[5] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[5].Value = cust_id;

            param[6] = new SqlParameter("@cust_name", SqlDbType.NVarChar, 50);
            param[6].Value = cust_name;

            DAL.ExcuteCommand("ADD_BILLS_1", param);
            DAL.close();

        }

    }
}
