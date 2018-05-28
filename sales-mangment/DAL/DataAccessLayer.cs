using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sales_mangment.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        public DataAccessLayer()// دالة لربط الاتصال بقاعدة البيانات
        {
            sqlconnection = new SqlConnection("Server = ALIWA-PC,1433; DataBase = seles_db; Integrated Security = false; User ID = ba; Password = ba; ");
        }

        public void open()// دالة لفتح عملية الاتصال بقاعدة البيانات
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        public void close()// دالة للاغلاق عملية الاتصال بقاعدة البيانات
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        /*  
         * دالة للقراءة من قاعدة البيانات 
         *  تحتوي الدالة على اثنين بارميتر
         * البارميتر الاول يستقبل الاجراء المخزن 
         * البارميتر الثاني يحتوي على البارميترات الموجودة  في الاجراء المخزن
         */
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /*
         دالة للتعامل مع البيانات مثل اضافة حذف تعديل
         */
        public void ExcuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
