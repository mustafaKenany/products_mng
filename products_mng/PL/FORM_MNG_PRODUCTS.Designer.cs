namespace products_mng.PL
{
    partial class FORM_MNG_PRODUCTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SEARCH_PRODUCT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_REFRESH = new System.Windows.Forms.Button();
            this.btn_SAVE_PRODUCT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_PRODUCT_PRICE_STOCK = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_PRODUCT_MODIFY = new System.Windows.Forms.Button();
            this.button_DELETE_PRODUCT = new System.Windows.Forms.Button();
            this.button_ADD_NEW_PRODUCT = new System.Windows.Forms.Button();
            this.dataGridView_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARCODE_PRODCUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABEL_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT_DESCRPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_IN_STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE_PRODUCT = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(673, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "قم بادخال الكلمة المراد البحث عنها";
            // 
            // textBox_SEARCH_PRODUCT
            // 
            this.textBox_SEARCH_PRODUCT.Location = new System.Drawing.Point(360, 39);
            this.textBox_SEARCH_PRODUCT.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_SEARCH_PRODUCT.Multiline = true;
            this.textBox_SEARCH_PRODUCT.Name = "textBox_SEARCH_PRODUCT";
            this.textBox_SEARCH_PRODUCT.Size = new System.Drawing.Size(300, 35);
            this.textBox_SEARCH_PRODUCT.TabIndex = 2;
            this.textBox_SEARCH_PRODUCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SEARCH_PRODUCT.TextChanged += new System.EventHandler(this.textBox_SEARCH_PRODUCT_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_REFRESH);
            this.groupBox1.Controls.Add(this.btn_SAVE_PRODUCT);
            this.groupBox1.Controls.Add(this.textBox_SEARCH_PRODUCT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث";
            // 
            // button_REFRESH
            // 
            this.button_REFRESH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_REFRESH.FlatAppearance.BorderSize = 2;
            this.button_REFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_REFRESH.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_REFRESH.ForeColor = System.Drawing.Color.White;
            this.button_REFRESH.Location = new System.Drawing.Point(6, 29);
            this.button_REFRESH.Name = "button_REFRESH";
            this.button_REFRESH.Size = new System.Drawing.Size(100, 50);
            this.button_REFRESH.TabIndex = 12;
            this.button_REFRESH.Text = "تحديث";
            this.button_REFRESH.UseVisualStyleBackColor = true;
            this.button_REFRESH.Click += new System.EventHandler(this.button_REFRESH_Click);
            // 
            // btn_SAVE_PRODUCT
            // 
            this.btn_SAVE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btn_SAVE_PRODUCT.FlatAppearance.BorderSize = 2;
            this.btn_SAVE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SAVE_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_SAVE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btn_SAVE_PRODUCT.Location = new System.Drawing.Point(247, 31);
            this.btn_SAVE_PRODUCT.Name = "btn_SAVE_PRODUCT";
            this.btn_SAVE_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.btn_SAVE_PRODUCT.TabIndex = 11;
            this.btn_SAVE_PRODUCT.Text = "بحث";
            this.btn_SAVE_PRODUCT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_PRODUCT_PRICE_STOCK);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button_CLOSE);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button_PRODUCT_MODIFY);
            this.groupBox2.Controls.Add(this.button_DELETE_PRODUCT);
            this.groupBox2.Controls.Add(this.button_ADD_NEW_PRODUCT);
            this.groupBox2.Controls.Add(this.dataGridView_PRODUCTS);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(1024, 477);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المواد";
            // 
            // button_PRODUCT_PRICE_STOCK
            // 
            this.button_PRODUCT_PRICE_STOCK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRODUCT_PRICE_STOCK.FlatAppearance.BorderSize = 2;
            this.button_PRODUCT_PRICE_STOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCT_PRICE_STOCK.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRODUCT_PRICE_STOCK.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCT_PRICE_STOCK.Location = new System.Drawing.Point(552, 419);
            this.button_PRODUCT_PRICE_STOCK.Name = "button_PRODUCT_PRICE_STOCK";
            this.button_PRODUCT_PRICE_STOCK.Size = new System.Drawing.Size(100, 50);
            this.button_PRODUCT_PRICE_STOCK.TabIndex = 20;
            this.button_PRODUCT_PRICE_STOCK.Text = "سعر و مخزن";
            this.button_PRODUCT_PRICE_STOCK.UseVisualStyleBackColor = true;
            this.button_PRODUCT_PRICE_STOCK.Click += new System.EventHandler(this.button_PRODUCT_PRICE_STOCK_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(156, 419);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 50);
            this.button8.TabIndex = 19;
            this.button8.Text = "ملف اكسل";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CLOSE.FlatAppearance.BorderSize = 2;
            this.button_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CLOSE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CLOSE.ForeColor = System.Drawing.Color.White;
            this.button_CLOSE.Location = new System.Drawing.Point(35, 419);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(100, 50);
            this.button_CLOSE.TabIndex = 18;
            this.button_CLOSE.Text = "خروج";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(268, 419);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "طباعة كل منتوجات";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(431, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "تفاصيل منتج";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button_PRODUCT_MODIFY
            // 
            this.button_PRODUCT_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRODUCT_MODIFY.FlatAppearance.BorderSize = 2;
            this.button_PRODUCT_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCT_MODIFY.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRODUCT_MODIFY.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCT_MODIFY.Location = new System.Drawing.Point(673, 419);
            this.button_PRODUCT_MODIFY.Name = "button_PRODUCT_MODIFY";
            this.button_PRODUCT_MODIFY.Size = new System.Drawing.Size(100, 50);
            this.button_PRODUCT_MODIFY.TabIndex = 14;
            this.button_PRODUCT_MODIFY.Text = "تعديل منتوج";
            this.button_PRODUCT_MODIFY.UseVisualStyleBackColor = true;
            this.button_PRODUCT_MODIFY.Click += new System.EventHandler(this.button_PRODUCT_MODIFY_Click);
            // 
            // button_DELETE_PRODUCT
            // 
            this.button_DELETE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DELETE_PRODUCT.FlatAppearance.BorderSize = 2;
            this.button_DELETE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DELETE_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_DELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.button_DELETE_PRODUCT.Location = new System.Drawing.Point(794, 419);
            this.button_DELETE_PRODUCT.Name = "button_DELETE_PRODUCT";
            this.button_DELETE_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.button_DELETE_PRODUCT.TabIndex = 13;
            this.button_DELETE_PRODUCT.Text = "حذف منتوج";
            this.button_DELETE_PRODUCT.UseVisualStyleBackColor = true;
            this.button_DELETE_PRODUCT.Click += new System.EventHandler(this.button_DELETE_PRODUCT_Click);
            // 
            // button_ADD_NEW_PRODUCT
            // 
            this.button_ADD_NEW_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADD_NEW_PRODUCT.FlatAppearance.BorderSize = 2;
            this.button_ADD_NEW_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD_NEW_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADD_NEW_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.button_ADD_NEW_PRODUCT.Location = new System.Drawing.Point(915, 419);
            this.button_ADD_NEW_PRODUCT.Name = "button_ADD_NEW_PRODUCT";
            this.button_ADD_NEW_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.button_ADD_NEW_PRODUCT.TabIndex = 12;
            this.button_ADD_NEW_PRODUCT.Text = "منتوج  جديد";
            this.button_ADD_NEW_PRODUCT.UseVisualStyleBackColor = true;
            this.button_ADD_NEW_PRODUCT.Click += new System.EventHandler(this.button_ADD_NEW_PRODUCT_Click);
            // 
            // dataGridView_PRODUCTS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.dataGridView_PRODUCTS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PRODUCTS.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PRODUCTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PRODUCTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCT,
            this.BARCODE_PRODCUT,
            this.LABEL_PRODUCT,
            this.CAT_DESCRPTION,
            this.QTE_IN_STOCK,
            this.PRICE,
            this.IMAGE_PRODUCT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PRODUCTS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_PRODUCTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_PRODUCTS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_PRODUCTS.EnableHeadersVisualStyles = false;
            this.dataGridView_PRODUCTS.Location = new System.Drawing.Point(5, 25);
            this.dataGridView_PRODUCTS.MultiSelect = false;
            this.dataGridView_PRODUCTS.Name = "dataGridView_PRODUCTS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PRODUCTS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_PRODUCTS.RowHeadersVisible = false;
            this.dataGridView_PRODUCTS.RowHeadersWidth = 50;
            this.dataGridView_PRODUCTS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PRODUCTS.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_PRODUCTS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView_PRODUCTS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridView_PRODUCTS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_PRODUCTS.RowTemplate.Height = 35;
            this.dataGridView_PRODUCTS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PRODUCTS.Size = new System.Drawing.Size(1014, 368);
            this.dataGridView_PRODUCTS.TabIndex = 0;
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.DataPropertyName = "ID_PRODUCT";
            this.ID_PRODUCT.HeaderText = "المعرف";
            this.ID_PRODUCT.Name = "ID_PRODUCT";
            this.ID_PRODUCT.ReadOnly = true;
            this.ID_PRODUCT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BARCODE_PRODCUT
            // 
            this.BARCODE_PRODCUT.DataPropertyName = "BARCODE_PRODUCT";
            this.BARCODE_PRODCUT.HeaderText = "الباركود";
            this.BARCODE_PRODCUT.Name = "BARCODE_PRODCUT";
            this.BARCODE_PRODCUT.ReadOnly = true;
            this.BARCODE_PRODCUT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LABEL_PRODUCT
            // 
            this.LABEL_PRODUCT.DataPropertyName = "LABEL_PRODUCT";
            this.LABEL_PRODUCT.HeaderText = "أسم مادة";
            this.LABEL_PRODUCT.Name = "LABEL_PRODUCT";
            this.LABEL_PRODUCT.ReadOnly = true;
            this.LABEL_PRODUCT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CAT_DESCRPTION
            // 
            this.CAT_DESCRPTION.DataPropertyName = "CAT_DESCRPTION";
            this.CAT_DESCRPTION.HeaderText = "الصنف";
            this.CAT_DESCRPTION.Name = "CAT_DESCRPTION";
            this.CAT_DESCRPTION.ReadOnly = true;
            this.CAT_DESCRPTION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QTE_IN_STOCK
            // 
            this.QTE_IN_STOCK.DataPropertyName = "QTE_IN_STOCK";
            this.QTE_IN_STOCK.HeaderText = "المتوفر";
            this.QTE_IN_STOCK.Name = "QTE_IN_STOCK";
            this.QTE_IN_STOCK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "السعر";
            this.PRICE.Name = "PRICE";
            this.PRICE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IMAGE_PRODUCT
            // 
            this.IMAGE_PRODUCT.DataPropertyName = "IMAGE_PRODUCT";
            this.IMAGE_PRODUCT.HeaderText = "الصورة";
            this.IMAGE_PRODUCT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.IMAGE_PRODUCT.Name = "IMAGE_PRODUCT";
            this.IMAGE_PRODUCT.ReadOnly = true;
            this.IMAGE_PRODUCT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGE_PRODUCT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FORM_MNG_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MNG_PRODUCTS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أدارة المنتوجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUCTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SEARCH_PRODUCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SAVE_PRODUCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_PRODUCT_MODIFY;
        private System.Windows.Forms.Button button_DELETE_PRODUCT;
        private System.Windows.Forms.Button button_ADD_NEW_PRODUCT;
        private System.Windows.Forms.Button button_PRODUCT_PRICE_STOCK;
        private System.Windows.Forms.Button button_REFRESH;
        public System.Windows.Forms.DataGridView dataGridView_PRODUCTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE_PRODCUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LABEL_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT_DESCRPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_IN_STOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGE_PRODUCT;
    }
}