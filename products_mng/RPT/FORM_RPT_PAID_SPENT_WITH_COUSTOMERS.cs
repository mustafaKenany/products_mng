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
    public partial class FORM_RPT_PAID_SPENT_WITH_COUSTOMERS : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        BL.CLS_MONEYIES MONEY = new BL.CLS_MONEYIES ();
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();
        RPT.RPT_COUST_WITH_ALL_RECIPT RPT = new RPT_COUST_WITH_ALL_RECIPT ();

        String BEGIN_DATE, END_DATE, Paid_Spent_Type;
        DataTable DT = new DataTable ();
        public FORM_RPT_PAID_SPENT_WITH_COUSTOMERS()
        {
            InitializeComponent ();
        }

        private void button_DISPLAY_DATA_Click(object sender, EventArgs e)
        {
            BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            END_DATE = dateTimePicker_END_DATE.Text;
            this.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
            this.gridControl_PAID_SPENT.DataSource = MONEY.GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES (BEGIN_DATE, END_DATE);
        }

        private void button_COUST_WITH_ALL_DAILY_SPENT_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                Paid_Spent_Type = "صرفيات يومية";
                int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                DT = RPTCLS.RPT_COUST_WITH_ALL_RECIPT (ID_COUST, BEGIN_DATE, END_DATE, Paid_Spent_Type);
                RPT.xrLabel1.Text = "تقرير بكافة الصرفيات اليومية خلال فترة المحددة";
                RPT.xrLabel4.Text = BEGIN_DATE;
                RPT.xrLabel5.Text = END_DATE;
                if (DT.Rows.Count > 0)
                {
                    RPT.DataSource = DT;
                    RPT.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد صرفيات يومية خلال الفترة المحددة", "Message");
                }
            }   
        }

        private void button_COUST_WITH_ALL_SPENT_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                Paid_Spent_Type = "سندات صرف";
                int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                DT = RPTCLS.RPT_COUST_WITH_ALL_RECIPT (ID_COUST, BEGIN_DATE, END_DATE, Paid_Spent_Type);
                RPT.xrLabel1.Text = "تقرير بكافة سندات الصرف الخاصة بالزبون خلال فترة المحددة";
                RPT.xrLabel4.Text = BEGIN_DATE;
                RPT.xrLabel5.Text = END_DATE;
                if (DT.Rows.Count > 0)
                {
                    RPT.DataSource = DT;
                    RPT.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مستندات صرف لهذا الزبون خلال الفترة المحددة", "Message");
                }
            }
        }

        private void button_PRT_COUST_WITH_ALL_RECIPT_Click(object sender, EventArgs e)
        {
            if (gridView_COUST.RowCount > 0)
            {
                Paid_Spent_Type = "سندات قبض";
                int ID_COUST = Convert.ToInt16 (gridView_COUST.GetRowCellValue (gridView_COUST.FocusedRowHandle, gridView_COUST.Columns["ID_COUSTOMER"]).ToString ());
                DT = RPTCLS.RPT_COUST_WITH_ALL_RECIPT (ID_COUST, BEGIN_DATE, END_DATE, Paid_Spent_Type);
                RPT.xrLabel1.Text = "تقرير بكافة سندات القبض الخاصة بالزبون خلال فترة المحددة";
                RPT.xrLabel4.Text = BEGIN_DATE;
                RPT.xrLabel5.Text = END_DATE;
                if (DT.Rows.Count > 0)
                {
                    RPT.DataSource = DT;
                    RPT.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مستندات قبض لهذا الزبون خلال الفترة المحددة", "Message");
                }
            }

        }

        
        
    }
}
