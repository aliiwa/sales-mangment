using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sales_mangment.BL
{
    class CLS_users
    {
        // اجراء لجلب كافة عناصر المستخدمين
        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_USERS", null);
            DAL.close();
            return Dt;
        }


        public DataTable MAX_USER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("MAX_USER_ID", null);
            DAL.close();
            return Dt;
        }

        /************************************ الاضافة **********************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_USERS(int user_id, string full_name, string user_name, string password)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;

            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[3].Value = password;

            DAL.ExcuteCommand("ADD_USERS", param);
            DAL.close();

        }

        /************************************ تعديل ***********************************************/
        // اجراء التعديل البيانات لقاعدة البيانات
        public void UPDATE_USERS(int user_id, string full_name, string user_name, string password)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;

            param[3] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[3].Value = password;

            DAL.ExcuteCommand("UPDATE_USERS", param);
            DAL.close();

        }

        // اجراء التعديل البيانات لقاعدة البيانات
        public void UPDATE_USER_EX(int user_id, string full_name, string user_name)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[1].Value = full_name;

            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;



            DAL.ExcuteCommand("UPDATE_USER_EX", param);
            DAL.close();

        }
    }
}
