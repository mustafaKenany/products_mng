using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_mng.PL
{
    public partial class FORM_MNG_PAID_SPENT_DOCS : Form
    {
        BL.CLS_MONEYIES MONEY = new BL.CLS_MONEYIES ();
        public FORM_MNG_PAID_SPENT_DOCS()
        {
            InitializeComponent ();
        }

        private void button_ALL_DOCS_Click(object sender, EventArgs e)
        {
            var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            var END_DATE = dateTimePicker_END_DATE.Text;
            DataTable dt = new DataTable ();
            dt = MONEY.GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES (BEGIN_DATE, END_DATE);
            this.gridControl_MNGPAIDSPENT.DataSource = dt;
        }

        private void button_DLTDOCS_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (MessageBox.Show ("هل  تريد حذف هذا المستند", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int ID =Convert.ToInt16( gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["PAID_SPENT_ID"]).ToString ());
                    MONEY.DLT_PAID_SPENT_DOCS (ID);
                    MessageBox.Show ("تمت عملية الحذف", "حذف");
                    var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                    var END_DATE = dateTimePicker_END_DATE.Text;
                    DataTable dt = new DataTable ();
                    dt = MONEY.GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES (BEGIN_DATE, END_DATE);
                    this.gridControl_MNGPAIDSPENT.DataSource = dt;
                }
            }

        }

        private void button_PRTALLDOCS_Click(object sender, EventArgs e)
        {

            if (gridView1.RowCount > 0)
            {

                printableComponentLink1.CreateDocument ();
                printableComponentLink1.ShowPreview ();

            }
        }

        private void button_PRTDOCS_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                RPT.RPT_PAID_SPENT x = new RPT.RPT_PAID_SPENT ();
                var DOC_TITLE = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["PAID_SPENT_TYPE"]).ToString ();
                var COUST_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["COUST_NAME"]).ToString ();
                var AMOUNT = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["THE_AMOUNT"]).ToString ();
                var NOTS = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["NOTS"]).ToString ();
                var DATE_DOC = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["PAID_SPENT_DATE"]).ToString ();
                var PAID_SPENT_ID = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["PAID_SPENT_ID"]).ToString ();
                

                x.xrLabelTITLE.Text = "مستند قبض";
                x.xrLabelDETLS.Text = " استلمت من السيد/السيدة " + COUST_NAME + "  مبلغ مالي مقداره  " + AMOUNT + "   وذلك عن  " + NOTS + "  ولأجله وقعت";
                x.xrLabel_date.Text = DATE_DOC;
                x.xrLabel_DOCSNO.Text = PAID_SPENT_ID;
                x.xrLabel_SLAESMAN.Text = BL.CLS_LOGIN.SALES_MAN;
                x.ShowPreviewDialog ();

            }
        }
    }
}
