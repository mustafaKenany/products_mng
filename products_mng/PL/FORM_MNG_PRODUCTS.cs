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
        BL.CLS_ADD_PRODUCTS PRD = new BL.CLS_ADD_PRODUCTS ();
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
            this.dataGridView_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS ();
        }

        private void textBox_SEARCH_PRODUCT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = PRD.SEARCH_PRODUCT (textBox_SEARCH_PRODUCT.Text);
            this.dataGridView_PRODUCTS.DataSource = dt;
        }

        private void button_ADD_NEW_PRODUCT_Click(object sender, EventArgs e)
        {
            PL.FORM_ADD_PRODUCTS FRM = new FORM_ADD_PRODUCTS ();
            FRM.ShowDialog ();
        }

        private void button_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل  تريد حذف المنتج","حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                PRD.DELETE_PRODUCT (this.dataGridView_PRODUCTS.CurrentRow.Cells[0].Value.ToString ());
                MessageBox.Show ("تمت عملية الحذف", "حذف");
                this.dataGridView_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS ();
            }
        }

        private void button_PRODUCT_MODIFY_Click(object sender, EventArgs e)
        {
            FORM_ADD_PRODUCTS FRM = new FORM_ADD_PRODUCTS ();
            FRM.stat = "update";
            FRM.ID_PRODUCT.Text = this.dataGridView_PRODUCTS.CurrentRow.Cells["ID_PRODUCT"].Value.ToString ();
            FRM.ID_PRODUCT.Enabled = false;
            FRM.comboBox_CATEGORIES.Text = this.dataGridView_PRODUCTS.CurrentRow.Cells["CAT_DESCRPTION"].Value.ToString ();
            FRM.textBox_LABEL.Text = this.dataGridView_PRODUCTS.CurrentRow.Cells["LABEL_PRODUCT"].Value.ToString ();
            FRM.textBox_BARCODE.Text = this.dataGridView_PRODUCTS.CurrentRow.Cells["BARCODE_PRODCUT"].Value.ToString ();
            byte[] image = (byte[]) PRD.GET_IMAGE_PRODUCTS (this.dataGridView_PRODUCTS.CurrentRow.Cells["ID_PRODUCT"].Value.ToString ()).Rows[0][0];
            MemoryStream ms = new MemoryStream (image);
            FRM.pictureBox_PRODUCTS.Image = Image.FromStream (ms);
            FRM.Text = "تحديث بيانات";
            FRM.btn_SAVE_PRODUCT.Text = "تحديث";
            FRM.ShowDialog ();
          
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_REFRESH_Click(object sender, EventArgs e)
        {
            this.dataGridView_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS ();
        }

        private void button_PRODUCT_PRICE_STOCK_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_PRODUCTS.Rows.Count>0)
            {
                for (int i = 0; i < this.dataGridView_PRODUCTS.Rows.Count-1; i++)
                {
                    PRD.UPDATE_PRICE_STOCK (int.Parse(dataGridView_PRODUCTS.Rows[i].Cells["ID_PRODUCT"].Value.ToString ()), int.Parse (dataGridView_PRODUCTS.Rows[i].Cells["QTE_IN_STOCK"].Value.ToString ()), int.Parse (dataGridView_PRODUCTS.Rows[i].Cells["PRICE"].Value.ToString ()));
                }
                MessageBox.Show ("Update Success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
