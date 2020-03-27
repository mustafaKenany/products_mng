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
    public partial class FORM_MNG_ORDERS : Form
    {
        private static FORM_MNG_ORDERS frm;
        BL.CLS_ORDERS ORD = new BL.CLS_ORDERS ();

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MNG_ORDERS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MNG_ORDERS ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }
        public FORM_MNG_ORDERS()
        {
            if (frm == null)
            {
                frm = this;
            }
            InitializeComponent ();
        }

        private void button_SHOW_ALL_ORD_Click(object sender, EventArgs e)
        {
            var ORDER_TYPES = BL.CLS_ORDERS.ORDER_TYPES;
            this.gridControl_ORDERS.DataSource = ORD.GET_ALL_ORDERS (ORDER_TYPES);
        }

        private void textBox_ORDER_FILTERS_TextChanged(object sender, EventArgs e)
        {
            var ORDER_TYPES = BL.CLS_ORDERS.ORDER_TYPES;
            DataTable dt = new DataTable ();
            dt = ORD.SEARCH_ORDER (ORDER_TYPES, textBox_ORDER_FILTERS.Text);
            this.gridControl_ORDERS.DataSource = dt;

        }

        private void button_ORDERS_DATE_Click(object sender, EventArgs e)
        {
            var ORDER_TYPES = BL.CLS_ORDERS.ORDER_TYPES;
            DataTable dt = new DataTable ();
            dt = ORD.SEARCH_ORDER_DATE (ORDER_TYPES, dateTimePicker_BEGIN_DATE.Text, dateTimePicker_END_DATE.Text);
            this.gridControl_ORDERS.DataSource = dt;

        }

        private void button_PRT_GRID_Click(object sender, EventArgs e)
        {
            printableComponentLink1.CreateDocument ();
            printableComponentLink1.ShowPreview ();

        }

        private void button_DLT_INVO_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                var ORDER_TYPES = BL.CLS_ORDERS.ORDER_TYPES;
                if (MessageBox.Show ("هل  تريد حذف الفاتورة؟؟؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    String ID_ORD = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_ORDER"]).ToString ();
                    ORD.DLT_ORDER (ORDER_TYPES, int.Parse (ID_ORD));
                    MessageBox.Show ("تمت عملية الحذف", "حذف");
                    this.gridControl_ORDERS.DataSource = ORD.GET_ALL_ORDERS (ORDER_TYPES);
                }
            }

        }

        private void button_PRT_INVO_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                var ORDER_TYPES = BL.CLS_ORDERS.ORDER_TYPES;
                int ID_ORD =int.Parse( gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_ORDER"]).ToString ());
                RPT.RPT_INVO x = new RPT.RPT_INVO ();
                x.DataSource = ORD.PRT_INVO_ORDER (ORDER_TYPES, ID_ORD);
                x.ShowPreviewDialog ();
                MessageBox.Show (ID_ORD.ToString ());

            }
        }
    }
}
