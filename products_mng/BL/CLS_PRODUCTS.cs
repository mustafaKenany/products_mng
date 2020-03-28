using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace products_mng.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_CATEGORIES", null);
            dal.ConClose ();
            return dt;

        }

        public void ADD_PRODUCT( int ID_PRD, int ID_CAT, string BARCODE_PRODUCT, string LABEL, byte[] IMAGE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[5];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@BARCODE_PRODUCT", SqlDbType.NVarChar,50);
            PARAM[2] = new SqlParameter ("@LABEL", SqlDbType.NVarChar,50);
            PARAM[3] = new SqlParameter ("@IMAGE", SqlDbType.Image);
            PARAM[4] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[0].Value = ID_CAT;
            PARAM[1].Value = BARCODE_PRODUCT;
            PARAM[2].Value = LABEL;
            PARAM[3].Value = IMAGE;
            PARAM[4].Value = ID_PRD;
            dal.ExecuteCommand ("ADD_PRODUCT", PARAM);
            dal.ConClose ();

        }

        public DataTable VerfiyProductID(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("VerfiyProductID", param);
            dal.ConClose ();
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_PRODUCTS", null);
            dal.ConClose ();
            return dt;

        }

        public DataTable SEARCH_PRODUCT(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("SEARCH_PRODUCT", param);
            dal.ConClose ();
            return dt;
        }

        public void DELETE_PRODUCT(String ID_PRD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@ID", SqlDbType.NVarChar,50);
            PARAM[0].Value = ID_PRD;
            dal.ExecuteCommand ("DELETE_PRODUCT", PARAM);
            dal.ConClose ();

        }

        public DataTable GET_IMAGE_PRODUCTS(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("GET_IMAGE_PRODUCTS", param);
            dal.ConClose ();
            return dt;
        }

        public int GET_ID_PRODUCT()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_PRODUCT", null);
            if (dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ID = int.Parse(dt.Rows[i]["ID_PRODUCT"].ToString ());
                }
                ID = ID + 1;
            }
            dal.ConClose ();
            return ID;
        }

        public void UPDATE_PRODCUT(int ID_CAT, string BARCODE_PRODUCT, string LABEL, byte[] IMAGE,string ID_PRODCUT)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[5];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@BARCODE_PRODUCT", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@LABEL", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@IMAGE", SqlDbType.Image);
            PARAM[4] = new SqlParameter ("@ID_PRODUCT", SqlDbType.Int);
            PARAM[0].Value = ID_CAT;
            PARAM[1].Value = BARCODE_PRODUCT;
            PARAM[2].Value = LABEL;
            PARAM[3].Value = IMAGE;
            PARAM[4].Value = ID_PRODCUT;
            dal.ExecuteCommand ("UPDATE_PRODUCTS", PARAM);
            dal.ConClose ();

        }

        public void UPDATE_PRICE_STOCK(int ID_PRD, int STOCK, double PRICE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[3];
            PARAM[0] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@STOCK", SqlDbType.Float);
            PARAM[2] = new SqlParameter ("@PRICE", SqlDbType.Int);
           
            PARAM[0].Value = ID_PRD;
            PARAM[1].Value = STOCK;
            PARAM[2].Value = PRICE;
            dal.ExecuteCommand ("UPDATE_PRICE_STOCK", PARAM);
            dal.ConClose ();

        }

    }
}
