using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace products_mng.BL
{
    class CLS_MONEYIES
    {
        public int GET_ID_PAID_SPENT()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_PAID_SPENT", null);
            if (dt.Rows.Count > 0)
            {
                ID = int.Parse (dt.Rows[0]["PAID_SPENT_ID"].ToString ());

            }
            dal.ConClose ();
            return ID;
        }

        public void ADD_PAID_SPENT_MONEY(int PAID_SPENT_ID, int COUST_ID, float THE_AMOUNT, DateTime DATE, String TYPE, String NOTS, string SALES_MAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[7];
            PARAM[0] = new SqlParameter ("@PAID_SPENT_ID", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@COUST_ID", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@THE_AMOUNT", SqlDbType.Float);
            PARAM[3] = new SqlParameter ("@DATE", SqlDbType.Date);
            PARAM[4] = new SqlParameter ("@TYPE", SqlDbType.NVarChar, 50);
            PARAM[5] = new SqlParameter ("@NOTS", SqlDbType.NVarChar, 50);
            PARAM[6] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar, 50);
            PARAM[0].Value = PAID_SPENT_ID;
            PARAM[1].Value = COUST_ID;
            PARAM[2].Value = THE_AMOUNT;
            PARAM[3].Value = DATE;
            PARAM[4].Value = TYPE;
            PARAM[5].Value = NOTS;
            PARAM[6].Value = SALES_MAN;
            dal.ExecuteCommand ("ADD_PAID_SPENT_MONEY", PARAM);
            dal.ConClose ();
        }

        public DataTable GET_ALL_PAID_SPENT_DOCS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_PAID_SPENT_DOCS", null);
            dal.ConClose ();
            return dt;
        }

        public DataTable GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES(String BEGIN_DATE, String END_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[0].Value = BEGIN_DATE;
            param[1] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = END_DATE;
            dt = dal.SelectData ("GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES", param);
            dal.ConClose ();
            return dt;

        }

        public void DLT_PAID_SPENT_DOCS(int ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@ID", SqlDbType.Int);
            PARAM[0].Value = ID;
            dal.ExecuteCommand ("DLT_PAID_SPENT_DOCS", PARAM);
            dal.ConClose ();

        }

    }
}
