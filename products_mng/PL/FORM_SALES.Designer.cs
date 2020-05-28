namespace products_mng.PL
{
    partial class FORM_SALES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_MONEYIES_ID = new System.Windows.Forms.Label();
            this.label_COUST_ID = new System.Windows.Forms.Label();
            this.label_SALES_MAN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.dataGridView_INVO_ITEMS = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_PAID_MONEY = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_INVO_PAID = new System.Windows.Forms.TextBox();
            this.label_INVO_TOTAL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_INVO_DISC = new System.Windows.Forms.TextBox();
            this.label_INVO_REMID = new System.Windows.Forms.Label();
            this.panel_BTNS = new System.Windows.Forms.Panel();
            this.button_DLT_ITEM = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.button_CNCL_INVO = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.button_PRT_INVO = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.button_SAVE_INVO = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button_PAID_INVO = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label_ID_ORDER = new System.Windows.Forms.Label();
            this.button_NEW_INVO = new System.Windows.Forms.Button();
            this.panel_COUST_NOTS = new System.Windows.Forms.Panel();
            this.textBox_ORDER_NOTES = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_COUST_BRWS = new System.Windows.Forms.Button();
            this.textBox_COUST_NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_CATEGORIES = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_CATEGORIES = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_PRD = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top.SuspendLayout();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_INVO_ITEMS)).BeginInit();
            this.panel_PAID_MONEY.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_BTNS.SuspendLayout();
            this.panel_COUST_NOTS.SuspendLayout();
            this.panel_CATEGORIES.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.panel_top.Controls.Add(this.label_MONEYIES_ID);
            this.panel_top.Controls.Add(this.label_COUST_ID);
            this.panel_top.Controls.Add(this.label_SALES_MAN);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.button_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(5);
            this.panel_top.Size = new System.Drawing.Size(1250, 50);
            this.panel_top.TabIndex = 0;
            // 
            // label_MONEYIES_ID
            // 
            this.label_MONEYIES_ID.AutoSize = true;
            this.label_MONEYIES_ID.ForeColor = System.Drawing.Color.White;
            this.label_MONEYIES_ID.Location = new System.Drawing.Point(284, 12);
            this.label_MONEYIES_ID.Name = "label_MONEYIES_ID";
            this.label_MONEYIES_ID.Size = new System.Drawing.Size(81, 26);
            this.label_MONEYIES_ID.TabIndex = 4;
            this.label_MONEYIES_ID.Text = "MONEY_ID";
            this.label_MONEYIES_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_MONEYIES_ID.MouseLeave += new System.EventHandler(this.label_MONEYIES_ID_MouseLeave);
            this.label_MONEYIES_ID.MouseHover += new System.EventHandler(this.label_MONEYIES_ID_MouseHover);
            // 
            // label_COUST_ID
            // 
            this.label_COUST_ID.AutoSize = true;
            this.label_COUST_ID.ForeColor = System.Drawing.Color.White;
            this.label_COUST_ID.Location = new System.Drawing.Point(450, 12);
            this.label_COUST_ID.Name = "label_COUST_ID";
            this.label_COUST_ID.Size = new System.Drawing.Size(75, 26);
            this.label_COUST_ID.TabIndex = 3;
            this.label_COUST_ID.Text = "COUST_ID";
            this.label_COUST_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_COUST_ID.MouseLeave += new System.EventHandler(this.label_COUST_ID_MouseLeave);
            this.label_COUST_ID.MouseHover += new System.EventHandler(this.label_COUST_ID_MouseHover);
            // 
            // label_SALES_MAN
            // 
            this.label_SALES_MAN.ForeColor = System.Drawing.Color.White;
            this.label_SALES_MAN.Location = new System.Drawing.Point(589, 7);
            this.label_SALES_MAN.Name = "label_SALES_MAN";
            this.label_SALES_MAN.Size = new System.Drawing.Size(99, 40);
            this.label_SALES_MAN.TabIndex = 2;
            this.label_SALES_MAN.Text = "المستخدم";
            this.label_SALES_MAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SALES_MAN.MouseLeave += new System.EventHandler(this.label_SALES_MAN_MouseLeave);
            this.label_SALES_MAN.MouseHover += new System.EventHandler(this.label_SALES_MAN_MouseHover);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1173, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "بيع مباشر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_close.FlatAppearance.BorderSize = 2;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(5, 5);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 40);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel_Right.Controls.Add(this.dataGridView_INVO_ITEMS);
            this.panel_Right.Controls.Add(this.panel_PAID_MONEY);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(800, 50);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Right.Size = new System.Drawing.Size(450, 650);
            this.panel_Right.TabIndex = 1;
            // 
            // dataGridView_INVO_ITEMS
            // 
            this.dataGridView_INVO_ITEMS.AllowUserToAddRows = false;
            this.dataGridView_INVO_ITEMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_INVO_ITEMS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView_INVO_ITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_INVO_ITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.ITEM_NAME,
            this.ITEM_QTY,
            this.ITEM_PRICE,
            this.ITEM_TOTAL});
            this.dataGridView_INVO_ITEMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_INVO_ITEMS.Location = new System.Drawing.Point(5, 5);
            this.dataGridView_INVO_ITEMS.MultiSelect = false;
            this.dataGridView_INVO_ITEMS.Name = "dataGridView_INVO_ITEMS";
            this.dataGridView_INVO_ITEMS.RowHeadersVisible = false;
            this.dataGridView_INVO_ITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_INVO_ITEMS.Size = new System.Drawing.Size(440, 490);
            this.dataGridView_INVO_ITEMS.TabIndex = 2;
            this.dataGridView_INVO_ITEMS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_INVO_ITEMS_CellValueChanged);
            this.dataGridView_INVO_ITEMS.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_INVO_ITEMS_EditingControlShowing);
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.HeaderText = "ITEM_ID";
            this.ITEM_ID.Name = "ITEM_ID";
            this.ITEM_ID.Visible = false;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.HeaderText = "مادة";
            this.ITEM_NAME.Name = "ITEM_NAME";
            // 
            // ITEM_QTY
            // 
            this.ITEM_QTY.HeaderText = "عدد";
            this.ITEM_QTY.Name = "ITEM_QTY";
            // 
            // ITEM_PRICE
            // 
            this.ITEM_PRICE.HeaderText = "سعر";
            this.ITEM_PRICE.Name = "ITEM_PRICE";
            // 
            // ITEM_TOTAL
            // 
            this.ITEM_TOTAL.HeaderText = "المجموع";
            this.ITEM_TOTAL.Name = "ITEM_TOTAL";
            // 
            // panel_PAID_MONEY
            // 
            this.panel_PAID_MONEY.Controls.Add(this.tableLayoutPanel1);
            this.panel_PAID_MONEY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_PAID_MONEY.Location = new System.Drawing.Point(5, 495);
            this.panel_PAID_MONEY.Name = "panel_PAID_MONEY";
            this.panel_PAID_MONEY.Size = new System.Drawing.Size(440, 150);
            this.panel_PAID_MONEY.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_INVO_PAID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_INVO_TOTAL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_INVO_DISC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_INVO_REMID, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_INVO_PAID
            // 
            this.textBox_INVO_PAID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_INVO_PAID.Enabled = false;
            this.textBox_INVO_PAID.Location = new System.Drawing.Point(6, 78);
            this.textBox_INVO_PAID.Name = "textBox_INVO_PAID";
            this.textBox_INVO_PAID.Size = new System.Drawing.Size(211, 34);
            this.textBox_INVO_PAID.TabIndex = 18;
            this.textBox_INVO_PAID.Text = "0";
            this.textBox_INVO_PAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_INVO_PAID.TextChanged += new System.EventHandler(this.textBox_INVO_PAID_TextChanged);
            this.textBox_INVO_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_INVO_PAID_KeyPress);
            // 
            // label_INVO_TOTAL
            // 
            this.label_INVO_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_INVO_TOTAL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_INVO_TOTAL.Location = new System.Drawing.Point(6, 3);
            this.label_INVO_TOTAL.Name = "label_INVO_TOTAL";
            this.label_INVO_TOTAL.Size = new System.Drawing.Size(211, 36);
            this.label_INVO_TOTAL.TabIndex = 16;
            this.label_INVO_TOTAL.Text = "0";
            this.label_INVO_TOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(335, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "المتبقي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(335, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "مبلغ كلي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(335, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "الخصم";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(335, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "الواصل";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_INVO_DISC
            // 
            this.textBox_INVO_DISC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_INVO_DISC.Enabled = false;
            this.textBox_INVO_DISC.Location = new System.Drawing.Point(6, 42);
            this.textBox_INVO_DISC.Name = "textBox_INVO_DISC";
            this.textBox_INVO_DISC.Size = new System.Drawing.Size(211, 34);
            this.textBox_INVO_DISC.TabIndex = 17;
            this.textBox_INVO_DISC.Text = "0";
            this.textBox_INVO_DISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_INVO_DISC.TextChanged += new System.EventHandler(this.textBox_INVO_DISC_TextChanged);
            this.textBox_INVO_DISC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_INVO_DISC_KeyPress);
            // 
            // label_INVO_REMID
            // 
            this.label_INVO_REMID.AutoSize = true;
            this.label_INVO_REMID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_INVO_REMID.ForeColor = System.Drawing.Color.White;
            this.label_INVO_REMID.Location = new System.Drawing.Point(6, 111);
            this.label_INVO_REMID.Name = "label_INVO_REMID";
            this.label_INVO_REMID.Size = new System.Drawing.Size(211, 36);
            this.label_INVO_REMID.TabIndex = 19;
            this.label_INVO_REMID.Text = "0";
            this.label_INVO_REMID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_BTNS
            // 
            this.panel_BTNS.BackColor = System.Drawing.SystemColors.Window;
            this.panel_BTNS.Controls.Add(this.button_DLT_ITEM);
            this.panel_BTNS.Controls.Add(this.splitter5);
            this.panel_BTNS.Controls.Add(this.button_CNCL_INVO);
            this.panel_BTNS.Controls.Add(this.splitter4);
            this.panel_BTNS.Controls.Add(this.button_PRT_INVO);
            this.panel_BTNS.Controls.Add(this.splitter3);
            this.panel_BTNS.Controls.Add(this.button_SAVE_INVO);
            this.panel_BTNS.Controls.Add(this.splitter2);
            this.panel_BTNS.Controls.Add(this.button_PAID_INVO);
            this.panel_BTNS.Controls.Add(this.splitter1);
            this.panel_BTNS.Controls.Add(this.label_ID_ORDER);
            this.panel_BTNS.Controls.Add(this.button_NEW_INVO);
            this.panel_BTNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BTNS.Location = new System.Drawing.Point(0, 50);
            this.panel_BTNS.Name = "panel_BTNS";
            this.panel_BTNS.Padding = new System.Windows.Forms.Padding(3);
            this.panel_BTNS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_BTNS.Size = new System.Drawing.Size(800, 60);
            this.panel_BTNS.TabIndex = 2;
            // 
            // button_DLT_ITEM
            // 
            this.button_DLT_ITEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_DLT_ITEM.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_DLT_ITEM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_DLT_ITEM.FlatAppearance.BorderSize = 2;
            this.button_DLT_ITEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DLT_ITEM.ForeColor = System.Drawing.Color.White;
            this.button_DLT_ITEM.Location = new System.Drawing.Point(292, 3);
            this.button_DLT_ITEM.Margin = new System.Windows.Forms.Padding(10);
            this.button_DLT_ITEM.Name = "button_DLT_ITEM";
            this.button_DLT_ITEM.Size = new System.Drawing.Size(80, 54);
            this.button_DLT_ITEM.TabIndex = 13;
            this.button_DLT_ITEM.Text = "حذف";
            this.button_DLT_ITEM.UseVisualStyleBackColor = false;
            this.button_DLT_ITEM.Click += new System.EventHandler(this.button_DLT_ITEM_Click);
            // 
            // splitter5
            // 
            this.splitter5.BackColor = System.Drawing.Color.White;
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter5.Location = new System.Drawing.Point(372, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 54);
            this.splitter5.TabIndex = 12;
            this.splitter5.TabStop = false;
            // 
            // button_CNCL_INVO
            // 
            this.button_CNCL_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_CNCL_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_CNCL_INVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_CNCL_INVO.FlatAppearance.BorderSize = 2;
            this.button_CNCL_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CNCL_INVO.ForeColor = System.Drawing.Color.White;
            this.button_CNCL_INVO.Location = new System.Drawing.Point(377, 3);
            this.button_CNCL_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_CNCL_INVO.Name = "button_CNCL_INVO";
            this.button_CNCL_INVO.Size = new System.Drawing.Size(80, 54);
            this.button_CNCL_INVO.TabIndex = 11;
            this.button_CNCL_INVO.Text = "الغاء";
            this.button_CNCL_INVO.UseVisualStyleBackColor = false;
            this.button_CNCL_INVO.Click += new System.EventHandler(this.button_CNCL_INVO_Click);
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.White;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(457, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 54);
            this.splitter4.TabIndex = 10;
            this.splitter4.TabStop = false;
            // 
            // button_PRT_INVO
            // 
            this.button_PRT_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_PRT_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PRT_INVO.Enabled = false;
            this.button_PRT_INVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_PRT_INVO.FlatAppearance.BorderSize = 2;
            this.button_PRT_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRT_INVO.ForeColor = System.Drawing.Color.White;
            this.button_PRT_INVO.Location = new System.Drawing.Point(462, 3);
            this.button_PRT_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_PRT_INVO.Name = "button_PRT_INVO";
            this.button_PRT_INVO.Size = new System.Drawing.Size(80, 54);
            this.button_PRT_INVO.TabIndex = 9;
            this.button_PRT_INVO.Text = "طباعة";
            this.button_PRT_INVO.UseVisualStyleBackColor = false;
            this.button_PRT_INVO.Click += new System.EventHandler(this.button_PRT_INVO_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.White;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(542, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 54);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // button_SAVE_INVO
            // 
            this.button_SAVE_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_SAVE_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SAVE_INVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_SAVE_INVO.FlatAppearance.BorderSize = 2;
            this.button_SAVE_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SAVE_INVO.ForeColor = System.Drawing.Color.White;
            this.button_SAVE_INVO.Location = new System.Drawing.Point(547, 3);
            this.button_SAVE_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_SAVE_INVO.Name = "button_SAVE_INVO";
            this.button_SAVE_INVO.Size = new System.Drawing.Size(80, 54);
            this.button_SAVE_INVO.TabIndex = 7;
            this.button_SAVE_INVO.Text = "حفظ";
            this.button_SAVE_INVO.UseVisualStyleBackColor = false;
            this.button_SAVE_INVO.Click += new System.EventHandler(this.button_SAVE_INVO_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.White;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(627, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 54);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // button_PAID_INVO
            // 
            this.button_PAID_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_PAID_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PAID_INVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_PAID_INVO.FlatAppearance.BorderSize = 2;
            this.button_PAID_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PAID_INVO.ForeColor = System.Drawing.Color.White;
            this.button_PAID_INVO.Location = new System.Drawing.Point(632, 3);
            this.button_PAID_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_PAID_INVO.Name = "button_PAID_INVO";
            this.button_PAID_INVO.Size = new System.Drawing.Size(80, 54);
            this.button_PAID_INVO.TabIndex = 5;
            this.button_PAID_INVO.Text = "تسديد";
            this.button_PAID_INVO.UseVisualStyleBackColor = false;
            this.button_PAID_INVO.Click += new System.EventHandler(this.button_PAID_INVO_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(712, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 54);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label_ID_ORDER
            // 
            this.label_ID_ORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.label_ID_ORDER.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ID_ORDER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_ID_ORDER.Location = new System.Drawing.Point(3, 3);
            this.label_ID_ORDER.Name = "label_ID_ORDER";
            this.label_ID_ORDER.Size = new System.Drawing.Size(99, 54);
            this.label_ID_ORDER.TabIndex = 3;
            this.label_ID_ORDER.Text = "رقم القائمة";
            this.label_ID_ORDER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ID_ORDER.MouseLeave += new System.EventHandler(this.label_ID_ORDER_MouseLeave);
            this.label_ID_ORDER.MouseHover += new System.EventHandler(this.label_ID_ORDER_MouseHover);
            // 
            // button_NEW_INVO
            // 
            this.button_NEW_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_NEW_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NEW_INVO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_NEW_INVO.FlatAppearance.BorderSize = 2;
            this.button_NEW_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NEW_INVO.ForeColor = System.Drawing.Color.White;
            this.button_NEW_INVO.Location = new System.Drawing.Point(717, 3);
            this.button_NEW_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_NEW_INVO.Name = "button_NEW_INVO";
            this.button_NEW_INVO.Size = new System.Drawing.Size(80, 54);
            this.button_NEW_INVO.TabIndex = 3;
            this.button_NEW_INVO.Text = "جديد";
            this.button_NEW_INVO.UseVisualStyleBackColor = false;
            this.button_NEW_INVO.Click += new System.EventHandler(this.button_NEW_INVO_Click);
            // 
            // panel_COUST_NOTS
            // 
            this.panel_COUST_NOTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel_COUST_NOTS.Controls.Add(this.textBox_ORDER_NOTES);
            this.panel_COUST_NOTS.Controls.Add(this.label8);
            this.panel_COUST_NOTS.Controls.Add(this.button_COUST_BRWS);
            this.panel_COUST_NOTS.Controls.Add(this.textBox_COUST_NAME);
            this.panel_COUST_NOTS.Controls.Add(this.label7);
            this.panel_COUST_NOTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_COUST_NOTS.Location = new System.Drawing.Point(0, 110);
            this.panel_COUST_NOTS.Name = "panel_COUST_NOTS";
            this.panel_COUST_NOTS.Padding = new System.Windows.Forms.Padding(3);
            this.panel_COUST_NOTS.Size = new System.Drawing.Size(800, 39);
            this.panel_COUST_NOTS.TabIndex = 3;
            // 
            // textBox_ORDER_NOTES
            // 
            this.textBox_ORDER_NOTES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ORDER_NOTES.Location = new System.Drawing.Point(3, 3);
            this.textBox_ORDER_NOTES.Name = "textBox_ORDER_NOTES";
            this.textBox_ORDER_NOTES.Size = new System.Drawing.Size(332, 34);
            this.textBox_ORDER_NOTES.TabIndex = 15;
            this.textBox_ORDER_NOTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(335, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "ملاحظات";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_COUST_BRWS
            // 
            this.button_COUST_BRWS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_COUST_BRWS.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_COUST_BRWS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.button_COUST_BRWS.FlatAppearance.BorderSize = 2;
            this.button_COUST_BRWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_COUST_BRWS.ForeColor = System.Drawing.Color.White;
            this.button_COUST_BRWS.Location = new System.Drawing.Point(409, 3);
            this.button_COUST_BRWS.Margin = new System.Windows.Forms.Padding(10);
            this.button_COUST_BRWS.Name = "button_COUST_BRWS";
            this.button_COUST_BRWS.Size = new System.Drawing.Size(80, 33);
            this.button_COUST_BRWS.TabIndex = 14;
            this.button_COUST_BRWS.Text = "زبائن";
            this.button_COUST_BRWS.UseVisualStyleBackColor = false;
            this.button_COUST_BRWS.Click += new System.EventHandler(this.button_COUST_BRWS_Click);
            // 
            // textBox_COUST_NAME
            // 
            this.textBox_COUST_NAME.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_COUST_NAME.Location = new System.Drawing.Point(489, 3);
            this.textBox_COUST_NAME.Name = "textBox_COUST_NAME";
            this.textBox_COUST_NAME.Size = new System.Drawing.Size(223, 34);
            this.textBox_COUST_NAME.TabIndex = 13;
            this.textBox_COUST_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_COUST_NAME.Leave += new System.EventHandler(this.textBox_COUST_NAME_Leave);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(712, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "أسم الزبون";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_CATEGORIES
            // 
            this.panel_CATEGORIES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel_CATEGORIES.Controls.Add(this.flowLayoutPanel_CATEGORIES);
            this.panel_CATEGORIES.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_CATEGORIES.Location = new System.Drawing.Point(0, 149);
            this.panel_CATEGORIES.Name = "panel_CATEGORIES";
            this.panel_CATEGORIES.Padding = new System.Windows.Forms.Padding(5);
            this.panel_CATEGORIES.Size = new System.Drawing.Size(800, 200);
            this.panel_CATEGORIES.TabIndex = 4;
            // 
            // flowLayoutPanel_CATEGORIES
            // 
            this.flowLayoutPanel_CATEGORIES.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_CATEGORIES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CATEGORIES.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel_CATEGORIES.Name = "flowLayoutPanel_CATEGORIES";
            this.flowLayoutPanel_CATEGORIES.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel_CATEGORIES.Size = new System.Drawing.Size(790, 190);
            this.flowLayoutPanel_CATEGORIES.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.flowLayoutPanel_PRD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 375);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(800, 325);
            this.panel3.TabIndex = 5;
            // 
            // flowLayoutPanel_PRD
            // 
            this.flowLayoutPanel_PRD.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_PRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_PRD.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel_PRD.Name = "flowLayoutPanel_PRD";
            this.flowLayoutPanel_PRD.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel_PRD.Size = new System.Drawing.Size(790, 315);
            this.flowLayoutPanel_PRD.TabIndex = 0;
            // 
            // FORM_SALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_CATEGORIES);
            this.Controls.Add(this.panel_COUST_NOTS);
            this.Controls.Add(this.panel_BTNS);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_SALES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البيع المباشر";
            this.Load += new System.EventHandler(this.FORM_SALES_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_INVO_ITEMS)).EndInit();
            this.panel_PAID_MONEY.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_BTNS.ResumeLayout(false);
            this.panel_COUST_NOTS.ResumeLayout(false);
            this.panel_COUST_NOTS.PerformLayout();
            this.panel_CATEGORIES.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SALES_MAN;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_BTNS;
        private System.Windows.Forms.Button button_NEW_INVO;
        private System.Windows.Forms.Label label_ID_ORDER;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_PRT_INVO;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button button_SAVE_INVO;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button button_PAID_INVO;
        private System.Windows.Forms.Button button_CNCL_INVO;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel_PAID_MONEY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_INVO_PAID;
        private System.Windows.Forms.Label label_INVO_TOTAL;
        private System.Windows.Forms.TextBox textBox_INVO_DISC;
        private System.Windows.Forms.Panel panel_COUST_NOTS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ORDER_NOTES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_CATEGORIES;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CATEGORIES;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_PRD;
        private System.Windows.Forms.DataGridView dataGridView_INVO_ITEMS;
        private System.Windows.Forms.Button button_DLT_ITEM;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Label label_INVO_REMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_TOTAL;
        private System.Windows.Forms.Button button_COUST_BRWS;
        public System.Windows.Forms.Label label_COUST_ID;
        public System.Windows.Forms.TextBox textBox_COUST_NAME;
        public System.Windows.Forms.Label label_MONEYIES_ID;
    }
}