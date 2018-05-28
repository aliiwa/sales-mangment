using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sales_mangment.BL
{
    class CLS_Supplay
    {
        // اجراء لجلب كافة عناصر الوحدة من قاعدة البيانات
        public DataTable GET_ALL_SUPPLAY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SUPPLAY", null);
            DAL.close();
            return Dt;
        }

        /********************************* MAX ID ***************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable MAX_SUPP_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MAX_SUPP_ID", null);
            DAL.close();
            return Dt;
        }

        /*************************************** ADD **************************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_SUPPLAY(string supp_code, string supp_name, int supp_phone,
                 string aupp_addrees/*, Boolean supp_status*/)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@supp_code", SqlDbType.NVarChar, 50);
            param[0].Value = supp_code;

            param[1] = new SqlParameter("@supp_name", SqlDbType.VarChar, 50);
            param[1].Value = supp_name;

            param[2] = new SqlParameter("@supp_phone", SqlDbType.Int);
            param[2].Value = supp_phone;

            param[3] = new SqlParameter("@aupp_addrees", SqlDbType.VarChar, 50);
            param[3].Value = aupp_addrees;

            //param[4] = new SqlParameter("@supp_status", SqlDbType.Bit);
            //param[4].Value = supp_status;

            



            DAL.ExcuteCommand("ADD_SUPPLAY", param);
            DAL.close();

        }


        /*************************************** UPDATE **************************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void UPDATE_SUPPLAY(string supp_code, string supp_name, int supp_phone,
                 string aupp_addrees/*, Boolean supp_status*/)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@supp_code", SqlDbType.NVarChar, 50);
            param[0].Value = supp_code;

            param[1] = new SqlParameter("@supp_name", SqlDbType.VarChar, 50);
            param[1].Value = supp_name;

            param[2] = new SqlParameter("@supp_phone", SqlDbType.Int);
            param[2].Value = supp_phone;

            param[3] = new SqlParameter("@aupp_addrees", SqlDbType.VarChar, 50);
            param[3].Value = aupp_addrees;

            //param[4] = new SqlParameter("@supp_status", SqlDbType.Bit);
            //param[4].Value = supp_status;





            DAL.ExcuteCommand("UPDATE_SUPPLAY", param);
            DAL.close();

        }

        /******************************** DELETE****************************************/

        public void DELETE_SUPPLAY(string supp_code)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@supp_code", SqlDbType.NVarChar, 50);
            param[0].Value = supp_code;


            DAL.ExcuteCommand("DELETE_SUPPLAY", param);
            DAL.close();

        }

        /******************************** SEARCH ****************************************/

        // اجراء لجلب كافة عناصر الاصناف من قاعدة البيانات
        public DataTable SEARCH_SUPPLAY(string txt_search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txt_search", SqlDbType.NVarChar, 50);
            param[0].Value = txt_search;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCH_SUPPLAY", param);
            DAL.close();
            return Dt;
        }
    }
}
