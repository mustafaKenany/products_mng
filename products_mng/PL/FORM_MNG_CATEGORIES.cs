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
    public partial class FORM_MNG_CATEGORIES : Form
    {
        BL.CLS_MNG_CAT CAT = new BL.CLS_MNG_CAT ();

        private static FORM_MNG_CATEGORIES frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MNG_CATEGORIES getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MNG_CATEGORIES ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }

        public FORM_MNG_CATEGORIES()
        {
            InitializeComponent ();
            if (frm == null)
            {
                frm = this;
            }
            this.gridControl_CAT.DataSource = CAT.GET_ALL_CATEGORIES ();
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_ADD_NEW_CAT_Click(object sender, EventArgs e)
        {
            if (textBox_Cat.Text!="")
            {
                CAT.ADD_NEW_CATEGORIES (textBox_Cat.Text);
                MessageBox.Show ("تمت عملية الحفظ بنجاح", "SAVE");
                textBox_Cat.Text = "";
                FORM_MNG_CATEGORIES.getMainForm.gridControl_CAT.DataSource = CAT.GET_ALL_CATEGORIES ();

            }
        }

        private void button_CANCEL_CAT_Click(object sender, EventArgs e)
        {
            textBox_Cat.Text = "";
        }

        private void button_CAT_MODIFY_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                for (int i = 0; i < this.gridView1.RowCount - 1; i++)
                {
                    int ID_CAT = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_CAT"]).ToString ());
                    string CAT_LABEL = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["CAT_DESCRPTION"]).ToString ();
                    CAT.UPDATE_CAT (ID_CAT, CAT_LABEL);
                }
                MessageBox.Show ("Update Success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_CAT_DLT_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (MessageBox.Show ("هل  تريد حذف الصنف وكافة المنتوجات", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    String ID_PRD = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_CAT"]).ToString ();
                    CAT.DELETE_CATEGORIES (ID_PRD);
                    MessageBox.Show ("تمت عملية الحذف", "حذف");
                    this.gridControl_CAT.DataSource = CAT.GET_ALL_CATEGORIES ();
                }
            }
        }

        private void button_PRINT_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {

                printableComponentLink1.CreateDocument ();
                printableComponentLink1.ShowPreview ();

            }
        }

        private void textBox_Cat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
