using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sales_mangment.BL
{
    class CLS_Product
    {
        // اجراء لجلب كافة عناصر الوحدة من قاعدة البيانات
        public DataTable GET_ALL_UNITS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_UNIT", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر المنتجات من قاعدة البيانات
        public DataTable GET_ALL_PRODUCT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCT", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_ALL_CATEGORY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORY", null);
            DAL.close();
            return Dt;
        }

        /********************************* MAX ID ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_UNIT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_UNIT_ID", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_CAT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_CAT_ID", null);
            DAL.close();
            return Dt;
        }

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable GET_MAX_PRODUCT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_MAX_PRODUCT_ID", null);
            DAL.close();
            return Dt;
        }


        /******************************** ADD ******************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_PRODUCT(string pro_code, string pro_name,int pro_unit, int pro_category
                        , string pro_contry, string pro_company, Double pro_pay, Double pro_sale)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[0].Value = pro_code;

            param[1] = new SqlParameter("@pro_name", SqlDbType.VarChar, 50);
            param[1].Value = pro_name;

            param[2] = new SqlParameter("@pro_unit", SqlDbType.Int);
            param[2].Value = pro_unit;

            param[3] = new SqlParameter("@pro_category", SqlDbType.Int);
            param[3].Value = pro_category;

            param[4] = new SqlParameter("@pro_contry", SqlDbType.VarChar, 50);
            param[4].Value = pro_contry;

            param[5] = new SqlParameter("@pro_company", SqlDbType.VarChar, 50);
            param[5].Value = pro_company;

            param[6] = new SqlParameter("@pro_pay", SqlDbType.Float);
            param[6].Value = pro_pay;

            param[7] = new SqlParameter("@pro_sale", SqlDbType.Float);
            param[7].Value = pro_sale;

            DAL.ExcuteCommand("ADD_PRODUCT", param);
            DAL.close();

        }

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_CATEGORY(string cat_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cat_name", SqlDbType.NVarChar, 50);
            param[0].Value = cat_name;


            DAL.ExcuteCommand("ADD_CATEGORY", param);
            DAL.close();

        }

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_UNIT(string unit_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@unit_name", SqlDbType.NVarChar, 50);
            param[0].Value = unit_name;


            DAL.ExcuteCommand("ADD_UNIT", param);
            DAL.close();

        }

        /****************************** UPDATE ****************************************/

        public void UPDATE_PRODUCT(string pro_code, string pro_name, int pro_unit, int pro_category
                       , string pro_contry, string pro_company, Double pro_pay, Double pro_sale)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[0].Value = pro_code;

            param[1] = new SqlParameter("@pro_name", SqlDbType.VarChar, 50);
            param[1].Value = pro_name;

            param[2] = new SqlParameter("@pro_unit", SqlDbType.Int);
            param[2].Value = pro_unit;

            param[3] = new SqlParameter("@pro_category", SqlDbType.Int);
            param[3].Value = pro_category;

            param[4] = new SqlParameter("@pro_contry", SqlDbType.VarChar, 50);
            param[4].Value = pro_contry;

            param[5] = new SqlParameter("@pro_company", SqlDbType.VarChar, 50);
            param[5].Value = pro_company;

            param[6] = new SqlParameter("@pro_pay", SqlDbType.Float);
            param[6].Value = pro_pay;

            param[7] = new SqlParameter("@pro_sale", SqlDbType.Float);
            param[7].Value = pro_sale;

            DAL.ExcuteCommand("UPDATE_PRODUCT", param);
            DAL.close();

        }

        public void UPDATE_UNIT(string unit_name,int unit_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@unit_name", SqlDbType.NVarChar, 50);
            param[0].Value = unit_name;

            param[1] = new SqlParameter("@unit_id", SqlDbType.NVarChar, 50);
            param[1].Value = unit_id;


            DAL.ExcuteCommand("UPDATE_UNIT", param);
            DAL.close();

        }

        public void UPDATE_CATEGORY(string cat_name, int cat_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@cat_name", SqlDbType.NVarChar, 50);
            param[0].Value = cat_name;

            param[1] = new SqlParameter("@cat_id", SqlDbType.NVarChar, 50);
            param[1].Value = cat_id;


            DAL.ExcuteCommand("UPDATE_CATEGORY", param);
            DAL.close();

        }

        /******************************** DELETE****************************************/

        public void DELETE_UNIT( int unit_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@unit_id", SqlDbType.NVarChar, 50);
            param[0].Value = unit_id;


            DAL.ExcuteCommand("DELETE_UNIT", param);
            DAL.close();

        }

        public void DELETE_CATEGORY(int cat_id)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cat_id", SqlDbType.NVarChar, 50);
            param[0].Value = cat_id;


            DAL.ExcuteCommand("DELETE_CATEGORY", param);
            DAL.close();

        }

        public void DELETE_PRODUCT(int pro_code)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@pro_code", SqlDbType.NVarChar, 50);
            param[0].Value = pro_code;


            DAL.ExcuteCommand("DELETE_PRODUCT", param);
            DAL.close();

        }

        /******************************** SEARCH ****************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_PRODUCT(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_PRODUCT", param);
            DAL.close();
            return Dt;
        }

    }
}
