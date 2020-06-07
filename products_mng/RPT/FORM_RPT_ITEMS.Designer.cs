namespace products_mng.RPT
{
    partial class FORM_RPT_ITEMS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_END_DATE = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button_RPT_Purchases = new System.Windows.Forms.Button();
            this.button_ITEMALLSALES = new System.Windows.Forms.Button();
            this.button_ALLITEMS = new System.Windows.Forms.Button();
            this.gridControl_ITEMS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ITEMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_END_DATE);
            this.groupBox1.Controls.Add(this.dateTimePicker_BEGIN_DATE);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button_RPT_Purchases);
            this.groupBox1.Controls.Add(this.button_ITEMALLSALES);
            this.groupBox1.Controls.Add(this.button_ALLITEMS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Cairo Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاجراءات الممكنة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 64;
            this.label2.Text = "الى";
            // 
            // dateTimePicker_END_DATE
            // 
            this.dateTimePicker_END_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_END_DATE.Location = new System.Drawing.Point(6, 64);
            this.dateTimePicker_END_DATE.Name = "dateTimePicker_END_DATE";
            this.dateTimePicker_END_DATE.ShowUpDown = true;
            this.dateTimePicker_END_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_END_DATE.TabIndex = 63;
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.ShowUpDown = true;
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(201, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 66);
            this.button3.TabIndex = 55;
            this.button3.Text = "طباعة كل حركات";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_RPT_Purchases
            // 
            this.button_RPT_Purchases.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RPT_Purchases.FlatAppearance.BorderSize = 2;
            this.button_RPT_Purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RPT_Purchases.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_RPT_Purchases.ForeColor = System.Drawing.Color.White;
            this.button_RPT_Purchases.Location = new System.Drawing.Point(307, 33);
            this.button_RPT_Purchases.Name = "button_RPT_Purchases";
            this.button_RPT_Purchases.Size = new System.Drawing.Size(100, 66);
            this.button_RPT_Purchases.TabIndex = 54;
            this.button_RPT_Purchases.Text = "طباعة المشتريات";
            this.button_RPT_Purchases.UseVisualStyleBackColor = true;
            this.button_RPT_Purchases.Click += new System.EventHandler(this.button_RPT_Purchases_Click);
            // 
            // button_ITEMALLSALES
            // 
            this.button_ITEMALLSALES.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ITEMALLSALES.FlatAppearance.BorderSize = 2;
            this.button_ITEMALLSALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ITEMALLSALES.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ITEMALLSALES.ForeColor = System.Drawing.Color.White;
            this.button_ITEMALLSALES.Location = new System.Drawing.Point(413, 33);
            this.button_ITEMALLSALES.Name = "button_ITEMALLSALES";
            this.button_ITEMALLSALES.Size = new System.Drawing.Size(100, 66);
            this.button_ITEMALLSALES.TabIndex = 53;
            this.button_ITEMALLSALES.Text = "طباعة المبيعات";
            this.button_ITEMALLSALES.UseVisualStyleBackColor = true;
            this.button_ITEMALLSALES.Click += new System.EventHandler(this.button_ITEMALLSALES_Click);
            // 
            // button_ALLITEMS
            // 
            this.button_ALLITEMS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ALLITEMS.FlatAppearance.BorderSize = 2;
            this.button_ALLITEMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ALLITEMS.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ALLITEMS.ForeColor = System.Drawing.Color.White;
            this.button_ALLITEMS.Location = new System.Drawing.Point(519, 33);
            this.button_ALLITEMS.Name = "button_ALLITEMS";
            this.button_ALLITEMS.Size = new System.Drawing.Size(100, 66);
            this.button_ALLITEMS.TabIndex = 52;
            this.button_ALLITEMS.Text = "عرض الكل";
            this.button_ALLITEMS.UseVisualStyleBackColor = true;
            this.button_ALLITEMS.Click += new System.EventHandler(this.button_ALLITEMS_Click);
            // 
            // gridControl_ITEMS
            // 
            this.gridControl_ITEMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ITEMS.Location = new System.Drawing.Point(5, 117);
            this.gridControl_ITEMS.MainView = this.gridView1;
            this.gridControl_ITEMS.Name = "gridControl_ITEMS";
            this.gridControl_ITEMS.Size = new System.Drawing.Size(649, 490);
            this.gridControl_ITEMS.TabIndex = 1;
            this.gridControl_ITEMS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FooterPanelHeight = 30;
            this.gridView1.GridControl = this.gridControl_ITEMS;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 30;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "رقم المادة";
            this.gridColumn1.FieldName = "ID_PRODUCT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 173;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "أسم المادة";
            this.gridColumn2.FieldName = "LABEL_PRODUCT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 461;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // FORM_RPT_ITEMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(659, 612);
            this.Controls.Add(this.gridControl_ITEMS);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_RPT_ITEMS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقرير مواد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ITEMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl_ITEMS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button_RPT_Purchases;
        public System.Windows.Forms.Button button_ITEMALLSALES;
        public System.Windows.Forms.Button button_ALLITEMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_END_DATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
    }
}