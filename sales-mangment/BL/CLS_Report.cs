﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sales_mangment.BL
{
    class CLS_Report
    {
        /******************************* الارصدة *******************************************/

        // اجراء لاضافة البيانات لقاعدة البيانات
        public void ADD_PALANCE(DateTime date)

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            DAL.ExcuteCommand("ADD_PALANCE", param);
            DAL.close();

        }

        // اجراء لجلب كافة عناصر المنتجات من قاعدة البيانات
        public DataTable GET_ALL_PALANCE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PALANCE", null);
            DAL.close();
            return Dt;
        }

        //// اجراء البحث عن الارصدة
        //public DataTable GET_ALL_PALANCE(DateTime date)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DataTable Dt = new DataTable();

        //    SqlParameter[] param = new SqlParameter[1];

        //    param[0] = new SqlParameter("@date", SqlDbType.DateTime);
        //    param[0].Value = date;

        //    Dt = DAL.SelectData("SERACH_FIRST_QTY", param);
        //    DAL.close();
        //    return Dt;
        //}


    }
}