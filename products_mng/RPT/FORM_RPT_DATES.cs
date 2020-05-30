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
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();
        public FORM_RPTDATE()
        {
            InitializeComponent ();
        }

        private void button_PRTDOCS_Click(object sender, EventArgs e)
        {
            string BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            string END_DATE = dateTimePicker_END_DATE.Text;
            DataTable DT = new DataTable ();
            switch (BL.CLS_REPORT_LIST.ReportFlag)
            {
                case 0:
                    RPT.PRT_ALL_INVO x = new RPT.PRT_ALL_INVO ();
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
                        MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                    }
                    break;
                case 1:
                    break;
                case 2:

                    RPT.RPT_NETMONEY rpt_netmoney = new RPT.RPT_NETMONEY ();
                    DT = RPTCLS.RPT_NETMONEY (BEGIN_DATE, END_DATE);
                    if (DT.Rows.Count > 0)
                    {
                        rpt_netmoney.DataSource = DT;
                        rpt_netmoney.xrLabel_BeginDate.Text = BEGIN_DATE;
                        rpt_netmoney.xrLabel_EndDate.Text = END_DATE;
                        rpt_netmoney.ShowPreviewDialog ();
                        this.Close ();
                    }
                    else
                    {
                        MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                    }
                    break;
                case 3:

                    RPT.RPT_CALC_PROFT_COST RPT_COST = new RPT.RPT_CALC_PROFT_COST ();
                    DT = RPTCLS.RPT_CALC_PROFT_COST (BEGIN_DATE, END_DATE);
                    if (DT.Rows.Count > 0)
                    {
                        RPT_COST.DataSource = DT;
                        RPT_COST.xrLabel_BEGIN_DATE.Text = BEGIN_DATE;
                        RPT_COST.xrLabel_END_DATE.Text = END_DATE;
                        RPT_COST.ShowPreviewDialog ();
                        this.Close ();
                    }
                    else
                    {
                        MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                    }
                    
                    break;
                default:
                    break;
            }

        }
    }
}
