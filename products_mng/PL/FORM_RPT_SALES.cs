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
namespace products_mng.PL
{
    public partial class FORM_RPT_SALES : Form
    {
        BL.CLS_ORDERS ORD = new BL.CLS_ORDERS ();

        public FORM_RPT_SALES()
        {
            InitializeComponent ();
            BL.CLS_ORDERS.ORDER_TYPES = 0;

        }

        private void button_PRTGRID_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                printableComponentLink1.CreateDocument ();
                printableComponentLink1.ShowPreview ();
            }
        }

        private void button_ALSALES_Click(object sender, EventArgs e)
        {
            string BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            string END_DATE = dateTimePicker_ENDATE.Text;

            this.gridControl_ALLSALES.DataSource = ORD.SEARCH_ORDER_DATE (BL.CLS_ORDERS.ORDER_TYPES, BEGIN_DATE, END_DATE);
        }

        private void button_PRTINVO_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int ID_ORDER = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_ORDER"]).ToString ());
                RPT.RPT_INVO x = new RPT.RPT_INVO ();
                x.DataSource = ORD.PRT_INVO_ORDER (BL.CLS_ORDERS.ORDER_TYPES, ID_ORDER);
                x.ShowPreviewDialog ();
            }
        }

        private void button_INVOSDETLS_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                string END_DATE = dateTimePicker_ENDATE.Text;
                RPT.PRT_ALL_INVO x = new RPT.PRT_ALL_INVO ();
                x.DataSource = ORD.SEARCH_ORDER_DATE (BL.CLS_ORDERS.ORDER_TYPES, BEGIN_DATE, END_DATE);
                x.xrLabel_title.Text = "قوائم المبيعات للفترة";
                x.xrLabel_BEGINDATE.Text = dateTimePicker_BEGIN_DATE.Text;
                x.xrLabel_ENDDATE.Text = dateTimePicker_ENDATE.Text;
                x.ShowPreviewDialog ();
            }
        }
    }
}
