using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace products_mng.BL
{
    class CLS_SALES
    {
        public int GET_ID_ORDER()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_ORDER", null);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ID = int.Parse (dt.Rows[i]["ID_ORDER"].ToString ());
                }
                ID = ID + 1;
            }
            dal.ConClose ();
            return ID;
        }

        public void ADD_ORDER(int ID_ORDER, int ID_COUST, string ORDER_NOTES, int ORDER_TYPE, int PAID_OR_NOT , String SALES_MAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[7];
            PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@ORDER_NOTES", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            PARAM[4] = new SqlParameter ("@PAID_OR_NOT", SqlDbType.Bit);
            PARAM[5] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar,50);
            PARAM[6] = new SqlParameter ("@ORDER_DATE", SqlDbType.Date);
            PARAM[0].Value = ID_ORDER;
            PARAM[1].Value = ID_COUST;
            PARAM[2].Value = ORDER_NOTES;
            PARAM[3].Value = ORDER_TYPE;
            PARAM[4].Value = PAID_OR_NOT;
            PARAM[5].Value = SALES_MAN;
            PARAM[6].Value = DateTime.Now.ToShortDateString ();
            dal.ExecuteCommand ("ADD_ORDER", PARAM);
            dal.ConClose ();

        }


        public void ADD_ORDER_DETAILS(int ID_ORDER, int ID_PRD, float PRD_QTY, float QTY_BY_PRICE, float PRD_PRICE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[5];
            PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@PRD_QTY", SqlDbType.Float);
            PARAM[3] = new SqlParameter ("@QTY_BY_PRICE", SqlDbType.Float);
            PARAM[4] = new SqlParameter ("@PRD_PRICE", SqlDbType.Float);
            PARAM[0].Value = ID_ORDER;
            PARAM[1].Value = ID_PRD;
            PARAM[2].Value = PRD_QTY;
            PARAM[3].Value = QTY_BY_PRICE;
            PARAM[4].Value = PRD_PRICE;
            dal.ExecuteCommand ("ADD_ORDER_DETAILS", PARAM);
            dal.ConClose ();

        }

        public void ADD_ORDER_MONEY(int ID_ORDER, int ID_COUST, float TOTAL_AMOUNT, float PAID_AMOUNT, float DISCOUNT_AMOUNT,float REMINDER_AMOUNT)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@TOTAL_AMOUNT", SqlDbType.Float);
            PARAM[3] = new SqlParameter ("@PAID_AMOUNT", SqlDbType.Float);
            PARAM[4] = new SqlParameter ("@DISCOUNT_AMOUNT", SqlDbType.Float);
            PARAM[5] = new SqlParameter ("@REMINDER_AMOUNT", SqlDbType.Float);
            PARAM[0].Value = ID_ORDER;
            PARAM[1].Value = ID_COUST;
            PARAM[2].Value = TOTAL_AMOUNT;
            PARAM[3].Value = PAID_AMOUNT;
            PARAM[4].Value = DISCOUNT_AMOUNT;
            PARAM[5].Value = REMINDER_AMOUNT;
            dal.ExecuteCommand ("ADD_ORDER_MONEY", PARAM);
            dal.ConClose ();

        }

    }
}
