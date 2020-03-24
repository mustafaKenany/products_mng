namespace products_mng.PL
{
    partial class FORM_MNG_CATEGORIES
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
            this.button_CANCEL_CAT = new System.Windows.Forms.Button();
            this.button_ADD_NEW_CAT = new System.Windows.Forms.Button();
            this.textBox_Cat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.button_CAT_DLT = new System.Windows.Forms.Button();
            this.button_CAT_MODIFY = new System.Windows.Forms.Button();
            this.button_PRINT = new System.Windows.Forms.Button();
            this.gridControl_CAT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.documentViewer1);
            this.groupBox1.Controls.Add(this.button_CANCEL_CAT);
            this.groupBox1.Controls.Add(this.button_ADD_NEW_CAT);
            this.groupBox1.Controls.Add(this.textBox_Cat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أدارة صنف جديد";
            // 
            // button_CANCEL_CAT
            // 
            this.button_CANCEL_CAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CANCEL_CAT.FlatAppearance.BorderSize = 2;
            this.button_CANCEL_CAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CANCEL_CAT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CANCEL_CAT.ForeColor = System.Drawing.Color.White;
            this.button_CANCEL_CAT.Location = new System.Drawing.Point(262, 43);
            this.button_CANCEL_CAT.Name = "button_CANCEL_CAT";
            this.button_CANCEL_CAT.Size = new System.Drawing.Size(100, 50);
            this.button_CANCEL_CAT.TabIndex = 14;
            this.button_CANCEL_CAT.Text = "الغاء";
            this.button_CANCEL_CAT.UseVisualStyleBackColor = true;
            this.button_CANCEL_CAT.Click += new System.EventHandler(this.button_CANCEL_CAT_Click);
            // 
            // button_ADD_NEW_CAT
            // 
            this.button_ADD_NEW_CAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADD_NEW_CAT.FlatAppearance.BorderSize = 2;
            this.button_ADD_NEW_CAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD_NEW_CAT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADD_NEW_CAT.ForeColor = System.Drawing.Color.White;
            this.button_ADD_NEW_CAT.Location = new System.Drawing.Point(384, 43);
            this.button_ADD_NEW_CAT.Name = "button_ADD_NEW_CAT";
            this.button_ADD_NEW_CAT.Size = new System.Drawing.Size(100, 50);
            this.button_ADD_NEW_CAT.TabIndex = 13;
            this.button_ADD_NEW_CAT.Text = "أضافة";
            this.button_ADD_NEW_CAT.UseVisualStyleBackColor = true;
            this.button_ADD_NEW_CAT.Click += new System.EventHandler(this.button_ADD_NEW_CAT_Click);
            // 
            // textBox_Cat
            // 
            this.textBox_Cat.Location = new System.Drawing.Point(506, 51);
            this.textBox_Cat.Name = "textBox_Cat";
            this.textBox_Cat.Size = new System.Drawing.Size(300, 34);
            this.textBox_Cat.TabIndex = 0;
            this.textBox_Cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_CLOSE);
            this.panel1.Controls.Add(this.button_CAT_DLT);
            this.panel1.Controls.Add(this.button_CAT_MODIFY);
            this.panel1.Controls.Add(this.button_PRINT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 85);
            this.panel1.TabIndex = 23;
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
            this.button_CLOSE.Size = new System.Drawing.Size(132, 50);
            this.button_CLOSE.TabIndex = 18;
            this.button_CLOSE.Text = "خروج";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // button_CAT_DLT
            // 
            this.button_CAT_DLT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CAT_DLT.FlatAppearance.BorderSize = 2;
            this.button_CAT_DLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CAT_DLT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CAT_DLT.ForeColor = System.Drawing.Color.White;
            this.button_CAT_DLT.Location = new System.Drawing.Point(453, 19);
            this.button_CAT_DLT.Name = "button_CAT_DLT";
            this.button_CAT_DLT.Size = new System.Drawing.Size(132, 50);
            this.button_CAT_DLT.TabIndex = 20;
            this.button_CAT_DLT.Text = "حذف الصنف";
            this.button_CAT_DLT.UseVisualStyleBackColor = true;
            this.button_CAT_DLT.Click += new System.EventHandler(this.button_CAT_DLT_Click);
            // 
            // button_CAT_MODIFY
            // 
            this.button_CAT_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CAT_MODIFY.FlatAppearance.BorderSize = 2;
            this.button_CAT_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CAT_MODIFY.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CAT_MODIFY.ForeColor = System.Drawing.Color.White;
            this.button_CAT_MODIFY.Location = new System.Drawing.Point(649, 19);
            this.button_CAT_MODIFY.Name = "button_CAT_MODIFY";
            this.button_CAT_MODIFY.Size = new System.Drawing.Size(132, 50);
            this.button_CAT_MODIFY.TabIndex = 14;
            this.button_CAT_MODIFY.Text = "تعديل الصنف";
            this.button_CAT_MODIFY.UseVisualStyleBackColor = true;
            this.button_CAT_MODIFY.Click += new System.EventHandler(this.button_CAT_MODIFY_Click);
            // 
            // button_PRINT
            // 
            this.button_PRINT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRINT.FlatAppearance.BorderSize = 2;
            this.button_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRINT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRINT.ForeColor = System.Drawing.Color.White;
            this.button_PRINT.Location = new System.Drawing.Point(257, 19);
            this.button_PRINT.Name = "button_PRINT";
            this.button_PRINT.Size = new System.Drawing.Size(132, 50);
            this.button_PRINT.TabIndex = 16;
            this.button_PRINT.Text = "طباعة";
            this.button_PRINT.UseVisualStyleBackColor = true;
            this.button_PRINT.Click += new System.EventHandler(this.button_PRINT_Click);
            // 
            // gridControl_CAT
            // 
            this.gridControl_CAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_CAT.Location = new System.Drawing.Point(0, 113);
            this.gridControl_CAT.MainView = this.gridView1;
            this.gridControl_CAT.Name = "gridControl_CAT";
            this.gridControl_CAT.Size = new System.Drawing.Size(830, 360);
            this.gridControl_CAT.TabIndex = 24;
            this.gridControl_CAT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FooterPanelHeight = 30;
            this.gridView1.GridControl = this.gridControl_CAT;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 30;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "تسلسل الصنف";
            this.gridColumn1.FieldName = "ID_CAT";
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
            this.gridColumn2.Caption = "أسم الصنف";
            this.gridColumn2.FieldName = "CAT_DESCRPTION";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.documentViewer1.DocumentSource = this.printingSystem1;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(3, 30);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(226, 80);
            this.documentViewer1.TabIndex = 15;
            this.documentViewer1.Visible = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl_CAT;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.RightToLeftLayout = true;
            // 
            // FORM_MNG_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 558);
            this.Controls.Add(this.gridControl_CAT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MNG_CATEGORIES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أدارة الاصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Cat;
        private System.Windows.Forms.Button button_CANCEL_CAT;
        private System.Windows.Forms.Button button_ADD_NEW_CAT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.Button button_CAT_DLT;
        private System.Windows.Forms.Button button_CAT_MODIFY;
        private System.Windows.Forms.Button button_PRINT;
        private DevExpress.XtraGrid.GridControl gridControl_CAT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
    }
}