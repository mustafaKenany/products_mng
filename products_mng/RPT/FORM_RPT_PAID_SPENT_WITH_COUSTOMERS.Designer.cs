namespace products_mng.RPT
{
    partial class FORM_RPT_PAID_SPENT_WITH_COUSTOMERS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_END_DATE = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.button_COUST_WITH_ALL_DAILY_SPENT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_COUST_WITH_ALL_SPENT = new System.Windows.Forms.Button();
            this.button_PRT_COUST_WITH_ALL_RECIPT = new System.Windows.Forms.Button();
            this.button_DISPLAY_DATA = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_PAID_SPENT = new DevExpress.XtraGrid.GridControl();
            this.gridView_PAID_SPENT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_COUSTOMERS = new DevExpress.XtraGrid.GridControl();
            this.gridView_COUST = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_COUST_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_TEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_COUST_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_ID_COUSTOMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PAID_SPENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PAID_SPENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_COUST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_END_DATE);
            this.groupBox1.Controls.Add(this.dateTimePicker_BEGIN_DATE);
            this.groupBox1.Controls.Add(this.button_COUST_WITH_ALL_DAILY_SPENT);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button_COUST_WITH_ALL_SPENT);
            this.groupBox1.Controls.Add(this.button_PRT_COUST_WITH_ALL_RECIPT);
            this.groupBox1.Controls.Add(this.button_DISPLAY_DATA);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاجراءات الممكنة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "الى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "من";
            // 
            // dateTimePicker_END_DATE
            // 
            this.dateTimePicker_END_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_END_DATE.Location = new System.Drawing.Point(10, 62);
            this.dateTimePicker_END_DATE.Name = "dateTimePicker_END_DATE";
            this.dateTimePicker_END_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_END_DATE.TabIndex = 59;
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(10, 22);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 58;
            // 
            // button_COUST_WITH_ALL_DAILY_SPENT
            // 
            this.button_COUST_WITH_ALL_DAILY_SPENT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_COUST_WITH_ALL_DAILY_SPENT.FlatAppearance.BorderSize = 2;
            this.button_COUST_WITH_ALL_DAILY_SPENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_COUST_WITH_ALL_DAILY_SPENT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_COUST_WITH_ALL_DAILY_SPENT.ForeColor = System.Drawing.Color.White;
            this.button_COUST_WITH_ALL_DAILY_SPENT.Location = new System.Drawing.Point(696, 26);
            this.button_COUST_WITH_ALL_DAILY_SPENT.Name = "button_COUST_WITH_ALL_DAILY_SPENT";
            this.button_COUST_WITH_ALL_DAILY_SPENT.Size = new System.Drawing.Size(139, 66);
            this.button_COUST_WITH_ALL_DAILY_SPENT.TabIndex = 56;
            this.button_COUST_WITH_ALL_DAILY_SPENT.Text = "طباعة كل المصروفات اليومية";
            this.button_COUST_WITH_ALL_DAILY_SPENT.UseVisualStyleBackColor = true;
            this.button_COUST_WITH_ALL_DAILY_SPENT.Click += new System.EventHandler(this.button_COUST_WITH_ALL_DAILY_SPENT_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(590, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 66);
            this.button3.TabIndex = 55;
            this.button3.Text = "طباعة كل حركات";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_COUST_WITH_ALL_SPENT
            // 
            this.button_COUST_WITH_ALL_SPENT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_COUST_WITH_ALL_SPENT.FlatAppearance.BorderSize = 2;
            this.button_COUST_WITH_ALL_SPENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_COUST_WITH_ALL_SPENT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_COUST_WITH_ALL_SPENT.ForeColor = System.Drawing.Color.White;
            this.button_COUST_WITH_ALL_SPENT.Location = new System.Drawing.Point(841, 26);
            this.button_COUST_WITH_ALL_SPENT.Name = "button_COUST_WITH_ALL_SPENT";
            this.button_COUST_WITH_ALL_SPENT.Size = new System.Drawing.Size(109, 66);
            this.button_COUST_WITH_ALL_SPENT.TabIndex = 54;
            this.button_COUST_WITH_ALL_SPENT.Text = "طباعة كل المصروفات";
            this.button_COUST_WITH_ALL_SPENT.UseVisualStyleBackColor = true;
            this.button_COUST_WITH_ALL_SPENT.Click += new System.EventHandler(this.button_COUST_WITH_ALL_SPENT_Click);
            // 
            // button_PRT_COUST_WITH_ALL_RECIPT
            // 
            this.button_PRT_COUST_WITH_ALL_RECIPT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRT_COUST_WITH_ALL_RECIPT.FlatAppearance.BorderSize = 2;
            this.button_PRT_COUST_WITH_ALL_RECIPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRT_COUST_WITH_ALL_RECIPT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRT_COUST_WITH_ALL_RECIPT.ForeColor = System.Drawing.Color.White;
            this.button_PRT_COUST_WITH_ALL_RECIPT.Location = new System.Drawing.Point(956, 26);
            this.button_PRT_COUST_WITH_ALL_RECIPT.Name = "button_PRT_COUST_WITH_ALL_RECIPT";
            this.button_PRT_COUST_WITH_ALL_RECIPT.Size = new System.Drawing.Size(107, 66);
            this.button_PRT_COUST_WITH_ALL_RECIPT.TabIndex = 53;
            this.button_PRT_COUST_WITH_ALL_RECIPT.Text = "طباعة كل المقبوضات";
            this.button_PRT_COUST_WITH_ALL_RECIPT.UseVisualStyleBackColor = true;
            this.button_PRT_COUST_WITH_ALL_RECIPT.Click += new System.EventHandler(this.button_PRT_COUST_WITH_ALL_RECIPT_Click);
            // 
            // button_DISPLAY_DATA
            // 
            this.button_DISPLAY_DATA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DISPLAY_DATA.FlatAppearance.BorderSize = 2;
            this.button_DISPLAY_DATA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DISPLAY_DATA.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_DISPLAY_DATA.ForeColor = System.Drawing.Color.White;
            this.button_DISPLAY_DATA.Location = new System.Drawing.Point(1069, 26);
            this.button_DISPLAY_DATA.Name = "button_DISPLAY_DATA";
            this.button_DISPLAY_DATA.Size = new System.Drawing.Size(100, 66);
            this.button_DISPLAY_DATA.TabIndex = 52;
            this.button_DISPLAY_DATA.Text = "عرض الكل";
            this.button_DISPLAY_DATA.UseVisualStyleBackColor = true;
            this.button_DISPLAY_DATA.Click += new System.EventHandler(this.button_DISPLAY_DATA_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.38983F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.61017F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl_PAID_SPENT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl_COUSTOMERS, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 478);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gridControl_PAID_SPENT
            // 
            this.gridControl_PAID_SPENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_PAID_SPENT.Location = new System.Drawing.Point(3, 3);
            this.gridControl_PAID_SPENT.MainView = this.gridView_PAID_SPENT;
            this.gridControl_PAID_SPENT.Name = "gridControl_PAID_SPENT";
            this.gridControl_PAID_SPENT.Size = new System.Drawing.Size(780, 472);
            this.gridControl_PAID_SPENT.TabIndex = 5;
            this.gridControl_PAID_SPENT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PAID_SPENT});
            // 
            // gridView_PAID_SPENT
            // 
            this.gridView_PAID_SPENT.Appearance.FooterPanel.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridView_PAID_SPENT.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView_PAID_SPENT.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView_PAID_SPENT.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PAID_SPENT.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_PAID_SPENT.Appearance.GroupFooter.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridView_PAID_SPENT.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView_PAID_SPENT.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView_PAID_SPENT.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_PAID_SPENT.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_PAID_SPENT.Appearance.GroupPanel.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridView_PAID_SPENT.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView_PAID_SPENT.Appearance.GroupRow.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridView_PAID_SPENT.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_PAID_SPENT.ColumnPanelRowHeight = 30;
            this.gridView_PAID_SPENT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView_PAID_SPENT.FooterPanelHeight = 30;
            this.gridView_PAID_SPENT.GridControl = this.gridControl_PAID_SPENT;
            this.gridView_PAID_SPENT.GroupRowHeight = 30;
            this.gridView_PAID_SPENT.Name = "gridView_PAID_SPENT";
            this.gridView_PAID_SPENT.OptionsView.ShowAutoFilterRow = true;
            this.gridView_PAID_SPENT.OptionsView.ShowGroupPanel = false;
            this.gridView_PAID_SPENT.RowHeight = 30;
            this.gridView_PAID_SPENT.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.gridColumn1.Caption = "رقم المستند";
            this.gridColumn1.FieldName = "PAID_SPENT_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Width = 114;
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
            this.gridColumn2.Caption = "أسم الزبون";
            this.gridColumn2.FieldName = "COUST_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 189;
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
            this.gridColumn3.Caption = "المبلغ";
            this.gridColumn3.DisplayFormat.FormatString = "n1";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "THE_AMOUNT";
            this.gridColumn3.GroupFormat.FormatString = "n1";
            this.gridColumn3.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowSize = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THE_AMOUNT", "SUM={0:n1}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 101;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "تاريخ";
            this.gridColumn4.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "PAID_SPENT_DATE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSize = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "نوع مستند";
            this.gridColumn5.FieldName = "PAID_SPENT_TYPE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSize = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 119;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "ملاحظات";
            this.gridColumn6.FieldName = "NOTS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 184;
            // 
            // gridControl_COUSTOMERS
            // 
            this.gridControl_COUSTOMERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_COUSTOMERS.Location = new System.Drawing.Point(789, 3);
            this.gridControl_COUSTOMERS.MainView = this.gridView_COUST;
            this.gridControl_COUSTOMERS.Name = "gridControl_COUSTOMERS";
            this.gridControl_COUSTOMERS.Size = new System.Drawing.Size(388, 472);
            this.gridControl_COUSTOMERS.TabIndex = 4;
            this.gridControl_COUSTOMERS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_COUST});
            // 
            // gridView_COUST
            // 
            this.gridView_COUST.ColumnPanelRowHeight = 30;
            this.gridView_COUST.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_COUST_NAME,
            this.gridColumn_ADDRESS,
            this.gridColumn_TEL,
            this.gridColumn_COUST_TYPE,
            this.gridColumn_ID_COUSTOMER});
            this.gridView_COUST.GridControl = this.gridControl_COUSTOMERS;
            this.gridView_COUST.Name = "gridView_COUST";
            this.gridView_COUST.OptionsView.ShowAutoFilterRow = true;
            this.gridView_COUST.OptionsView.ShowGroupPanel = false;
            this.gridView_COUST.RowHeight = 30;
            this.gridView_COUST.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn_ID_COUSTOMER, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn_COUST_NAME
            // 
            this.gridColumn_COUST_NAME.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_COUST_NAME.AppearanceCell.Options.UseFont = true;
            this.gridColumn_COUST_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_COUST_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_COUST_NAME.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_COUST_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_COUST_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_NAME.Caption = "أسم الزبون";
            this.gridColumn_COUST_NAME.FieldName = "COUST_NAME";
            this.gridColumn_COUST_NAME.Name = "gridColumn_COUST_NAME";
            this.gridColumn_COUST_NAME.OptionsColumn.AllowEdit = false;
            this.gridColumn_COUST_NAME.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_COUST_NAME.OptionsColumn.AllowMove = false;
            this.gridColumn_COUST_NAME.OptionsColumn.AllowShowHide = false;
            this.gridColumn_COUST_NAME.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_COUST_NAME.Visible = true;
            this.gridColumn_COUST_NAME.VisibleIndex = 1;
            this.gridColumn_COUST_NAME.Width = 191;
            // 
            // gridColumn_ADDRESS
            // 
            this.gridColumn_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.gridColumn_ADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_ADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ADDRESS.Caption = "العنوان";
            this.gridColumn_ADDRESS.FieldName = "ADDRESS";
            this.gridColumn_ADDRESS.Name = "gridColumn_ADDRESS";
            this.gridColumn_ADDRESS.OptionsColumn.AllowEdit = false;
            this.gridColumn_ADDRESS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_ADDRESS.OptionsColumn.AllowMove = false;
            this.gridColumn_ADDRESS.OptionsColumn.AllowShowHide = false;
            this.gridColumn_ADDRESS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn_TEL
            // 
            this.gridColumn_TEL.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_TEL.AppearanceCell.Options.UseFont = true;
            this.gridColumn_TEL.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_TEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_TEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_TEL.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_TEL.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_TEL.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_TEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_TEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_TEL.Caption = "رقم الموبايل";
            this.gridColumn_TEL.FieldName = "TEL";
            this.gridColumn_TEL.Name = "gridColumn_TEL";
            this.gridColumn_TEL.OptionsColumn.AllowEdit = false;
            this.gridColumn_TEL.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_TEL.OptionsColumn.AllowMove = false;
            this.gridColumn_TEL.OptionsColumn.AllowShowHide = false;
            this.gridColumn_TEL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn_COUST_TYPE
            // 
            this.gridColumn_COUST_TYPE.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_COUST_TYPE.AppearanceCell.Options.UseFont = true;
            this.gridColumn_COUST_TYPE.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_COUST_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_COUST_TYPE.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_COUST_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_COUST_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_TYPE.Caption = "صنف الزبون";
            this.gridColumn_COUST_TYPE.FieldName = "COUST_TYPE";
            this.gridColumn_COUST_TYPE.Name = "gridColumn_COUST_TYPE";
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowEdit = false;
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowMove = false;
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowShowHide = false;
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_COUST_TYPE.Visible = true;
            this.gridColumn_COUST_TYPE.VisibleIndex = 2;
            this.gridColumn_COUST_TYPE.Width = 120;
            // 
            // gridColumn_ID_COUSTOMER
            // 
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Options.UseFont = true;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_COUSTOMER.Caption = "ID";
            this.gridColumn_ID_COUSTOMER.FieldName = "ID_COUSTOMER";
            this.gridColumn_ID_COUSTOMER.Name = "gridColumn_ID_COUSTOMER";
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowEdit = false;
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowMove = false;
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowShowHide = false;
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn_ID_COUSTOMER.Visible = true;
            this.gridColumn_ID_COUSTOMER.VisibleIndex = 0;
            this.gridColumn_ID_COUSTOMER.Width = 59;
            // 
            // FORM_RPT_PAID_SPENT_WITH_COUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1180, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_RPT_PAID_SPENT_WITH_COUSTOMERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقرير المستندات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PAID_SPENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PAID_SPENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_COUST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_END_DATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
        public System.Windows.Forms.Button button_COUST_WITH_ALL_DAILY_SPENT;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button_COUST_WITH_ALL_SPENT;
        public System.Windows.Forms.Button button_PRT_COUST_WITH_ALL_RECIPT;
        public System.Windows.Forms.Button button_DISPLAY_DATA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraGrid.GridControl gridControl_COUSTOMERS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_COUST;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_COUST_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_TEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_COUST_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ID_COUSTOMER;
        private DevExpress.XtraGrid.GridControl gridControl_PAID_SPENT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PAID_SPENT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}