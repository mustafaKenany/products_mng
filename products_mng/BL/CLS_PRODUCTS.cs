﻿using System;
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

        public void ADD_PRODUCT(int ID_PRD, int ID_CAT, string BARCODE_PRODUCT, string LABEL, byte[] IMAGE, DateTime EXPIRE_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@BARCODE_PRODUCT", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@LABEL", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@IMAGE", SqlDbType.Image);
            PARAM[4] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[5] = new SqlParameter ("@EXPIRE_DATE", SqlDbType.NVarChar, 50);
            PARAM[0].Value = ID_CAT;
            PARAM[1].Value = BARCODE_PRODUCT;
            PARAM[2].Value = LABEL;
            PARAM[3].Value = IMAGE;
            PARAM[4].Value = ID_PRD;
            PARAM[5].Value = EXPIRE_DATE;
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

        public DataTable GET_ALL_EXPIRE_PRODUTS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_EXPIRE_PRODUTS", null);
            dal.ConClose ();
            return dt;

        }

        public DataTable Select_Product_BY_Barcode(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("Select_Product_BY_Barcode", param);
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
            PARAM[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
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
            if (dt.Rows.Count > 0)
            {
                ID = int.Parse (dt.Rows[0]["ID_PRD"].ToString ());
            }
            dal.ConClose ();
            return ID;
        }

        public void UPDATE_PRODCUT(int ID_CAT, string BARCODE_PRODUCT, string LABEL, byte[] IMAGE, string ID_PRODCUT, DateTime EXPIRE_DATE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@BARCODE_PRODUCT", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@LABEL", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@IMAGE", SqlDbType.Image);
            PARAM[4] = new SqlParameter ("@ID_PRODUCT", SqlDbType.Int);
            PARAM[5] = new SqlParameter ("@EXPIRE_DATE", SqlDbType.Date);
            PARAM[0].Value = ID_CAT;
            PARAM[1].Value = BARCODE_PRODUCT;
            PARAM[2].Value = LABEL;
            PARAM[3].Value = IMAGE;
            PARAM[4].Value = ID_PRODCUT;
            PARAM[5].Value = EXPIRE_DATE;

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

        public void ModifyPrdBarcode(int ID_PRD, int BARCODE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@ID", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@barcode", SqlDbType.Float);

            PARAM[0].Value = ID_PRD;
            PARAM[1].Value = BARCODE;
            dal.ExecuteCommand ("ModifyPrdBarcode", PARAM);
            dal.ConClose ();

        }

        public void UPDATE_PRD_COSTS(int ID_PRD, double COST)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@COST", SqlDbType.Float);
            PARAM[0].Value = ID_PRD;
            PARAM[1].Value = COST;
            dal.ExecuteCommand ("UPDATE_PRD_COSTS", PARAM);
            dal.ConClose ();

        }

        public void ADD_PRD_Stock(int ID_PRD, float QTY)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@QTY_PROD", SqlDbType.Float);
            PARAM[0].Value = ID_PRD;
            PARAM[1].Value = QTY;
            dal.ExecuteCommand ("ADD_PRD_Stock", PARAM);
            dal.ConClose ();

        }

        public void UPDATE_PRD_Stock(int ID_PRD, float QTY)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@ID_PRD", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@QTY_PROD", SqlDbType.Float);
            PARAM[0].Value = ID_PRD;
            PARAM[1].Value = QTY * -1;
            dal.ExecuteCommand ("ADD_PRD_Stock", PARAM);
            dal.ConClose ();

        }


    }
}
