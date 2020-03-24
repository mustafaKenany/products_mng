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
    public partial class FORM_MNG_COUSTOMERS : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        private static FORM_MNG_COUSTOMERS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MNG_COUSTOMERS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MNG_COUSTOMERS ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }
        public FORM_MNG_COUSTOMERS()
        {
            if (frm == null)
            {
                frm = this;
            }
            InitializeComponent ();
            this.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
        }

        private void textBox_COUST_FILTER_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = COUST.SEARCH_COUSTOMER (textBox_COUST_FILTER.Text);
            this.gridControl_COUSTOMERS.DataSource = dt;
        }

        private void button_EDIT_COUST_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                string ID_COUST = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_COUSTOMER"]).ToString ();
                string COUST_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["COUST_NAME"]).ToString ();
                string COUST_TEL = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["TEL"]).ToString ();
                string COUST_ADD = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ADDRESS"]).ToString ();
                string COUST_TYPE = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["COUST_TYPE"]).ToString ();
                FORM_COUSTOMERS FORM = new FORM_COUSTOMERS ();
                FORM.ID_COUST.Text = ID_COUST;
                FORM.textBox_COUST_NAME.Text = COUST_NAME;
                FORM.textBox_COUST_TEL.Text = COUST_TEL;
                FORM.textBox_COUST_ADD.Text = COUST_ADD;
                FORM.comboBox_COUST_TYPE.Text = COUST_TYPE;
                FORM.Text = "تحديث بيانات";
                FORM.groupBox1.Text = "بيانات الزبون";
                FORM.button_ADD_NEW_COUST.Text = "تحديث";
                FORM.stat = "update";
                FORM.ShowDialog ();

            }
        }

        private void button_DLT_COUST_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (MessageBox.Show ("هل  تريد حذف الزبون كافة متعلقاته", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    String ID_COUST = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_COUSTOMER"]).ToString ();
                    COUST.DELETE_COUSTOMER (ID_COUST);
                    MessageBox.Show ("تمت عملية الحذف", "حذف");
                    this.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
                }
            }
        }
    }
}
