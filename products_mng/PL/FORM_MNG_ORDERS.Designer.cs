namespace products_mng.PL
{
    partial class FORM_MNG_ORDERS
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ORDERS_DATE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_END_DATE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.button_SHOW_ALL_ORD = new System.Windows.Forms.Button();
            this.textBox_ORDER_FILTERS = new System.Windows.Forms.TextBox();
            this.gridControl_ORDERS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.button_PRT_GRID = new System.Windows.Forms.Button();
            this.button_DLT_INVO = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button_PRT_INVO = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_INVO_DETLS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ORDERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ORDERS_DATE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_END_DATE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_BEGIN_DATE);
            this.groupBox1.Controls.Add(this.button_SHOW_ALL_ORD);
            this.groupBox1.Controls.Add(this.textBox_ORDER_FILTERS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث";
            // 
            // button_ORDERS_DATE
            // 
            this.button_ORDERS_DATE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ORDERS_DATE.FlatAppearance.BorderSize = 2;
            this.button_ORDERS_DATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ORDERS_DATE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ORDERS_DATE.ForeColor = System.Drawing.Color.White;
            this.button_ORDERS_DATE.Location = new System.Drawing.Point(23, 41);
            this.button_ORDERS_DATE.Name = "button_ORDERS_DATE";
            this.button_ORDERS_DATE.Size = new System.Drawing.Size(100, 50);
            this.button_ORDERS_DATE.TabIndex = 18;
            this.button_ORDERS_DATE.Text = "بحث";
            this.button_ORDERS_DATE.UseVisualStyleBackColor = true;
            this.button_ORDERS_DATE.Click += new System.EventHandler(this.button_ORDERS_DATE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "الى";
            // 
            // dateTimePicker_END_DATE
            // 
            this.dateTimePicker_END_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_END_DATE.Location = new System.Drawing.Point(146, 69);
            this.dateTimePicker_END_DATE.Name = "dateTimePicker_END_DATE";
            this.dateTimePicker_END_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_END_DATE.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "من";
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(146, 22);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 14;
            // 
            // button_SHOW_ALL_ORD
            // 
            this.button_SHOW_ALL_ORD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_SHOW_ALL_ORD.FlatAppearance.BorderSize = 2;
            this.button_SHOW_ALL_ORD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SHOW_ALL_ORD.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_SHOW_ALL_ORD.ForeColor = System.Drawing.Color.White;
            this.button_SHOW_ALL_ORD.Location = new System.Drawing.Point(856, 41);
            this.button_SHOW_ALL_ORD.Name = "button_SHOW_ALL_ORD";
            this.button_SHOW_ALL_ORD.Size = new System.Drawing.Size(100, 50);
            this.button_SHOW_ALL_ORD.TabIndex = 13;
            this.button_SHOW_ALL_ORD.Text = "عرض البيانات";
            this.button_SHOW_ALL_ORD.UseVisualStyleBackColor = true;
            this.button_SHOW_ALL_ORD.Click += new System.EventHandler(this.button_SHOW_ALL_ORD_Click);
            // 
            // textBox_ORDER_FILTERS
            // 
            this.textBox_ORDER_FILTERS.Location = new System.Drawing.Point(487, 50);
            this.textBox_ORDER_FILTERS.Name = "textBox_ORDER_FILTERS";
            this.textBox_ORDER_FILTERS.Size = new System.Drawing.Size(300, 34);
            this.textBox_ORDER_FILTERS.TabIndex = 0;
            this.textBox_ORDER_FILTERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ORDER_FILTERS.TextChanged += new System.EventHandler(this.textBox_ORDER_FILTERS_TextChanged);
            // 
            // gridControl_ORDERS
            // 
            this.gridControl_ORDERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ORDERS.Location = new System.Drawing.Point(5, 118);
            this.gridControl_ORDERS.MainView = this.gridView1;
            this.gridControl_ORDERS.Name = "gridControl_ORDERS";
            this.gridControl_ORDERS.Size = new System.Drawing.Size(974, 464);
            this.gridControl_ORDERS.TabIndex = 3;
            this.gridControl_ORDERS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl_ORDERS;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_AMOUNT", this.gridColumn3, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowHeight = 30;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "رقم الفاتورة";
            this.gridColumn1.FieldName = "ID_ORDER";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "تاريخ الفاتورة";
            this.gridColumn2.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "ORDER_DATE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "مبلغ الفاتورة";
            this.gridColumn3.FieldName = "TOTAL_AMOUNT";
            this.gridColumn3.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_AMOUNT", "مجموع مبالغ={0:0.##}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "اسم الزبون";
            this.gridColumn4.FieldName = "COUST_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "الكاشير";
            this.gridColumn5.FieldName = "SALES_MAN";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.documentViewer1);
            this.panel1.Controls.Add(this.button_PRT_GRID);
            this.panel1.Controls.Add(this.button_DLT_INVO);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.button_PRT_INVO);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.button_INVO_DETLS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 582);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(974, 75);
            this.panel1.TabIndex = 4;
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentViewer1.DocumentSource = this.printingSystem1;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(105, 5);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(151, 61);
            this.documentViewer1.TabIndex = 19;
            this.documentViewer1.Visible = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl_ORDERS;
            this.printableComponentLink1.Landscape = true;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.RightToLeftLayout = true;
            // 
            // button_PRT_GRID
            // 
            this.button_PRT_GRID.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_PRT_GRID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRT_GRID.FlatAppearance.BorderSize = 2;
            this.button_PRT_GRID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRT_GRID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRT_GRID.ForeColor = System.Drawing.Color.White;
            this.button_PRT_GRID.Location = new System.Drawing.Point(5, 5);
            this.button_PRT_GRID.Name = "button_PRT_GRID";
            this.button_PRT_GRID.Size = new System.Drawing.Size(100, 61);
            this.button_PRT_GRID.TabIndex = 19;
            this.button_PRT_GRID.Text = "طباعة لوحة";
            this.button_PRT_GRID.UseVisualStyleBackColor = true;
            this.button_PRT_GRID.Click += new System.EventHandler(this.button_PRT_GRID_Click);
            // 
            // button_DLT_INVO
            // 
            this.button_DLT_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_DLT_INVO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DLT_INVO.FlatAppearance.BorderSize = 2;
            this.button_DLT_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DLT_INVO.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_DLT_INVO.ForeColor = System.Drawing.Color.White;
            this.button_DLT_INVO.Location = new System.Drawing.Point(653, 5);
            this.button_DLT_INVO.Name = "button_DLT_INVO";
            this.button_DLT_INVO.Size = new System.Drawing.Size(100, 61);
            this.button_DLT_INVO.TabIndex = 18;
            this.button_DLT_INVO.Text = "حذف الفاتورة";
            this.button_DLT_INVO.UseVisualStyleBackColor = true;
            this.button_DLT_INVO.Click += new System.EventHandler(this.button_DLT_INVO_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(753, 5);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 61);
            this.splitter2.TabIndex = 17;
            this.splitter2.TabStop = false;
            // 
            // button_PRT_INVO
            // 
            this.button_PRT_INVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PRT_INVO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRT_INVO.FlatAppearance.BorderSize = 2;
            this.button_PRT_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRT_INVO.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRT_INVO.ForeColor = System.Drawing.Color.White;
            this.button_PRT_INVO.Location = new System.Drawing.Point(759, 5);
            this.button_PRT_INVO.Name = "button_PRT_INVO";
            this.button_PRT_INVO.Size = new System.Drawing.Size(100, 61);
            this.button_PRT_INVO.TabIndex = 16;
            this.button_PRT_INVO.Text = "طباعة الفاتورة";
            this.button_PRT_INVO.UseVisualStyleBackColor = true;
            this.button_PRT_INVO.Click += new System.EventHandler(this.button_PRT_INVO_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(859, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 61);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // button_INVO_DETLS
            // 
            this.button_INVO_DETLS.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_INVO_DETLS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_INVO_DETLS.FlatAppearance.BorderSize = 2;
            this.button_INVO_DETLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INVO_DETLS.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_INVO_DETLS.ForeColor = System.Drawing.Color.White;
            this.button_INVO_DETLS.Location = new System.Drawing.Point(865, 5);
            this.button_INVO_DETLS.Name = "button_INVO_DETLS";
            this.button_INVO_DETLS.Size = new System.Drawing.Size(100, 61);
            this.button_INVO_DETLS.TabIndex = 14;
            this.button_INVO_DETLS.Text = "كشف الفاتورة";
            this.button_INVO_DETLS.UseVisualStyleBackColor = true;
            this.button_INVO_DETLS.Click += new System.EventHandler(this.button_INVO_DETLS_Click);
            // 
            // FORM_MNG_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.gridControl_ORDERS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MNG_ORDERS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادارة المبيعات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ORDERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ORDERS_DATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_END_DATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
        private System.Windows.Forms.Button button_SHOW_ALL_ORD;
        private System.Windows.Forms.TextBox textBox_ORDER_FILTERS;
        private DevExpress.XtraGrid.GridControl gridControl_ORDERS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_DLT_INVO;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button button_PRT_INVO;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_INVO_DETLS;
        private System.Windows.Forms.Button button_PRT_GRID;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
    }
}