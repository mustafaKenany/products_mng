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
    public partial class FORM_RPT_ITEMS : Form
    {
        BL.CLS_PRODUCTS PRD = new BL.CLS_PRODUCTS ();
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();
        public FORM_RPT_ITEMS()
        {
            InitializeComponent ();
        }

        private void button_ALLITEMS_Click(object sender, EventArgs e)
        {
            this.gridControl_ITEMS.DataSource = PRD.GET_ALL_PRODUCTS ();
        }

        private void button_ITEMALLSALES_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int PRD_ID = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_PRODUCT"]).ToString ());
                string PRDLABEL = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["LABEL_PRODUCT"]).ToString ();
                RPT.RPT_ITMSDTLS X = new RPT_ITMSDTLS ();
                var dt = new DataTable ();
                var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                var END_DATE = dateTimePicker_END_DATE.Text;
                X.xrLabel11.Text = BEGIN_DATE;
                X.xrLabel9.Text = END_DATE;
                dt = RPTCLS.RPT_PRODUCTS_DTLS (PRD_ID,BEGIN_DATE,END_DATE);
                if (dt.Rows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    X.DataSource = dt;
                    X.xrTableCell_PRDLABEL.Text = PRDLABEL;
                    X.ShowPreviewDialog ();
                    Cursor = Cursors.Arrow;
                }
                else
                {
                    MessageBox.Show ("لا توجد مبيعات لهذه المادة خلال هذه الفترة","Message");
                }


            }
        }
    }
}
