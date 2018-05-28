using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sales_mangment.BL
{
    class CLS_Customer
    {
        // اجراء لجلب كافة عناصر الوحدة من قاعدة البيانات
        public DataTable GET_ALL_CUSTOMER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMER", null);
            DAL.close();
            return Dt;
        }

        /********************************* MAX ID ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_CUSTOMER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_CUSTOMER_ID", null);
            DAL.close();
            return Dt;
        }

        /*************************************** ADD **************************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_CUSTOMER(string cust_code, string cust_name, int cust_phone,
                 string cust_addrees)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@cust_code", SqlDbType.NVarChar, 50);
            param[0].Value = cust_code;

            param[1] = new SqlParameter("@cust_name", SqlDbType.VarChar, 50);
            param[1].Value = cust_name;

            param[2] = new SqlParameter("@cust_phone", SqlDbType.Int);
            param[2].Value = cust_phone;

            param[3] = new SqlParameter("@cust_addrees", SqlDbType.VarChar, 50);
            param[3].Value = cust_addrees;





            DAL.ExcuteCommand("ADD_CUSTOMER", param);
            DAL.close();

        }


        /*************************************** UPDATE **************************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void UPDATE_CUSTOMER(string cust_code, string cust_name, int cust_phone,
                  string cust_addrees/*, Boolean cust_status*/)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@cust_code", SqlDbType.NVarChar, 50);
            param[0].Value = cust_code;

            param[1] = new SqlParameter("@cust_name", SqlDbType.VarChar, 50);
            param[1].Value = cust_name;

            param[2] = new SqlParameter("@cust_phone", SqlDbType.Int);
            param[2].Value = cust_phone;

            param[3] = new SqlParameter("@cust_addrees", SqlDbType.VarChar, 50);
            param[3].Value = cust_addrees;

            //param[4] = new SqlParameter("@cust_status", SqlDbType.Bit);
            //param[4].Value = cust_status;


            DAL.ExcuteCommand("UPDATE_CUSTOMER", param);
            DAL.close();

        }

        /******************************** DELETE****************************************/

        public void DELETE_CUSTOMER(string cust_code)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cust_code", SqlDbType.NVarChar, 50);
            param[0].Value = cust_code;


            DAL.ExcuteCommand("DELETE_CUSTOMER", param);
            DAL.close();

        }


        /******************************** SEARCH ****************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_CUSTOMER(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_CUSTOMER", param);
            DAL.close();
            return Dt;
        }
    }
}
