using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace products_mng.BL
{
    class CLS_ORDERS
    {
        public static int ORDER_TYPES;

        public int GET_ID_ORDER()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 0;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_ORDER", null);
            if (dt.Rows.Count >0)
            {

                ID = int.Parse (dt.Rows[0]["ID_ORDER"].ToString ());
            }
            dal.ConClose ();
            return ID;
        }

        public int GET_ID_MONEYIES()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_MONEYIES", null);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ID = int.Parse (dt.Rows[i]["ID_MONEY"].ToString ());
                }
                ID = ID + 1;
            }
            dal.ConClose ();
            return ID;
        }

        public void ADD_ORDER(int ID_ORDER, int ID_COUST, string ORDER_NOTES, int ORDER_TYPE, int PAID_OR_NOT, String SALES_MAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[7];
            PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@ORDER_NOTES", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            PARAM[4] = new SqlParameter ("@PAID_OR_NOT", SqlDbType.Bit);
            PARAM[5] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar, 50);
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

        public void ADD_ORDER_MONEY(int ID_MONEY, int ID_ORDER, int ID_COUST, float TOTAL_AMOUNT, float PAID_AMOUNT, float DISCOUNT_AMOUNT, float REMINDER_AMOUNT)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[7];
            PARAM[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@TOTAL_AMOUNT", SqlDbType.Float);
            PARAM[3] = new SqlParameter ("@PAID_AMOUNT", SqlDbType.Float);
            PARAM[4] = new SqlParameter ("@DISCOUNT_AMOUNT", SqlDbType.Float);
            PARAM[5] = new SqlParameter ("@REMINDER_AMOUNT", SqlDbType.Float);
            PARAM[6] = new SqlParameter ("@ID_MONEYIES", SqlDbType.Int);
            PARAM[0].Value = ID_ORDER;
            PARAM[1].Value = ID_COUST;
            PARAM[2].Value = TOTAL_AMOUNT;
            PARAM[3].Value = PAID_AMOUNT;
            PARAM[4].Value = DISCOUNT_AMOUNT;
            PARAM[5].Value = REMINDER_AMOUNT;
            PARAM[6].Value = ID_MONEY;
            dal.ExecuteCommand ("ADD_ORDER_MONEY", PARAM);
            dal.ConClose ();

        }

        public void ADD_MONEY_DETAILS(int ID_MONEY, int ID_COUST, String TYPES_OF_MONEY, String NOTES, DateTime MONEY_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[5];
            PARAM[0] = new SqlParameter ("@ID_MONEY", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[2] = new SqlParameter ("@TYPES_OF_MONEY", SqlDbType.NVarChar, 250);
            PARAM[3] = new SqlParameter ("@NOTES", SqlDbType.NVarChar, 250);
            PARAM[4] = new SqlParameter ("@MONEY_DATE", SqlDbType.Date);
            PARAM[0].Value = ID_MONEY;
            PARAM[1].Value = ID_COUST;
            PARAM[2].Value = TYPES_OF_MONEY;
            PARAM[3].Value = NOTES;
            PARAM[4].Value = MONEY_DATE;
            dal.ExecuteCommand ("ADD_MONEY_DETAILS", PARAM);
            dal.ConClose ();

        }

        public DataTable GET_ALL_ORDERS(int TYPE_OF_ORDER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ORDER_TYPES", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            dt = dal.SelectData ("GET_ALL_ORDERS", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable SEARCH_ORDER(int TYPE_OF_ORDER, String ORDER_FILTER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@TYPE_OF_ORDER", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            param[1] = new SqlParameter ("@ORDER_FILTER", SqlDbType.NVarChar, 50);
            param[1].Value = ORDER_FILTER;
            dt = dal.SelectData ("SEARCH_ORDER", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable SEARCH_ORDER_DATE(int TYPE_OF_ORDER, String BEGIN_DATE, String END_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter ("@TYPE_OF_ORDER", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = END_DATE;
            dt = dal.SelectData ("SEARCH_ORDER_DATE", param);
            dal.ConClose ();
            return dt;

        }

        public void DLT_ORDER(int TYPE_OF_ORDER, int ID_ORDER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@TYPE_OF_ORDER", SqlDbType.Bit);
            PARAM[1] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            PARAM[0].Value = TYPE_OF_ORDER;
            PARAM[1].Value = ID_ORDER;
            dal.ExecuteCommand ("DLT_ORDER", PARAM);
            dal.ConClose ();

        }

        public DataTable PRT_INVO_ORDER(int ORDER_TYPES, int ID_ORDER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;
            param[1] = new SqlParameter ("@ORDER_TYPES", SqlDbType.Bit);
            param[1].Value = ORDER_TYPES;
            dt = dal.SelectData ("PRT_INVO_ORDER", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable PRT_ALL_INVO(int COUST_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@COUST_ID", SqlDbType.Int);
            param[0].Value = COUST_ID;
            dt = dal.SelectData ("PRT_ALL_INVO", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_ITMS_DTLS(int ID_PRODUCT)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID_PRODUCT", SqlDbType.Int);
            param[0].Value = ID_PRODUCT;
            dt = dal.SelectData ("RPT_ITMS_DTLS", param);
            dal.ConClose ();
            return dt;

        }

    }
}
