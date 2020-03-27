namespace products_mng.PL
{
    partial class FORM_COUSTOMERS_SELECT
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
            this.panel_TXTBOX = new System.Windows.Forms.Panel();
            this.textBox_COUST_FILTER = new System.Windows.Forms.TextBox();
            this.button_NEW_INVO = new System.Windows.Forms.Button();
            this.gridControl_COUSTOMERS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_BTN = new System.Windows.Forms.Panel();
            this.panel_TXTBOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel_BTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TXTBOX
            // 
            this.panel_TXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TXTBOX.Controls.Add(this.textBox_COUST_FILTER);
            this.panel_TXTBOX.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TXTBOX.Location = new System.Drawing.Point(0, 0);
            this.panel_TXTBOX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_TXTBOX.Name = "panel_TXTBOX";
            this.panel_TXTBOX.Padding = new System.Windows.Forms.Padding(5);
            this.panel_TXTBOX.Size = new System.Drawing.Size(534, 49);
            this.panel_TXTBOX.TabIndex = 0;
            // 
            // textBox_COUST_FILTER
            // 
            this.textBox_COUST_FILTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_COUST_FILTER.Location = new System.Drawing.Point(5, 5);
            this.textBox_COUST_FILTER.Multiline = true;
            this.textBox_COUST_FILTER.Name = "textBox_COUST_FILTER";
            this.textBox_COUST_FILTER.Size = new System.Drawing.Size(520, 35);
            this.textBox_COUST_FILTER.TabIndex = 5;
            this.textBox_COUST_FILTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_COUST_FILTER.TextChanged += new System.EventHandler(this.textBox_COUST_FILTER_TextChanged);
            // 
            // button_NEW_INVO
            // 
            this.button_NEW_INVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.button_NEW_INVO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_NEW_INVO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_NEW_INVO.FlatAppearance.BorderSize = 2;
            this.button_NEW_INVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NEW_INVO.ForeColor = System.Drawing.Color.White;
            this.button_NEW_INVO.Location = new System.Drawing.Point(5, 5);
            this.button_NEW_INVO.Margin = new System.Windows.Forms.Padding(10);
            this.button_NEW_INVO.Name = "button_NEW_INVO";
            this.button_NEW_INVO.Size = new System.Drawing.Size(520, 49);
            this.button_NEW_INVO.TabIndex = 4;
            this.button_NEW_INVO.Text = "اختيار";
            this.button_NEW_INVO.UseVisualStyleBackColor = false;
            this.button_NEW_INVO.Click += new System.EventHandler(this.button_NEW_INVO_Click);
            // 
            // gridControl_COUSTOMERS
            // 
            this.gridControl_COUSTOMERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_COUSTOMERS.Location = new System.Drawing.Point(0, 112);
            this.gridControl_COUSTOMERS.MainView = this.gridView1;
            this.gridControl_COUSTOMERS.Name = "gridControl_COUSTOMERS";
            this.gridControl_COUSTOMERS.Size = new System.Drawing.Size(534, 550);
            this.gridControl_COUSTOMERS.TabIndex = 1;
            this.gridControl_COUSTOMERS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl_COUSTOMERS;
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
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID_COUSTOMER";
            this.gridColumn1.Name = "gridColumn1";
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
            this.gridColumn2.Caption = "الاسم";
            this.gridColumn2.FieldName = "COUST_NAME";
            this.gridColumn2.Name = "gridColumn2";
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
            this.gridColumn3.Caption = "العنوان";
            this.gridColumn3.FieldName = "ADDRESS";
            this.gridColumn3.Name = "gridColumn3";
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
            this.gridColumn4.Caption = "التلفون";
            this.gridColumn4.FieldName = "TEL";
            this.gridColumn4.Name = "gridColumn4";
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
            this.gridColumn5.Caption = "الصنف";
            this.gridColumn5.FieldName = "COUST_TYPE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // panel_BTN
            // 
            this.panel_BTN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_BTN.Controls.Add(this.button_NEW_INVO);
            this.panel_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BTN.Location = new System.Drawing.Point(0, 49);
            this.panel_BTN.Name = "panel_BTN";
            this.panel_BTN.Padding = new System.Windows.Forms.Padding(5);
            this.panel_BTN.Size = new System.Drawing.Size(534, 63);
            this.panel_BTN.TabIndex = 5;
            // 
            // FORM_COUSTOMERS_SELECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(534, 662);
            this.Controls.Add(this.gridControl_COUSTOMERS);
            this.Controls.Add(this.panel_BTN);
            this.Controls.Add(this.panel_TXTBOX);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_COUSTOMERS_SELECT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FORM_COUSTOMERS_SELECT";
            this.panel_TXTBOX.ResumeLayout(false);
            this.panel_TXTBOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel_BTN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TXTBOX;
        private System.Windows.Forms.Button button_NEW_INVO;
        private DevExpress.XtraGrid.GridControl gridControl_COUSTOMERS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.TextBox textBox_COUST_FILTER;
        private System.Windows.Forms.Panel panel_BTN;
    }
}