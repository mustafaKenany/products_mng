using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_mng.RPT
{
    public partial class FORM_RPT_PAID_SPENT_WITH_COUSTOMERS : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        BL.CLS_MONEYIES MONEY = new BL.CLS_MONEYIES ();
        public FORM_RPT_PAID_SPENT_WITH_COUSTOMERS()
        {
            InitializeComponent ();
        }

        private void button_DISPLAY_DATA_Click(object sender, EventArgs e)
        {
            var BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
            var END_DATE = dateTimePicker_END_DATE.Text;
            this.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
            this.gridControl_PAID_SPENT.DataSource = MONEY.GET_ALL_PAID_SPENT_DOCS_BETWEEN_DATES(BEGIN_DATE,END_DATE);
        }
    }
}
