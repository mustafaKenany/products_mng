using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace products_mng.PL
{
    public partial class FORM_MNG_PRODUCTS : Form
    {
        BL.CLS_PRODUCTS PRD = new BL.CLS_PRODUCTS ();
        private static FORM_MNG_PRODUCTS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MNG_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MNG_PRODUCTS ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }
        public FORM_MNG_PRODUCTS()
        {
            InitializeComponent ();
            if (frm == null)
            {
                frm = this;
            }
        }

        private void textBox_SEARCH_PRODUCT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = PRD.SEARCH_PRODUCT (textBox_SEARCH_PRODUCT.Text);
            this.GridControl_PRODUCTS.DataSource = dt;

        }

        private void button_ADD_NEW_PRODUCT_Click(object sender, EventArgs e)
        {
            this.GridControl_PRODUCTS.DataSource = null;
            PL.FORM_ADD_PRODUCTS FRM = new FORM_ADD_PRODUCTS ();
            FRM.ShowDialog ();
        }

        private void button_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (MessageBox.Show ("هل  تريد حذف المنتج", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    String ID_PRD = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_PRODUCT"]).ToString ();
                    PRD.DELETE_PRODUCT (ID_PRD);
                    MessageBox.Show ("تمت عملية الحذف", "حذف");
                    this.GridControl_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS ();
                }
            }

        }

        private void button_PRODUCT_MODIFY_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                FORM_ADD_PRODUCTS FRM = new FORM_ADD_PRODUCTS ();
                FRM.stat = "update";
                String ID_PRODUCT = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_PRODUCT"]).ToString ();
                FRM.ID_PRODUCT.Text = ID_PRODUCT;
                FRM.ID_PRODUCT.Enabled = false;
                var PRD_CAT = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["CAT_DESCRPTION"]).ToString ();
                FRM.comboBox_CATEGORIES.Text = PRD_CAT;
                var PRD_LABEL = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["LABEL_PRODUCT"]).ToString ();
                FRM.textBox_LABEL.Text = PRD_LABEL;
                var PRD_BARCODE = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["BARCODE_PRODUCT"]).ToString ();
                FRM.textBox_BARCODE.Text = PRD_BARCODE;
                FRM.textBox_BARCODE.Enabled = false;
                FRM.buttonBarcode.Visible = true;
                byte[] image = (byte[]) PRD.GET_IMAGE_PRODUCTS (ID_PRODUCT).Rows[0][0];
                MemoryStream ms = new MemoryStream (image);
                FRM.pictureBox_PRODUCTS.Image = Image.FromStream (ms);
                var EXPIRE_DATE = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["Expire_date"]);
                FRM.dateTimePicker_EXPIREDATE.Text = EXPIRE_DATE.ToString();

                FRM.Text = "تحديث بيانات";
                FRM.btn_SAVE_PRODUCT.Text = "تحديث";
                FRM.ShowDialog ();
            }
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_PRODUCT_PRICE_STOCK_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                for (int i = 0; i < this.gridView1.RowCount; i++)
                {
                    int ID_PRD = Convert.ToInt16 (gridView1.GetRowCellValue (i, gridView1.Columns["ID_PRODUCT"]).ToString ());
                    int PRD_STOCK = Convert.ToInt16 (gridView1.GetRowCellValue (i, gridView1.Columns["QTE_IN_STOCK"]).ToString ());
                    double PRD_PRICE = Convert.ToDouble (gridView1.GetRowCellValue (i, gridView1.Columns["PRICE"]).ToString ());
                    PRD.UPDATE_PRICE_STOCK (ID_PRD, PRD_STOCK, PRD_PRICE);
                }
                MessageBox.Show ("Update Success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button_PRINT_PRD_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                printableComponentLink1.CreateDocument ();
                printableComponentLink1.ShowPreview ();
            }
        }

        private void button_AllPrd_Click(object sender, EventArgs e)
        {
            this.GridControl_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS ();
        }

        private void GridControl_PRODUCTS_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress (e);
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void button_ModifyPRDCOSTS_Click(object sender, EventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                for (int i = 0; i < this.gridView1.RowCount; i++)
                {
                    int ID_PRD = Convert.ToInt16 (gridView1.GetRowCellValue (i, gridView1.Columns["ID_PRODUCT"]).ToString ());
                    Double PRD_COSTS = Convert.ToDouble (gridView1.GetRowCellValue (i, gridView1.Columns["PRD_COST"]).ToString ());
                    PRD.UPDATE_PRD_COSTS (ID_PRD, PRD_COSTS);
                }
                MessageBox.Show ("Update Success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_ExpireProducts_Click(object sender, EventArgs e)
        {
            this.GridControl_PRODUCTS.DataSource = PRD.GET_ALL_EXPIRE_PRODUTS ();
        }
    }
}
