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
    public partial class FORM_COUSTOMERS_SELECT : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();

        public FORM_COUSTOMERS_SELECT()
        {
            InitializeComponent ();
            COUST.GET_ALL_COUSTOMERS ();
            textBox_COUST_FILTER.Focus ();
        }

        private void textBox_COUST_FILTER_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = COUST.SEARCH_COUSTOMER (textBox_COUST_FILTER.Text);
            this.gridControl_COUSTOMERS.DataSource = dt;
        }

        private void button_NEW_INVO_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                string ID_COUST = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_COUSTOMER"]).ToString ();
                string COUST_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["COUST_NAME"]).ToString ();
                FORM_SALES.getMainForm.textBox_COUST_NAME.Text = COUST_NAME;
                FORM_SALES.getMainForm.label_COUST_ID.Text = ID_COUST;
                this.Close ();                
            }
        }
    }
}
