namespace products_mng.PL
{
    partial class FORM_RPT_SALES
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.gridControl_ALLSALES = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_BTNS = new System.Windows.Forms.Panel();
            this.button_INVOSDETLS = new System.Windows.Forms.Button();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_ENDATE = new System.Windows.Forms.DateTimePicker();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.button_PRTINVO = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button_PRTGRID = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_ALSALES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ALLSALES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel_BTNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(147, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "الى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(147, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "من";
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_BEGIN_DATE.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(138, 30);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 14;
            // 
            // gridControl_ALLSALES
            // 
            this.gridControl_ALLSALES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ALLSALES.Location = new System.Drawing.Point(5, 65);
            this.gridControl_ALLSALES.MainView = this.gridView1;
            this.gridControl_ALLSALES.Name = "gridControl_ALLSALES";
            this.gridControl_ALLSALES.Size = new System.Drawing.Size(1224, 542);
            this.gridControl_ALLSALES.TabIndex = 3;
            this.gridControl_ALLSALES.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn10,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView1.GridControl = this.gridControl_ALLSALES;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 30;
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
            this.gridColumn1.Caption = "رقم الزبون";
            this.gridColumn1.FieldName = "ID_COUSTOMER";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
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
            this.gridColumn2.Caption = "أسم الزبون";
            this.gridColumn2.FieldName = "COUST_NAME";
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
            this.gridColumn3.Caption = "صنف الزبون";
            this.gridColumn3.FieldName = "COUST_TYPE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "رقم القائمة";
            this.gridColumn4.FieldName = "ID_ORDER";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "تاريخ قائمة";
            this.gridColumn10.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn10.FieldName = "ORDER_DATE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "اجل/نقد";
            this.gridColumn5.FieldName = "PAID_OR_NOT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "مبلغ القائمة";
            this.gridColumn6.FieldName = "TOTAL_AMOUNT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.Caption = "الخصم";
            this.gridColumn7.FieldName = "DISCOUNT_AMOUNT";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.Caption = "الواصل";
            this.gridColumn8.FieldName = "PAID_AMOUNT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "متبقي القائمة";
            this.gridColumn9.FieldName = "REMINDER_AMOUNT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // panel_BTNS
            // 
            this.panel_BTNS.Controls.Add(this.button_INVOSDETLS);
            this.panel_BTNS.Controls.Add(this.documentViewer1);
            this.panel_BTNS.Controls.Add(this.tableLayoutPanel1);
            this.panel_BTNS.Controls.Add(this.splitter3);
            this.panel_BTNS.Controls.Add(this.button_PRTINVO);
            this.panel_BTNS.Controls.Add(this.splitter2);
            this.panel_BTNS.Controls.Add(this.button_PRTGRID);
            this.panel_BTNS.Controls.Add(this.splitter1);
            this.panel_BTNS.Controls.Add(this.button_ALSALES);
            this.panel_BTNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BTNS.Location = new System.Drawing.Point(5, 5);
            this.panel_BTNS.Name = "panel_BTNS";
            this.panel_BTNS.Padding = new System.Windows.Forms.Padding(3);
            this.panel_BTNS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_BTNS.Size = new System.Drawing.Size(1224, 60);
            this.panel_BTNS.TabIndex = 21;
            // 
            // button_INVOSDETLS
            // 
            this.button_INVOSDETLS.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_INVOSDETLS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_INVOSDETLS.FlatAppearance.BorderSize = 2;
            this.button_INVOSDETLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INVOSDETLS.ForeColor = System.Drawing.Color.White;
            this.button_INVOSDETLS.Location = new System.Drawing.Point(806, 3);
            this.button_INVOSDETLS.Margin = new System.Windows.Forms.Padding(10);
            this.button_INVOSDETLS.Name = "button_INVOSDETLS";
            this.button_INVOSDETLS.Size = new System.Drawing.Size(100, 54);
            this.button_INVOSDETLS.TabIndex = 21;
            this.button_INVOSDETLS.Text = "كل تفاصيل";
            this.button_INVOSDETLS.UseVisualStyleBackColor = false;
            this.button_INVOSDETLS.Click += new System.EventHandler(this.button_INVOSDETLS_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentViewer1.DocumentSource = this.printingSystem1;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(203, 3);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(211, 54);
            this.documentViewer1.TabIndex = 20;
            this.documentViewer1.Visible = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl_ALLSALES;
            this.printableComponentLink1.Landscape = true;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "قوائم كل المبيعات",
                "",
                ""}, new System.Drawing.Font("Tahoma", 8F), DevExpress.XtraPrinting.BrickAlignment.Near), null);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.RightToLeftLayout = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_ENDATE, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_BEGIN_DATE, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 54);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // dateTimePicker_ENDATE
            // 
            this.dateTimePicker_ENDATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_ENDATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ENDATE.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePicker_ENDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ENDATE.Location = new System.Drawing.Point(3, 30);
            this.dateTimePicker_ENDATE.Name = "dateTimePicker_ENDATE";
            this.dateTimePicker_ENDATE.Size = new System.Drawing.Size(138, 30);
            this.dateTimePicker_ENDATE.TabIndex = 18;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(906, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 54);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // button_PRTINVO
            // 
            this.button_PRTINVO.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PRTINVO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRTINVO.FlatAppearance.BorderSize = 2;
            this.button_PRTINVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRTINVO.ForeColor = System.Drawing.Color.White;
            this.button_PRTINVO.Location = new System.Drawing.Point(911, 3);
            this.button_PRTINVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_PRTINVO.Name = "button_PRTINVO";
            this.button_PRTINVO.Size = new System.Drawing.Size(100, 54);
            this.button_PRTINVO.TabIndex = 7;
            this.button_PRTINVO.Text = "طبع القائمة";
            this.button_PRTINVO.UseVisualStyleBackColor = false;
            this.button_PRTINVO.Click += new System.EventHandler(this.button_PRTINVO_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1011, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 54);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // button_PRTGRID
            // 
            this.button_PRTGRID.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PRTGRID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRTGRID.FlatAppearance.BorderSize = 2;
            this.button_PRTGRID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRTGRID.ForeColor = System.Drawing.Color.White;
            this.button_PRTGRID.Location = new System.Drawing.Point(1016, 3);
            this.button_PRTGRID.Margin = new System.Windows.Forms.Padding(10);
            this.button_PRTGRID.Name = "button_PRTGRID";
            this.button_PRTGRID.Size = new System.Drawing.Size(96, 54);
            this.button_PRTGRID.TabIndex = 5;
            this.button_PRTGRID.Text = "طباعة الكل";
            this.button_PRTGRID.UseVisualStyleBackColor = false;
            this.button_PRTGRID.Click += new System.EventHandler(this.button_PRTGRID_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(1112, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 54);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // button_ALSALES
            // 
            this.button_ALSALES.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ALSALES.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ALSALES.FlatAppearance.BorderSize = 2;
            this.button_ALSALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ALSALES.ForeColor = System.Drawing.Color.White;
            this.button_ALSALES.Location = new System.Drawing.Point(1117, 3);
            this.button_ALSALES.Margin = new System.Windows.Forms.Padding(10);
            this.button_ALSALES.Name = "button_ALSALES";
            this.button_ALSALES.Size = new System.Drawing.Size(104, 54);
            this.button_ALSALES.TabIndex = 3;
            this.button_ALSALES.Text = "عرض البيانات";
            this.button_ALSALES.UseVisualStyleBackColor = false;
            this.button_ALSALES.Click += new System.EventHandler(this.button_ALSALES_Click);
            // 
            // FORM_RPT_SALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1234, 612);
            this.Controls.Add(this.gridControl_ALLSALES);
            this.Controls.Add(this.panel_BTNS);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_RPT_SALES";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير مبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ALLSALES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel_BTNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
        private DevExpress.XtraGrid.GridControl gridControl_ALLSALES;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Panel panel_BTNS;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button button_PRTINVO;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button button_PRTGRID;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_ALSALES;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ENDATE;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Button button_INVOSDETLS;
    }
}