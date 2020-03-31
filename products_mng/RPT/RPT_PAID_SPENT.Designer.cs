namespace products_mng.RPT
{
    partial class RPT_PAID_SPENT
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.rpT_TABLES1 = new products_mng.DAL.RPT_TABLES();
            this.xrLabelTITLE = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel_SLAESMAN = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelDETLS = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel_date = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rpT_TABLES1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel_date,
            this.xrLabel2,
            this.xrLabelDETLS});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 306.6458F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 127F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 127F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rpT_TABLES1
            // 
            this.rpT_TABLES1.DataSetName = "RPT_TABLES";
            this.rpT_TABLES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xrLabelTITLE
            // 
            this.xrLabelTITLE.Dpi = 254F;
            this.xrLabelTITLE.LocationFloat = new DevExpress.Utils.PointFloat(750F, 25F);
            this.xrLabelTITLE.Name = "xrLabelTITLE";
            this.xrLabelTITLE.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabelTITLE.SizeF = new System.Drawing.SizeF(500F, 100F);
            this.xrLabelTITLE.StylePriority.UsePadding = false;
            this.xrLabelTITLE.StylePriority.UseTextAlignment = false;
            this.xrLabelTITLE.Text = "xrLabelTITLE";
            this.xrLabelTITLE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelTITLE});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 149.7292F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseTextAlignment = false;
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel_SLAESMAN,
            this.xrLabel1});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 254F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(749.9999F, 114.9583F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(500F, 100F);
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "أسم الكاشير او المستخدم";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel_SLAESMAN
            // 
            this.xrLabel_SLAESMAN.Dpi = 254F;
            this.xrLabel_SLAESMAN.LocationFloat = new DevExpress.Utils.PointFloat(1305.917F, 114.9583F);
            this.xrLabel_SLAESMAN.Name = "xrLabel_SLAESMAN";
            this.xrLabel_SLAESMAN.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabel_SLAESMAN.SizeF = new System.Drawing.SizeF(500F, 100F);
            this.xrLabel_SLAESMAN.StylePriority.UsePadding = false;
            this.xrLabel_SLAESMAN.StylePriority.UseTextAlignment = false;
            this.xrLabel_SLAESMAN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelDETLS
            // 
            this.xrLabelDETLS.Dpi = 254F;
            this.xrLabelDETLS.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 2.000039F);
            this.xrLabelDETLS.Name = "xrLabelDETLS";
            this.xrLabelDETLS.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabelDETLS.SizeF = new System.Drawing.SizeF(1806.646F, 171.4374F);
            this.xrLabelDETLS.StylePriority.UsePadding = false;
            this.xrLabelDETLS.StylePriority.UseTextAlignment = false;
            this.xrLabelDETLS.Text = "xrLabelTITLE";
            this.xrLabelDETLS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(25.00005F, 193.4167F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(500F, 100F);
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "تاريخ التسديد";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel_date
            // 
            this.xrLabel_date.Dpi = 254F;
            this.xrLabel_date.LocationFloat = new DevExpress.Utils.PointFloat(578.5417F, 193.4167F);
            this.xrLabel_date.Name = "xrLabel_date";
            this.xrLabel_date.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254F);
            this.xrLabel_date.SizeF = new System.Drawing.SizeF(500F, 100F);
            this.xrLabel_date.StylePriority.UsePadding = false;
            this.xrLabel_date.StylePriority.UseTextAlignment = false;
            this.xrLabel_date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RPT_PAID_SPENT
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageFooter});
            this.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.BorderWidth = 2F;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.rpT_TABLES1});
            this.DataSource = this.rpT_TABLES1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(127, 127, 127, 127);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Small;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            this.SnapGridSize = 25F;
            this.SnapGridStepCount = 5;
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.rpT_TABLES1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DAL.RPT_TABLES rpT_TABLES1;
        public DevExpress.XtraReports.UI.XRLabel xrLabelTITLE;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        public DevExpress.XtraReports.UI.XRLabel xrLabel_SLAESMAN;
        public DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel xrLabel_date;
        public DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel xrLabelDETLS;
    }
}
