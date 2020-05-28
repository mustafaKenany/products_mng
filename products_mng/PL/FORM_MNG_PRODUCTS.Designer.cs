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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SEARCH_PRODUCT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AllPrd = new System.Windows.Forms.Button();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.GridControl_PRODUCTS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_ID_PRODUCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_BARCODE_PRODUCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_LABEL_PRODUCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_CAT_DESCRPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_QTE_IN_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_IMAGE_PRODUCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTreeListLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ADD_NEW_PRODUCT = new System.Windows.Forms.Button();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_PRODUCT_PRICE_STOCK = new System.Windows.Forms.Button();
            this.button_DELETE_PRODUCT = new System.Windows.Forms.Button();
            this.button_PRINT_PRD = new System.Windows.Forms.Button();
            this.button_PRODUCT_MODIFY = new System.Windows.Forms.Button();
            this.button_ModifyPrdBarcode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(629, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "قم بادخال الكلمة المراد البحث عنها";
            // 
            // textBox_SEARCH_PRODUCT
            // 
            this.textBox_SEARCH_PRODUCT.Location = new System.Drawing.Point(316, 39);
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
            this.groupBox1.Controls.Add(this.button_AllPrd);
            this.groupBox1.Controls.Add(this.documentViewer1);
            this.groupBox1.Controls.Add(this.textBox_SEARCH_PRODUCT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بوساطة الاسم او الباركود او الصنف";
            // 
            // button_AllPrd
            // 
            this.button_AllPrd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AllPrd.FlatAppearance.BorderSize = 2;
            this.button_AllPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllPrd.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_AllPrd.ForeColor = System.Drawing.Color.White;
            this.button_AllPrd.Location = new System.Drawing.Point(894, 31);
            this.button_AllPrd.Name = "button_AllPrd";
            this.button_AllPrd.Size = new System.Drawing.Size(100, 50);
            this.button_AllPrd.TabIndex = 21;
            this.button_AllPrd.Text = "عرض الكل";
            this.button_AllPrd.UseVisualStyleBackColor = true;
            this.button_AllPrd.Click += new System.EventHandler(this.button_AllPrd_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentViewer1.DocumentSource = this.printingSystem1;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(3, 28);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(165, 69);
            this.documentViewer1.TabIndex = 3;
            this.documentViewer1.Visible = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.GridControl_PRODUCTS;
            this.printableComponentLink1.Landscape = true;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.RightToLeftLayout = true;
            // 
            // GridControl_PRODUCTS
            // 
            this.GridControl_PRODUCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl_PRODUCTS.Location = new System.Drawing.Point(5, 25);
            this.GridControl_PRODUCTS.MainView = this.gridView1;
            this.GridControl_PRODUCTS.Name = "GridControl_PRODUCTS";
            this.GridControl_PRODUCTS.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTreeListLookUpEdit1,
            this.repositoryItemComboBox1});
            this.GridControl_PRODUCTS.Size = new System.Drawing.Size(1014, 362);
            this.GridControl_PRODUCTS.TabIndex = 21;
            this.GridControl_PRODUCTS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_ID_PRODUCT,
            this.gridColumn_BARCODE_PRODUCT,
            this.gridColumn_LABEL_PRODUCT,
            this.gridColumn_CAT_DESCRPTION,
            this.gridColumn_QTE_IN_STOCK,
            this.gridColumn_PRICE,
            this.gridColumn_IMAGE_PRODUCT});
            this.gridView1.FooterPanelHeight = 30;
            this.gridView1.GridControl = this.GridControl_PRODUCTS;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 30;
            // 
            // gridColumn_ID_PRODUCT
            // 
            this.gridColumn_ID_PRODUCT.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_ID_PRODUCT.AppearanceCell.Options.UseFont = true;
            this.gridColumn_ID_PRODUCT.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_ID_PRODUCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_PRODUCT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_PRODUCT.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ID_PRODUCT.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_ID_PRODUCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_ID_PRODUCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_PRODUCT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_PRODUCT.Caption = "التسلسل";
            this.gridColumn_ID_PRODUCT.FieldName = "ID_PRODUCT";
            this.gridColumn_ID_PRODUCT.Name = "gridColumn_ID_PRODUCT";
            this.gridColumn_ID_PRODUCT.OptionsColumn.AllowEdit = false;
            this.gridColumn_ID_PRODUCT.OptionsFilter.AllowFilter = false;
            this.gridColumn_ID_PRODUCT.Visible = true;
            this.gridColumn_ID_PRODUCT.VisibleIndex = 0;
            // 
            // gridColumn_BARCODE_PRODUCT
            // 
            this.gridColumn_BARCODE_PRODUCT.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_BARCODE_PRODUCT.AppearanceCell.Options.UseFont = true;
            this.gridColumn_BARCODE_PRODUCT.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_BARCODE_PRODUCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_BARCODE_PRODUCT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_BARCODE_PRODUCT.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_BARCODE_PRODUCT.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_BARCODE_PRODUCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_BARCODE_PRODUCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_BARCODE_PRODUCT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_BARCODE_PRODUCT.Caption = "الباركود";
            this.gridColumn_BARCODE_PRODUCT.FieldName = "BARCODE_PRODUCT";
            this.gridColumn_BARCODE_PRODUCT.Name = "gridColumn_BARCODE_PRODUCT";
            this.gridColumn_BARCODE_PRODUCT.OptionsColumn.AllowEdit = false;
            this.gridColumn_BARCODE_PRODUCT.Visible = true;
            this.gridColumn_BARCODE_PRODUCT.VisibleIndex = 1;
            // 
            // gridColumn_LABEL_PRODUCT
            // 
            this.gridColumn_LABEL_PRODUCT.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_LABEL_PRODUCT.AppearanceCell.Options.UseFont = true;
            this.gridColumn_LABEL_PRODUCT.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_LABEL_PRODUCT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_LABEL_PRODUCT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_LABEL_PRODUCT.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_LABEL_PRODUCT.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_LABEL_PRODUCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_LABEL_PRODUCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_LABEL_PRODUCT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_LABEL_PRODUCT.Caption = "أسم المادة";
            this.gridColumn_LABEL_PRODUCT.FieldName = "LABEL_PRODUCT";
            this.gridColumn_LABEL_PRODUCT.Name = "gridColumn_LABEL_PRODUCT";
            this.gridColumn_LABEL_PRODUCT.OptionsColumn.AllowEdit = false;
            this.gridColumn_LABEL_PRODUCT.Visible = true;
            this.gridColumn_LABEL_PRODUCT.VisibleIndex = 2;
            // 
            // gridColumn_CAT_DESCRPTION
            // 
            this.gridColumn_CAT_DESCRPTION.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_CAT_DESCRPTION.AppearanceCell.Options.UseFont = true;
            this.gridColumn_CAT_DESCRPTION.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_CAT_DESCRPTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_CAT_DESCRPTION.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_CAT_DESCRPTION.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_CAT_DESCRPTION.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_CAT_DESCRPTION.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_CAT_DESCRPTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_CAT_DESCRPTION.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_CAT_DESCRPTION.Caption = "الصنف";
            this.gridColumn_CAT_DESCRPTION.FieldName = "CAT_DESCRPTION";
            this.gridColumn_CAT_DESCRPTION.Name = "gridColumn_CAT_DESCRPTION";
            this.gridColumn_CAT_DESCRPTION.OptionsColumn.AllowEdit = false;
            this.gridColumn_CAT_DESCRPTION.Visible = true;
            this.gridColumn_CAT_DESCRPTION.VisibleIndex = 3;
            // 
            // gridColumn_QTE_IN_STOCK
            // 
            this.gridColumn_QTE_IN_STOCK.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_QTE_IN_STOCK.AppearanceCell.Options.UseFont = true;
            this.gridColumn_QTE_IN_STOCK.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_QTE_IN_STOCK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_QTE_IN_STOCK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_QTE_IN_STOCK.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_QTE_IN_STOCK.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_QTE_IN_STOCK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_QTE_IN_STOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_QTE_IN_STOCK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_QTE_IN_STOCK.Caption = "المتوفر";
            this.gridColumn_QTE_IN_STOCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn_QTE_IN_STOCK.FieldName = "QTE_IN_STOCK";
            this.gridColumn_QTE_IN_STOCK.Name = "gridColumn_QTE_IN_STOCK";
            this.gridColumn_QTE_IN_STOCK.Visible = true;
            this.gridColumn_QTE_IN_STOCK.VisibleIndex = 4;
            // 
            // gridColumn_PRICE
            // 
            this.gridColumn_PRICE.AppearanceCell.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_PRICE.AppearanceCell.Options.UseFont = true;
            this.gridColumn_PRICE.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_PRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_PRICE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_PRICE.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_PRICE.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_PRICE.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_PRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_PRICE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_PRICE.Caption = "سعر البيع";
            this.gridColumn_PRICE.FieldName = "PRICE";
            this.gridColumn_PRICE.Name = "gridColumn_PRICE";
            this.gridColumn_PRICE.Visible = true;
            this.gridColumn_PRICE.VisibleIndex = 5;
            // 
            // gridColumn_IMAGE_PRODUCT
            // 
            this.gridColumn_IMAGE_PRODUCT.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_IMAGE_PRODUCT.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_IMAGE_PRODUCT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_IMAGE_PRODUCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_IMAGE_PRODUCT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_IMAGE_PRODUCT.Caption = "الصورة";
            this.gridColumn_IMAGE_PRODUCT.FieldName = "IMAGE_PRODUCT";
            this.gridColumn_IMAGE_PRODUCT.Name = "gridColumn_IMAGE_PRODUCT";
            this.gridColumn_IMAGE_PRODUCT.OptionsColumn.AllowEdit = false;
            this.gridColumn_IMAGE_PRODUCT.Visible = true;
            this.gridColumn_IMAGE_PRODUCT.VisibleIndex = 6;
            // 
            // repositoryItemTreeListLookUpEdit1
            // 
            this.repositoryItemTreeListLookUpEdit1.AutoHeight = false;
            this.repositoryItemTreeListLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEdit1.Name = "repositoryItemTreeListLookUpEdit1";
            this.repositoryItemTreeListLookUpEdit1.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridControl_PRODUCTS);
            this.groupBox2.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_ADD_NEW_PRODUCT);
            this.panel1.Controls.Add(this.button_CLOSE);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button_PRODUCT_PRICE_STOCK);
            this.panel1.Controls.Add(this.button_DELETE_PRODUCT);
            this.panel1.Controls.Add(this.button_PRINT_PRD);
            this.panel1.Controls.Add(this.button_PRODUCT_MODIFY);
            this.panel1.Controls.Add(this.button_ModifyPrdBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 85);
            this.panel1.TabIndex = 22;
            // 
            // button_ADD_NEW_PRODUCT
            // 
            this.button_ADD_NEW_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADD_NEW_PRODUCT.FlatAppearance.BorderSize = 2;
            this.button_ADD_NEW_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD_NEW_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADD_NEW_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.button_ADD_NEW_PRODUCT.Location = new System.Drawing.Point(871, 19);
            this.button_ADD_NEW_PRODUCT.Name = "button_ADD_NEW_PRODUCT";
            this.button_ADD_NEW_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.button_ADD_NEW_PRODUCT.TabIndex = 12;
            this.button_ADD_NEW_PRODUCT.Text = "منتوج  جديد";
            this.button_ADD_NEW_PRODUCT.UseVisualStyleBackColor = true;
            this.button_ADD_NEW_PRODUCT.Click += new System.EventHandler(this.button_ADD_NEW_PRODUCT_Click);
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CLOSE.FlatAppearance.BorderSize = 2;
            this.button_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CLOSE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CLOSE.ForeColor = System.Drawing.Color.White;
            this.button_CLOSE.Location = new System.Drawing.Point(61, 19);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(100, 50);
            this.button_CLOSE.TabIndex = 18;
            this.button_CLOSE.Text = "خروج";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(172, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 50);
            this.button8.TabIndex = 19;
            this.button8.Text = "ملف اكسل";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button_PRODUCT_PRICE_STOCK
            // 
            this.button_PRODUCT_PRICE_STOCK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRODUCT_PRICE_STOCK.FlatAppearance.BorderSize = 2;
            this.button_PRODUCT_PRICE_STOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCT_PRICE_STOCK.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRODUCT_PRICE_STOCK.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCT_PRICE_STOCK.Location = new System.Drawing.Point(538, 19);
            this.button_PRODUCT_PRICE_STOCK.Name = "button_PRODUCT_PRICE_STOCK";
            this.button_PRODUCT_PRICE_STOCK.Size = new System.Drawing.Size(100, 50);
            this.button_PRODUCT_PRICE_STOCK.TabIndex = 20;
            this.button_PRODUCT_PRICE_STOCK.Text = "سعر و مخزن";
            this.button_PRODUCT_PRICE_STOCK.UseVisualStyleBackColor = true;
            this.button_PRODUCT_PRICE_STOCK.Click += new System.EventHandler(this.button_PRODUCT_PRICE_STOCK_Click);
            // 
            // button_DELETE_PRODUCT
            // 
            this.button_DELETE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DELETE_PRODUCT.FlatAppearance.BorderSize = 2;
            this.button_DELETE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DELETE_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_DELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.button_DELETE_PRODUCT.Location = new System.Drawing.Point(760, 19);
            this.button_DELETE_PRODUCT.Name = "button_DELETE_PRODUCT";
            this.button_DELETE_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.button_DELETE_PRODUCT.TabIndex = 13;
            this.button_DELETE_PRODUCT.Text = "حذف منتوج";
            this.button_DELETE_PRODUCT.UseVisualStyleBackColor = true;
            this.button_DELETE_PRODUCT.Click += new System.EventHandler(this.button_DELETE_PRODUCT_Click);
            // 
            // button_PRINT_PRD
            // 
            this.button_PRINT_PRD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRINT_PRD.FlatAppearance.BorderSize = 2;
            this.button_PRINT_PRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRINT_PRD.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRINT_PRD.ForeColor = System.Drawing.Color.White;
            this.button_PRINT_PRD.Location = new System.Drawing.Point(274, 19);
            this.button_PRINT_PRD.Name = "button_PRINT_PRD";
            this.button_PRINT_PRD.Size = new System.Drawing.Size(142, 50);
            this.button_PRINT_PRD.TabIndex = 17;
            this.button_PRINT_PRD.Text = "طباعة كل منتوجات";
            this.button_PRINT_PRD.UseVisualStyleBackColor = true;
            this.button_PRINT_PRD.Click += new System.EventHandler(this.button_PRINT_PRD_Click);
            // 
            // button_PRODUCT_MODIFY
            // 
            this.button_PRODUCT_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRODUCT_MODIFY.FlatAppearance.BorderSize = 2;
            this.button_PRODUCT_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRODUCT_MODIFY.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRODUCT_MODIFY.ForeColor = System.Drawing.Color.White;
            this.button_PRODUCT_MODIFY.Location = new System.Drawing.Point(649, 19);
            this.button_PRODUCT_MODIFY.Name = "button_PRODUCT_MODIFY";
            this.button_PRODUCT_MODIFY.Size = new System.Drawing.Size(100, 50);
            this.button_PRODUCT_MODIFY.TabIndex = 14;
            this.button_PRODUCT_MODIFY.Text = "تعديل منتوج";
            this.button_PRODUCT_MODIFY.UseVisualStyleBackColor = true;
            this.button_PRODUCT_MODIFY.Click += new System.EventHandler(this.button_PRODUCT_MODIFY_Click);
            // 
            // button_ModifyPrdBarcode
            // 
            this.button_ModifyPrdBarcode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ModifyPrdBarcode.FlatAppearance.BorderSize = 2;
            this.button_ModifyPrdBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ModifyPrdBarcode.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ModifyPrdBarcode.ForeColor = System.Drawing.Color.White;
            this.button_ModifyPrdBarcode.Location = new System.Drawing.Point(427, 19);
            this.button_ModifyPrdBarcode.Name = "button_ModifyPrdBarcode";
            this.button_ModifyPrdBarcode.Size = new System.Drawing.Size(100, 50);
            this.button_ModifyPrdBarcode.TabIndex = 16;
            this.button_ModifyPrdBarcode.Text = "تعديل باركود";
            this.button_ModifyPrdBarcode.UseVisualStyleBackColor = true;
            this.button_ModifyPrdBarcode.Click += new System.EventHandler(this.button_ModifyPrdBarcode_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MNG_PRODUCTS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "أدارة المنتوجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SEARCH_PRODUCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button button_PRINT_PRD;
        private System.Windows.Forms.Button button_ModifyPrdBarcode;
        private System.Windows.Forms.Button button_PRODUCT_MODIFY;
        private System.Windows.Forms.Button button_DELETE_PRODUCT;
        private System.Windows.Forms.Button button_ADD_NEW_PRODUCT;
        private System.Windows.Forms.Button button_PRODUCT_PRICE_STOCK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ID_PRODUCT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_BARCODE_PRODUCT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_LABEL_PRODUCT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_CAT_DESCRPTION;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_QTE_IN_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_IMAGE_PRODUCT;
        public DevExpress.XtraGrid.GridControl GridControl_PRODUCTS;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.Button button_AllPrd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}