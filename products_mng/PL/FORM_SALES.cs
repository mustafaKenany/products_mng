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
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        int ID_ORDER = 0;
        int ID_COUST = 0;
        int ORDER_TYPE = 0;
        int PAID_OR_NOT = 0;
        String SALES_MAN = "";
        public FORM_SALES()
        {
            InitializeComponent ();
            label_SALES_MAN.Text = BL.CLS_LOGIN.SALES_MAN;
            var dt = new DataTable ();
            dt = COUST.SEARCH_COUSTOMER (1.ToString ());
            if (dt.Rows.Count > 0)
            {
                textBox_COUST_NAME.Text = dt.Rows[0]["COUST_NAME"].ToString ();
                label_COUST_ID.Text = dt.Rows[0]["ID_COUSTOMER"].ToString ();
            }

        }

        #region FUNCTIONS

        private void InitializeFunction()
        {
            this.label_ID_ORDER.Text = SLS.GET_ID_ORDER ().ToString ();
            ID_ORDER = int.Parse (label_ID_ORDER.Text);
            ID_COUST = int.Parse (label_COUST_ID.Text);
            SALES_MAN = label_SALES_MAN.Text;
            dataGridView_INVO_ITEMS.Rows.Clear ();
            label_INVO_TOTAL.Text = textBox_INVO_PAID.Text = textBox_INVO_DISC.Text = "0";
            textBox_ORDER_NOTES.Text = "";
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

        private void SELECT_PRODUCTS(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            flowLayoutPanel_PRD.Controls.Clear ();
            var dt = new DataTable ();
            dt = PROD.SEARCH_PRODUCT (clickedbutton.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn_Item = new Button ();
                btn_Item.Name = dt.Rows[i]["ID_PRODUCT"].ToString ();
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
                    row.Cells["ITEM_ID"].Value = clickedbutton.Name;
                    row.Cells["ITEM_NAME"].Value = clickedbutton.Text;//اسم مادة
                    row.Cells["ITEM_QTY"].Value = 1;//كمية المادة
                    row.Cells["ITEM_PRICE"].Value = ITEM_PRICE;  //سعر المادة
                    row.Cells["ITEM_TOTAL"].Value = ITEM_PRICE * 1;     //مجموع المادة

                }

            }
        }

        private void ADD_ORDER()
        {
            string ORDER_NOTES = textBox_ORDER_NOTES.Text;
            SLS.ADD_ORDER (ID_ORDER, ID_COUST, ORDER_NOTES, ORDER_TYPE, PAID_OR_NOT, SALES_MAN);
        }

        private void ADD_ORDER_DETAILS()
        {
            for (int i = 0; i < dataGridView_INVO_ITEMS.Rows.Count; i++)
            {
                int ID_PRD = int.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_ID"].Value.ToString ());
                float PRD_QTY = float.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_QTY"].Value.ToString ());
                float QTY_BY_PRICE = float.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_TOTAL"].Value.ToString ());
                float PRD_PRICE = float.Parse (dataGridView_INVO_ITEMS.Rows[i].Cells["ITEM_PRICE"].Value.ToString ());
                SLS.ADD_ORDER_DETAILS (ID_ORDER, ID_PRD, PRD_QTY, QTY_BY_PRICE, PRD_PRICE);
            }
        }

        private void ADD_ORDER_MONEY()
        {
            float TOTAL_AMOUNT = float.Parse (label_INVO_TOTAL.Text);
            float PAID_AMOUNT = float.Parse (textBox_INVO_PAID.Text);
            float DISCOUNT_AMOUNT = float.Parse (textBox_INVO_DISC.Text);
            float REMINDER_AMOUNT = float.Parse (label_INVO_REMID.Text);
            SLS.ADD_ORDER_MONEY (ID_ORDER, ID_COUST, TOTAL_AMOUNT, PAID_AMOUNT, DISCOUNT_AMOUNT, REMINDER_AMOUNT);
        }

        private bool CHECK_MONEY()
        {
            float INVO_NET = float.Parse (textBox_INVO_PAID.Text) + float.Parse (textBox_INVO_DISC.Text);
            float INVO_REM = float.Parse (label_INVO_REMID.Text);
            float INVO_TOTAL = float.Parse (label_INVO_TOTAL.Text);
            if (INVO_NET == INVO_TOTAL)
            {
                return true;
            }
            else
            {
                MessageBox.Show ("هناك خلل في التسديدات المالية", "CHECK_MONEY ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        #endregion

        #region BTN_CLIKS

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_NEW_INVO_Click(object sender, EventArgs e)
        {

            InitializeFunction ();
            SELECT_CATEGORIES ();
            button_NEW_INVO.Enabled = false;
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
                InitializeFunction ();
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

        private void button_SAVE_INVO_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_INVO_ITEMS.Rows.Count > 0)
                {
                    if (CHECK_MONEY ())
                    {
                        ADD_ORDER ();
                        ADD_ORDER_DETAILS ();
                        ADD_ORDER_MONEY ();
                        MessageBox.Show ("حفظ بنجاح", "ADD_ORDER SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeFunction ();
                        button_NEW_INVO.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message, "ADD_ORDER ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_CNCL_INVO_Click(object sender, EventArgs e)
        {
            if (dataGridView_INVO_ITEMS.Rows.Count > 0)
            {
                if (MessageBox.Show ("هل  تريد الغاء الفاتورة", "الغاء", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    InitializeFunction ();
                    button_NEW_INVO.Enabled = true;

                }

            }
        }

        private void FORM_SALES_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region DGV ITEMS

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

        private void dataGridView_INVO_ITEMS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler (Control_KeyPress);

        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress (e);
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        #endregion

        #region TXTBOX EVENTS

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
                    label_INVO_REMID.Text = (double.Parse (label_INVO_TOTAL.Text) - double.Parse (textBox_INVO_PAID.Text) - double.Parse (textBox_INVO_DISC.Text)).ToString ();
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

        #endregion

    }
}
