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

        public void ADD_PAID_SPENT_MONEY(int PAID_SPENT_ID, int COUST_ID, float THE_AMOUNT,DateTime DATE, String TYPE, String NOTS)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@PAID_SPENT_ID", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@COUST_ID", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@THE_AMOUNT", SqlDbType.Float);
            PARAM[3] = new SqlParameter ("@DATE", SqlDbType.Date);
            PARAM[4] = new SqlParameter ("@TYPE", SqlDbType.NVarChar,50);
            PARAM[5] = new SqlParameter ("@NOTS", SqlDbType.NVarChar,50);
            PARAM[0].Value = PAID_SPENT_ID;
            PARAM[1].Value = COUST_ID;
            PARAM[2].Value = THE_AMOUNT;
            PARAM[3].Value = DATE;
            PARAM[4].Value = TYPE;
            PARAM[5].Value = NOTS;
            dal.ExecuteCommand ("ADD_PAID_SPENT_MONEY", PARAM);
            dal.ConClose ();
        }

        public void ADD_PAID_SPENT_DETLS()
        {
            //DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            //dal.ConOpen ();
            //SqlParameter[] PARAM = new SqlParameter[7];
            //PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            //PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            //PARAM[2] = new SqlParameter ("@ORDER_NOTES", SqlDbType.NVarChar, 50);
            //PARAM[3] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            //PARAM[4] = new SqlParameter ("@PAID_OR_NOT", SqlDbType.Bit);
            //PARAM[5] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar, 50);
            //PARAM[6] = new SqlParameter ("@ORDER_DATE", SqlDbType.Date);
            //PARAM[0].Value = ID_ORDER;
            //PARAM[1].Value = ID_COUST;
            //PARAM[2].Value = ORDER_NOTES;
            //PARAM[3].Value = ORDER_TYPE;
            //PARAM[4].Value = PAID_OR_NOT;
            //PARAM[5].Value = SALES_MAN;
            //PARAM[6].Value = DateTime.Now.ToShortDateString ();
            //dal.ExecuteCommand ("ADD_ORDER", PARAM);
            //dal.ConClose ();
        }

    }
}
