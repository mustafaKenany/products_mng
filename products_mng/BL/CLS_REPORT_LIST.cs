using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace products_mng.BL
{
    class CLS_REPORT_LIST
    {
        public static int ReportFlag = 0;  //0= sales 1=Purchase 2=NetMoney, 3=PROFIT_COST

        public DataTable RPT_PRODUCTS_DTLS(int ID_PRODUCT, String BEGIN_DATE, String END_DATE,int ORDER_TYPE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter ("@ID_PRODUCT", SqlDbType.Int);
            param[0].Value = ID_PRODUCT;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar,50);
            param[2].Value = END_DATE;
            param[3] = new SqlParameter ("@ORDER_TYPE", SqlDbType.NVarChar, 50);
            param[3].Value = ORDER_TYPE;
            dt = dal.SelectData ("RPT_PRODUCTS_DTLS", param);
            dal.ConClose ();
            return dt;
        }

        public DataTable RPT_COUSTOMER_ALL_ORDER(int TYPE_OF_ORDER, String BEGIN_DATE, String END_DATE,int COUST_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = END_DATE;
            param[3] = new SqlParameter ("@COUST_ID", SqlDbType.Int);
            param[3].Value = COUST_ID;
            dt = dal.SelectData ("RPT_COUSTOMER_ALL_ORDER", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_USR_PAID_SPENT_MONEY(String BEGIN_DATE, String END_DATE, string SALES_MAN, string TYPE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar,50);
            param[0].Value = SALES_MAN;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = END_DATE;
            param[3] = new SqlParameter ("@TYPE", SqlDbType.NVarChar,50);
            param[3].Value = TYPE;
            dt = dal.SelectData ("RPT_USR_PAID_SPENT_MONEY", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_USR_SALES(int TYPE_OF_ORDER, String BEGIN_DATE, String END_DATE,string SALES_MAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = END_DATE;
            param[3] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar,50);
            param[3].Value = SALES_MAN;
            dt = dal.SelectData ("RPT_USR_SALES", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_ONE_ITEM_ONE_COUST(int TYPE_OF_ORDER, String BEGIN_DATE, String END_DATE,int COUST_ID, int ID_PRD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter ("@ORDER_TYPE", SqlDbType.Bit);
            param[0].Value = TYPE_OF_ORDER;
            param[1] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = BEGIN_DATE;
            param[2] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = END_DATE;
            param[3] = new SqlParameter ("@COUST_ID", SqlDbType.Int);
            param[3].Value = COUST_ID;
            param[4] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            param[4].Value = ID_PRD;
            dt = dal.SelectData ("RPT_ONE_ITEM_ONE_COUST", param);
            dal.ConClose ();
            return dt;

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

        public DataTable RPT_NETMONEY( String BEGIN_DATE, String END_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[0].Value = BEGIN_DATE;
            param[1] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = END_DATE;
            dt = dal.SelectData ("RPT_NETMONEY", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_COUST_WITH_ALL_RECIPT(int COUST_ID,String BEGIN_DATE, String END_DATE,string PAID_SPENT_TYPE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter ("@ID", SqlDbType.Int);
            param[0].Value = COUST_ID;
            param[2] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[2].Value = BEGIN_DATE;
            param[1] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = END_DATE;
            param[3] = new SqlParameter ("@PAID_SPENT_TYPE", SqlDbType.NVarChar, 50);
            param[3].Value = PAID_SPENT_TYPE;
            dt = dal.SelectData ("RPT_COUST_WITH_ALL_RECIPT", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_NETMONEY_WITH_USR(String BEGIN_DATE, String END_DATE,string SALES_MAN)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[0].Value = BEGIN_DATE;
            param[1] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = END_DATE;
            param[2] = new SqlParameter ("@SALES_MAN", SqlDbType.NVarChar, 50);
            param[2].Value = SALES_MAN;
            dt = dal.SelectData ("RPT_NETMONEY_WITH_USR", param);
            dal.ConClose ();
            return dt;

        }

        public DataTable RPT_CALC_PROFT_COST(String BEGIN_DATE, String END_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@BEGIN_DATE", SqlDbType.NVarChar, 50);
            param[0].Value = BEGIN_DATE;
            param[1] = new SqlParameter ("@END_DATE", SqlDbType.NVarChar, 50);
            param[1].Value = END_DATE;
            dt = dal.SelectData ("RPT_CALC_PROFT_COST", param);
            dal.ConClose ();
            return dt;

        }


    }
}
