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
    public partial class FORM_SALES : Form
    {
        BL.CLS_SALES SLS = new BL.CLS_SALES ();
        BL.CLS_MNG_CAT CATEG = new BL.CLS_MNG_CAT ();
        BL.CLS_ADD_PRODUCTS PROD = new BL.CLS_ADD_PRODUCTS ();
        public FORM_SALES()
        {
            InitializeComponent ();
        }

        private void InitializeFunction()
        {
            this.label_ID_ORDER.Text = SLS.GET_ID_ORDER ().ToString ();
            button_NEW_INVO.Enabled = false;
        }

        private void SELECT_CATEGORIES()
        {
            var dt = new DataTable ();
            flowLayoutPanel_CATEGORIES.Controls.Clear ();
            dt = CATEG.GET_ALL_CATEGORIES ();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn_Item = new Button ();
                btn_Item.Name = dt.Rows[i][0].ToString ();
                btn_Item.Text = dt.Rows[i][1].ToString ();
                btn_Item.AutoSize = true;
                btn_Item.Height = 60;
                btn_Item.FlatStyle = FlatStyle.Flat;
                btn_Item.FlatAppearance.BorderSize = 2;
                btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb (220, 220, 220);
                btn_Item.ForeColor = Color.FromArgb (255, 255, 255);
                btn_Item.BackColor = Color.FromArgb (20, 158, 140);
                btn_Item.Cursor = Cursors.Hand;
                btn_Item.FlatAppearance.BorderColor = Color.FromArgb (37, 37, 38);
                btn_Item.Click += new EventHandler (SELECT_PRODUCTS);
                flowLayoutPanel_CATEGORIES.Controls.Add (btn_Item);

            }
        }

        private void SELECT_PRODUCTS(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            flowLayoutPanel_PRD.Controls.Clear ();
            var dt = new DataTable ();
            dt = PROD.SEARCH_PRODUCT (clickedbutton.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn_Item = new Button ();
                btn_Item.Name = dt.Rows[i]["LABEL_PRODUCT"].ToString ();
                btn_Item.Text = dt.Rows[i]["LABEL_PRODUCT"].ToString ();
                btn_Item.AutoSize = true;
                btn_Item.Height = 60;
                btn_Item.FlatStyle = FlatStyle.Flat;
                btn_Item.FlatAppearance.BorderSize = 2;
                btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb (220, 220, 220);
                btn_Item.ForeColor = Color.FromArgb (255, 255, 255);
                btn_Item.BackColor = Color.FromArgb (20, 158, 140);
                btn_Item.Cursor = Cursors.Hand;
                btn_Item.FlatAppearance.BorderColor = Color.FromArgb (37, 37, 38);
                btn_Item.Click += new EventHandler (SET_INVOICE_ITEMS);
                flowLayoutPanel_PRD.Controls.Add (btn_Item);
            }
        }

        private void SET_INVOICE_ITEMS(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            var dt = new DataTable ();
            int ITEM_PRICE;
            dt = PROD.SEARCH_PRODUCT (clickedbutton.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["PRICE"].ToString () == "")
                {
                    ITEM_PRICE = 0;
                }
                else
                {
                    ITEM_PRICE = int.Parse (dt.Rows[0]["PRICE"].ToString ());
                }

                if (CHECK_IF_DUPLICATE (clickedbutton.Text))
                {
                    int idx = dataGridView_INVO_ITEMS.Rows.Add ();
                    DataGridViewRow row = dataGridView_INVO_ITEMS.Rows[idx];
                    row.Cells["ITEM_NAME"].Value = clickedbutton.Text;//اسم مادة
                    row.Cells["ITEM_QTY"].Value = 1;//كمية المادة
                    row.Cells["ITEM_PRICE"].Value = ITEM_PRICE;  //سعر المادة
                    row.Cells["ITEM_TOTAL"].Value = ITEM_PRICE * 1;     //مجموع المادة

                }

            }
        }

        private bool CHECK_IF_DUPLICATE(string text)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_INVO_ITEMS.Rows.Count; i++)
                {
                    if (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_NAME"].Value.ToString () == text)
                    {
                        dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_QTY"].Value = double.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_QTY"].Value.ToString ()) + 1;
                        dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_TOTAL"].Value = double.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_QTY"].Value.ToString ()) * double.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_PRICE"].Value.ToString ());
                        return false;
                    }
                }

            }
            return true;
        }

        private void INVO_TOTAL_CALC()
        {
            double totalInvoice = 0;
            double FinalTotal = 0;
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_INVO_ITEMS.Rows.Count; i++)
                {
                    totalInvoice = totalInvoice + Convert.ToDouble (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_TOTAL"].Value.ToString ());
                    FinalTotal = totalInvoice;
                }
                label_INVO_TOTAL.Text = double.Parse (totalInvoice.ToString ()).ToString ("n2");

            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void FORM_SALES_Load(object sender, EventArgs e)
        {

        }

        private void button_NEW_INVO_Click(object sender, EventArgs e)
        {
            InitializeFunction ();
            SELECT_CATEGORIES ();
        }

        private void button_DLT_ITEM_Click(object sender, EventArgs e)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                dataGridView_INVO_ITEMS.Rows.RemoveAt (dataGridView_INVO_ITEMS.CurrentRow.Index);
                INVO_TOTAL_CALC ();
            }
            else
            {
                label_INVO_TOTAL.Text = 0.ToString ();
            }
        }

        private void dataGridView_INVO_ITEMS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (dataGridView_INVO_ITEMS.Columns[e.ColumnIndex].Name)
                {
                    case "ITEM_QTY":
                        var ITEM_QTY = double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_QTY"].Value.ToString ());
                        if (ITEM_QTY <= 0)
                        {
                            MessageBox.Show ("خطا في ادخال القيمة", "ITEM_QTY Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView_INVO_ITEMS.CurrentCell.Selected = true;
                            dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_QTY"].Value = 1;

                        }
                        else if (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value != null)
                        {
                            dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_TOTAL"].Value = double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_QTY"].Value.ToString ()) * double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value.ToString ());
                        }
                        break;

                    case "ITEM_PRICE":
                        var ITEM_PRICE = double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value.ToString ());

                        if (ITEM_PRICE <= 0)
                        {
                            MessageBox.Show ("خطا في ادخال القيمة", "ITEM_PRICE Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataGridView_INVO_ITEMS.CurrentCell.Selected = true;
                            dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value = 1;

                        }
                        else
                        {
                            dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_TOTAL"].Value = double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_QTY"].Value.ToString ()) * double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value.ToString ());
                        }
                        break;
                    case "ITEM_TOTAL":
                        dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_TOTAL"].Value = double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_QTY"].Value.ToString ()) * double.Parse (dataGridView_INVO_ITEMS.Rows[e.RowIndex].Cells["ITEM_PRICE"].Value.ToString ());
                        INVO_TOTAL_CALC ();
                        break;
                    default:
                        break;
                }

            }
        }

        private void button_PAID_INVO_Click(object sender, EventArgs e)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                textBox_INVO_DISC.Enabled = textBox_INVO_PAID.Enabled = true;
                textBox_INVO_PAID.Focus ();
                textBox_INVO_PAID.Text = label_INVO_TOTAL.Text;
                textBox_INVO_PAID.SelectAll ();
            }
        }

        private void dataGridView_INVO_ITEMS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler (Control_KeyPress);

        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress (e);
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar))
                e.Handled = true;
        }

        private void textBox_INVO_PAID_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                if (textBox_INVO_PAID.Text == "")
                {
                    label_INVO_REMID.Text = label_INVO_TOTAL.Text;
                }
                else
                {
                    label_INVO_REMID.Text = (double.Parse (label_INVO_TOTAL.Text) - double.Parse (textBox_INVO_PAID.Text) - double.Parse(textBox_INVO_DISC.Text)).ToString ();
                }

            }
        }

        private void textBox_INVO_DISC_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                if (textBox_INVO_DISC.Text == "" || textBox_INVO_DISC.Text == "0")
                {
                    label_INVO_REMID.Text = (double.Parse (label_INVO_TOTAL.Text) - double.Parse (textBox_INVO_PAID.Text)).ToString ();
                }
                else if (double.Parse (textBox_INVO_DISC.Text) == double.Parse (label_INVO_TOTAL.Text))
                {
                    label_INVO_REMID.Text = "0";
                    textBox_INVO_PAID.Text = "0";
                }
                else
                {
                    label_INVO_REMID.Text = (double.Parse (label_INVO_TOTAL.Text) - double.Parse (textBox_INVO_PAID.Text) - double.Parse (textBox_INVO_DISC.Text)).ToString ();

                }
            }
        }
    }
}
