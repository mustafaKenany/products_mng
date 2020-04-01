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
    public partial class FORM_RPTITEMS : Form
    {
        BL.CLS_PRODUCTS PRD = new BL.CLS_PRODUCTS ();
        public FORM_RPTITEMS()
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
                int PRD_ID =Convert.ToInt16( gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_PRODUCT"]).ToString ());
                string PRDLABEL = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["LABEL_PRODUCT"]).ToString ();
                RPT.RPT_ITMSDTLS X = new RPT_ITMSDTLS ();
                X.DataSource = PRD.RPT_PRODUCTS_DTLS (PRD_ID);
                X.xrTableCell_PRDLABEL.Text = PRDLABEL;
                X.ShowPreviewDialog ();
                
                
            }
        }
    }
}
