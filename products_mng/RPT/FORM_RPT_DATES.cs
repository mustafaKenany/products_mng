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
    public partial class FORM_RPTDATE : Form
    {
        BL.CLS_ORDERS ORD = new BL.CLS_ORDERS ();
        public FORM_RPTDATE()
        {
            InitializeComponent ();
        }

        private void button_PRTDOCS_Click(object sender, EventArgs e)
        {
            string BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            string END_DATE = dateTimePicker_END_DATE.Text;
            RPT.PRT_ALL_INVO x = new RPT.PRT_ALL_INVO ();
            DataTable DT = new DataTable ();
            DT = ORD.SEARCH_ORDER_DATE (BL.CLS_ORDERS.ORDER_TYPES, BEGIN_DATE, END_DATE);
            if (DT.Rows.Count > 0)
            {
                x.DataSource = DT;
                x.xrLabel_title.Text = "قوائم المبيعات للفترة";
                x.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                x.xrLabel_ENDDATE.Text = END_DATE;
                x.ShowPreviewDialog ();
                this.Close ();
            }
            else
            {
                MessageBox.Show ("لا توجد بيانات");
            }
        }
    }
}
