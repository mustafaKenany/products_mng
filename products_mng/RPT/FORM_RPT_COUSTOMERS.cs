using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace products_mng.RPT
{
    public partial class FORM_RPT_COUSTOMERS : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        BL.CLS_PRODUCTS PRD = new BL.CLS_PRODUCTS ();
        BL.CLS_REPORT_LIST rpt = new BL.CLS_REPORT_LIST ();
        public FORM_RPT_COUSTOMERS()
        {
            InitializeComponent ();
        }

        private void button_DISPLAY_DATA_Click(object sender, EventArgs e)
        {
            this.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
            this.gridControl_ITEMS.DataSource = PRD.GET_ALL_PRODUCTS ();
        }

        private void button_PRT_COUST_SALES_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                var END_DATE = dateTimePicker_END_DATE.Text;

                int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                string COUST_NAME = gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["COUST_NAME"]).ToString ();
                //طباعة كل مبيعات الزبون وبشكل تفصيلي
                RPT.RPT_ALL_INVOS_BETWEEN_DATES X = new RPT_ALL_INVOS_BETWEEN_DATES ();
                //X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                //X.xrLabel_ENDDATE.Text = END_DATE;
                //X.xrLabel_COUST_NAME.Text = COUST_NAME;
                DataTable dt = new DataTable ();
                dt = rpt.RPT_COUSTOMER_ALL_ORDER (0, BEGIN_DATE, END_DATE, ID_COUST);
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات لهذا الزبون خلال هذه الفترة المحددة", "Message");
                }
            }
        }

        private void button_COUST_ONE_ITEM_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                if (gridView_ITEMS.RowCount > 0)
                {
                    var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                    var END_DATE = dateTimePicker_END_DATE.Text;

                    int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                    int ID_PRD = Convert.ToInt16 (gridView_ITEMS.GetRowCellValue (gridView_ITEMS.FocusedRowHandle, gridView_ITEMS.Columns["ID_PRODUCT"]).ToString ());
                    string COUST_NAME = gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["COUST_NAME"]).ToString ();
                    string PRD_NAME = gridView_ITEMS.GetRowCellValue (gridView_ITEMS.FocusedRowHandle, gridView_ITEMS.Columns["LABEL_PRODUCT"]).ToString ();
                    //طباعة كل مبيعات الزبون وبشكل تفصيلي
                    RPT.RPT_ONE_ITEM_ONE_COUST X = new RPT_ONE_ITEM_ONE_COUST ();
                    X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                    X.xrLabel_ENDDATE.Text = END_DATE;
                    X.xrLabel_COUST_NAME.Text = COUST_NAME;
                    X.xrLabel_ITEM_NAME.Text = PRD_NAME;
                    DataTable dt = new DataTable ();
                    dt = rpt.RPT_ONE_ITEM_ONE_COUST (0, BEGIN_DATE, END_DATE, ID_COUST, ID_PRD);
                    if (dt.Rows.Count > 0)
                    {
                        X.DataSource = dt;
                        X.ShowPreviewDialog ();
                    }
                    else
                    {
                        MessageBox.Show ("لا توجد بيانات لهذه المادة خلال هذه الفترة المحددة مع هذا الزبون","Message");
                    }

                }
            }
        }

        private void button_COUST_ITEM_PURCHASE_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                if (gridView_ITEMS.RowCount > 0)
                {
                    var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                    var END_DATE = dateTimePicker_END_DATE.Text;

                    int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                    int ID_PRD = Convert.ToInt16 (gridView_ITEMS.GetRowCellValue (gridView_ITEMS.FocusedRowHandle, gridView_ITEMS.Columns["ID_PRODUCT"]).ToString ());
                    string COUST_NAME = gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["COUST_NAME"]).ToString ();
                    string PRD_NAME = gridView_ITEMS.GetRowCellValue (gridView_ITEMS.FocusedRowHandle, gridView_ITEMS.Columns["LABEL_PRODUCT"]).ToString ();
                    //طباعة كل مشتريات الزبون وبشكل تفصيلي
                    RPT.RPT_ONE_ITEM_ONE_COUST X = new RPT_ONE_ITEM_ONE_COUST ();
                    X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                    X.xrLabel_ENDDATE.Text = END_DATE;
                    X.xrLabel_title.Text = "تقرير مشتريات مادة محددة لزبون محدد خلال فترة محددة";
                    X.xrLabel_TOPPRICE.Text = "أعلى سعر شراء لهذه المادة";
                    X.xrLabel_LOWPRICE.Text = "أقل سعر شراء لهذه المادة";
                    X.xrLabel_QTYTOTAL.Text = "مجموع الكمية التي تم شرائها لهذه المادة";
                    X.xrLabel_COUST_NAME.Text = COUST_NAME;
                    X.xrLabel_ITEM_NAME.Text = PRD_NAME;
                    DataTable dt = new DataTable ();
                    dt = rpt.RPT_ONE_ITEM_ONE_COUST (1, BEGIN_DATE, END_DATE, ID_COUST, ID_PRD);
                    if (dt.Rows.Count > 0)
                    {
                        X.DataSource = dt;
                        X.ShowPreviewDialog ();
                    }
                    else
                    {
                        MessageBox.Show ("لا توجد بيانات لهذه المادة خلال هذه الفترة المحددة مع هذا الزبون", "Message");
                    }

                }
            }
        }

        private void button_RPT_COUST_PURCHASE_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                var END_DATE = dateTimePicker_END_DATE.Text;

                int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                string COUST_NAME = gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["COUST_NAME"]).ToString ();
                //طباعة كل مبيعات الزبون وبشكل تفصيلي
                RPT.RPT_ALL_INVOS_BETWEEN_DATES X = new RPT_ALL_INVOS_BETWEEN_DATES ();
                //X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                //X.xrLabel_ENDDATE.Text = END_DATE;
                //X.xrLabel_COUST_NAME.Text = COUST_NAME;
                //X.xrLabel_title.Text = "تقرير مشتريات تفصيلي لزبون محدد خلال فترة محددة";
                //X.xrTableCell28.Text = "مجموع المشتريات من هذا الزبون";
                //X.xrTableCell26.Text = "مجموع المبالغ الواصلة الى هذا الزبون";
                DataTable dt = new DataTable ();
                dt = rpt.RPT_COUSTOMER_ALL_ORDER (1, BEGIN_DATE, END_DATE, ID_COUST);
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات لهذا الزبون خلال هذه الفترة المحددة", "Message");
                }
            }
        }
    }
}
