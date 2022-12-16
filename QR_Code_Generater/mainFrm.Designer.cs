
namespace QR_Code_Generater
{
    partial class mainFrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.uiSymbolBtnClose = new Sunny.UI.UISymbolButton();
            this.uiSmoothlbSFTitle = new Sunny.UI.UISmoothLabel();
            this.uiCboPrinterList = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTxtRFID = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTxtBarCode = new Sunny.UI.UITextBox();
            this.symBtnGenerateQR = new Sunny.UI.UISymbolButton();
            this.uiSymbollbQRPreview = new Sunny.UI.UISymbolLabel();
            this.uiSymbolBtnPageSetup = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiDoubleNudPageSizeW = new Sunny.UI.UIDoubleUpDown();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiDoubleNudPageSizeH = new Sunny.UI.UIDoubleUpDown();
            this.uiSymbolBtnPagePreview = new Sunny.UI.UISymbolButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiDoubleNudCodePosX = new Sunny.UI.UIDoubleUpDown();
            this.uiDoubleNudCodePosY = new Sunny.UI.UIDoubleUpDown();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiIntNudCodeSizeW = new Sunny.UI.UIIntegerUpDown();
            this.uiIntNudCodeSizeH = new Sunny.UI.UIIntegerUpDown();
            this.uiSymbolBtnPrinterSetting = new Sunny.UI.UISymbolButton();
            this.uiSymbolBtnPrint = new Sunny.UI.UISymbolButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiTabControl = new Sunny.UI.UITabControl();
            this.tabPage_Code = new System.Windows.Forms.TabPage();
            this.tabPage_PrintSetting = new System.Windows.Forms.TabPage();
            this.tabPage_History = new System.Windows.Forms.TabPage();
            this.uiLbErrorMsg = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.uiTabControl.SuspendLayout();
            this.tabPage_Code.SuspendLayout();
            this.tabPage_PrintSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.Black;
            this.picQRCode.Location = new System.Drawing.Point(244, 265);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(150, 150);
            this.picQRCode.TabIndex = 0;
            this.picQRCode.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // uiSymbolBtnClose
            // 
            this.uiSymbolBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolBtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.uiSymbolBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.uiSymbolBtnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolBtnClose.IsCircle = true;
            this.uiSymbolBtnClose.Location = new System.Drawing.Point(1068, 6);
            this.uiSymbolBtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnClose.Name = "uiSymbolBtnClose";
            this.uiSymbolBtnClose.RectSize = 2;
            this.uiSymbolBtnClose.Size = new System.Drawing.Size(30, 30);
            this.uiSymbolBtnClose.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolBtnClose.Symbol = 61453;
            this.uiSymbolBtnClose.TabIndex = 0;
            this.uiSymbolBtnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnClose.Click += new System.EventHandler(this.uiSymbolBtnClose_Click);
            // 
            // uiSmoothlbSFTitle
            // 
            this.uiSmoothlbSFTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.uiSmoothlbSFTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSmoothlbSFTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSmoothlbSFTitle.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.uiSmoothlbSFTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.uiSmoothlbSFTitle.Location = new System.Drawing.Point(0, 0);
            this.uiSmoothlbSFTitle.Name = "uiSmoothlbSFTitle";
            this.uiSmoothlbSFTitle.RectSize = 3;
            this.uiSmoothlbSFTitle.Size = new System.Drawing.Size(180, 69);
            this.uiSmoothlbSFTitle.Style = Sunny.UI.UIStyle.Custom;
            this.uiSmoothlbSFTitle.TabIndex = 18;
            this.uiSmoothlbSFTitle.Text = "QR Code Printer";
            this.uiSmoothlbSFTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiSmoothlbSFTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSmoothlbSFTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainFrm_MouseDown);
            // 
            // uiCboPrinterList
            // 
            this.uiCboPrinterList.DataSource = null;
            this.uiCboPrinterList.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiCboPrinterList.FillColor = System.Drawing.Color.White;
            this.uiCboPrinterList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCboPrinterList.Location = new System.Drawing.Point(244, 222);
            this.uiCboPrinterList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCboPrinterList.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiCboPrinterList.Name = "uiCboPrinterList";
            this.uiCboPrinterList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiCboPrinterList.Size = new System.Drawing.Size(234, 29);
            this.uiCboPrinterList.TabIndex = 14;
            this.uiCboPrinterList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiCboPrinterList.Watermark = "";
            this.uiCboPrinterList.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 6);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(99, 34);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 15;
            this.uiLabel1.Text = "RFID";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtRFID
            // 
            this.uiTxtRFID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtRFID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTxtRFID.Location = new System.Drawing.Point(109, 9);
            this.uiTxtRFID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtRFID.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtRFID.Name = "uiTxtRFID";
            this.uiTxtRFID.ReadOnly = true;
            this.uiTxtRFID.ShowText = false;
            this.uiTxtRFID.Size = new System.Drawing.Size(492, 29);
            this.uiTxtRFID.TabIndex = 16;
            this.uiTxtRFID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtRFID.Watermark = "";
            this.uiTxtRFID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel2.Location = new System.Drawing.Point(3, 45);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(99, 34);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "BarCode";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTxtBarCode
            // 
            this.uiTxtBarCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxtBarCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTxtBarCode.Location = new System.Drawing.Point(109, 48);
            this.uiTxtBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxtBarCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxtBarCode.Name = "uiTxtBarCode";
            this.uiTxtBarCode.ReadOnly = true;
            this.uiTxtBarCode.ShowText = false;
            this.uiTxtBarCode.Size = new System.Drawing.Size(492, 29);
            this.uiTxtBarCode.TabIndex = 16;
            this.uiTxtBarCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxtBarCode.Watermark = "";
            this.uiTxtBarCode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // symBtnGenerateQR
            // 
            this.symBtnGenerateQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.symBtnGenerateQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.symBtnGenerateQR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.symBtnGenerateQR.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.symBtnGenerateQR.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.symBtnGenerateQR.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.symBtnGenerateQR.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.symBtnGenerateQR.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.symBtnGenerateQR.Location = new System.Drawing.Point(0, 69);
            this.symBtnGenerateQR.MinimumSize = new System.Drawing.Size(1, 1);
            this.symBtnGenerateQR.Name = "symBtnGenerateQR";
            this.symBtnGenerateQR.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.symBtnGenerateQR.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.symBtnGenerateQR.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.symBtnGenerateQR.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.symBtnGenerateQR.Size = new System.Drawing.Size(180, 58);
            this.symBtnGenerateQR.Style = Sunny.UI.UIStyle.Green;
            this.symBtnGenerateQR.Symbol = 61508;
            this.symBtnGenerateQR.TabIndex = 17;
            this.symBtnGenerateQR.Text = "QR Generate";
            this.symBtnGenerateQR.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.symBtnGenerateQR.Click += new System.EventHandler(this.btnGenertateQR_Click);
            // 
            // uiSymbollbQRPreview
            // 
            this.uiSymbollbQRPreview.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbollbQRPreview.Location = new System.Drawing.Point(8, 265);
            this.uiSymbollbQRPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbollbQRPreview.Name = "uiSymbollbQRPreview";
            this.uiSymbollbQRPreview.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbollbQRPreview.Size = new System.Drawing.Size(170, 35);
            this.uiSymbollbQRPreview.Symbol = 361481;
            this.uiSymbollbQRPreview.TabIndex = 18;
            this.uiSymbollbQRPreview.Text = "QR Code Preview";
            this.uiSymbollbQRPreview.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolBtnPageSetup
            // 
            this.uiSymbolBtnPageSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnPageSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSymbolBtnPageSetup.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolBtnPageSetup.LightStyle = true;
            this.uiSymbolBtnPageSetup.Location = new System.Drawing.Point(0, 127);
            this.uiSymbolBtnPageSetup.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnPageSetup.Name = "uiSymbolBtnPageSetup";
            this.uiSymbolBtnPageSetup.Size = new System.Drawing.Size(180, 58);
            this.uiSymbolBtnPageSetup.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolBtnPageSetup.Symbol = 98;
            this.uiSymbolBtnPageSetup.TabIndex = 19;
            this.uiSymbolBtnPageSetup.Text = "Page Setup";
            this.uiSymbolBtnPageSetup.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 59);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(234, 34);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 15;
            this.uiLabel3.Text = "Page Size Width (mm)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDoubleNudPageSizeW
            // 
            this.uiDoubleNudPageSizeW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudPageSizeW.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudPageSizeW.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDoubleNudPageSizeW.Location = new System.Drawing.Point(244, 62);
            this.uiDoubleNudPageSizeW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleNudPageSizeW.Maximum = 10000D;
            this.uiDoubleNudPageSizeW.Minimum = 0D;
            this.uiDoubleNudPageSizeW.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleNudPageSizeW.Name = "uiDoubleNudPageSizeW";
            this.uiDoubleNudPageSizeW.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDoubleNudPageSizeW.ShowText = false;
            this.uiDoubleNudPageSizeW.Size = new System.Drawing.Size(201, 29);
            this.uiDoubleNudPageSizeW.Step = 1D;
            this.uiDoubleNudPageSizeW.Style = Sunny.UI.UIStyle.Purple;
            this.uiDoubleNudPageSizeW.TabIndex = 20;
            this.uiDoubleNudPageSizeW.Text = "uiDoubleUpDown1";
            this.uiDoubleNudPageSizeW.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleNudPageSizeW.Value = 90D;
            this.uiDoubleNudPageSizeW.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel4.Location = new System.Drawing.Point(3, 98);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(234, 34);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel4.StyleCustomMode = true;
            this.uiLabel4.TabIndex = 15;
            this.uiLabel4.Text = "Page Size Height (mm)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDoubleNudPageSizeH
            // 
            this.uiDoubleNudPageSizeH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudPageSizeH.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudPageSizeH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDoubleNudPageSizeH.Location = new System.Drawing.Point(244, 101);
            this.uiDoubleNudPageSizeH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleNudPageSizeH.Maximum = 10000D;
            this.uiDoubleNudPageSizeH.Minimum = 0D;
            this.uiDoubleNudPageSizeH.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleNudPageSizeH.Name = "uiDoubleNudPageSizeH";
            this.uiDoubleNudPageSizeH.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDoubleNudPageSizeH.ShowText = false;
            this.uiDoubleNudPageSizeH.Size = new System.Drawing.Size(201, 29);
            this.uiDoubleNudPageSizeH.Step = 1D;
            this.uiDoubleNudPageSizeH.Style = Sunny.UI.UIStyle.Purple;
            this.uiDoubleNudPageSizeH.TabIndex = 20;
            this.uiDoubleNudPageSizeH.Text = "uiDoubleUpDown1";
            this.uiDoubleNudPageSizeH.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleNudPageSizeH.Value = 20D;
            this.uiDoubleNudPageSizeH.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolBtnPagePreview
            // 
            this.uiSymbolBtnPagePreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnPagePreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSymbolBtnPagePreview.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolBtnPagePreview.LightStyle = true;
            this.uiSymbolBtnPagePreview.Location = new System.Drawing.Point(0, 185);
            this.uiSymbolBtnPagePreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnPagePreview.Name = "uiSymbolBtnPagePreview";
            this.uiSymbolBtnPagePreview.Size = new System.Drawing.Size(180, 58);
            this.uiSymbolBtnPagePreview.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolBtnPagePreview.Symbol = 61442;
            this.uiSymbolBtnPagePreview.TabIndex = 19;
            this.uiSymbolBtnPagePreview.Text = "Page Preview";
            this.uiSymbolBtnPagePreview.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnPagePreview.Click += new System.EventHandler(this.btnPagePreview_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel5.Location = new System.Drawing.Point(3, 141);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(234, 34);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel5.StyleCustomMode = true;
            this.uiLabel5.TabIndex = 15;
            this.uiLabel5.Text = "Code Pos X (mm)";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel6.Location = new System.Drawing.Point(3, 180);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(234, 34);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel6.StyleCustomMode = true;
            this.uiLabel6.TabIndex = 15;
            this.uiLabel6.Text = "Code Pos Y (mm)";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDoubleNudCodePosX
            // 
            this.uiDoubleNudCodePosX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudCodePosX.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudCodePosX.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDoubleNudCodePosX.Location = new System.Drawing.Point(244, 144);
            this.uiDoubleNudCodePosX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleNudCodePosX.Maximum = 10000D;
            this.uiDoubleNudCodePosX.Minimum = 0D;
            this.uiDoubleNudCodePosX.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleNudCodePosX.Name = "uiDoubleNudCodePosX";
            this.uiDoubleNudCodePosX.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDoubleNudCodePosX.ShowText = false;
            this.uiDoubleNudCodePosX.Size = new System.Drawing.Size(201, 29);
            this.uiDoubleNudCodePosX.Step = 1D;
            this.uiDoubleNudCodePosX.Style = Sunny.UI.UIStyle.Purple;
            this.uiDoubleNudCodePosX.TabIndex = 20;
            this.uiDoubleNudCodePosX.Text = "uiDoubleUpDown1";
            this.uiDoubleNudCodePosX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleNudCodePosX.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDoubleNudCodePosY
            // 
            this.uiDoubleNudCodePosY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudCodePosY.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDoubleNudCodePosY.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDoubleNudCodePosY.Location = new System.Drawing.Point(244, 183);
            this.uiDoubleNudCodePosY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleNudCodePosY.Maximum = 10000D;
            this.uiDoubleNudCodePosY.Minimum = 0D;
            this.uiDoubleNudCodePosY.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleNudCodePosY.Name = "uiDoubleNudCodePosY";
            this.uiDoubleNudCodePosY.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDoubleNudCodePosY.ShowText = false;
            this.uiDoubleNudCodePosY.Size = new System.Drawing.Size(201, 29);
            this.uiDoubleNudCodePosY.Step = 1D;
            this.uiDoubleNudCodePosY.Style = Sunny.UI.UIStyle.Purple;
            this.uiDoubleNudCodePosY.TabIndex = 20;
            this.uiDoubleNudCodePosY.Text = "uiDoubleUpDown1";
            this.uiDoubleNudCodePosY.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleNudCodePosY.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel7.Location = new System.Drawing.Point(3, 6);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(224, 34);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel7.StyleCustomMode = true;
            this.uiLabel7.TabIndex = 15;
            this.uiLabel7.Text = "QR Code Size (W * H)";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiIntNudCodeSizeW
            // 
            this.uiIntNudCodeSizeW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiIntNudCodeSizeW.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiIntNudCodeSizeW.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntNudCodeSizeW.Location = new System.Drawing.Point(244, 11);
            this.uiIntNudCodeSizeW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntNudCodeSizeW.Minimum = 0;
            this.uiIntNudCodeSizeW.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntNudCodeSizeW.Name = "uiIntNudCodeSizeW";
            this.uiIntNudCodeSizeW.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiIntNudCodeSizeW.ShowText = false;
            this.uiIntNudCodeSizeW.Size = new System.Drawing.Size(165, 29);
            this.uiIntNudCodeSizeW.Style = Sunny.UI.UIStyle.Purple;
            this.uiIntNudCodeSizeW.TabIndex = 21;
            this.uiIntNudCodeSizeW.Text = "uiIntegerUpDown1";
            this.uiIntNudCodeSizeW.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntNudCodeSizeW.Value = 70;
            this.uiIntNudCodeSizeW.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiIntNudCodeSizeH
            // 
            this.uiIntNudCodeSizeH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiIntNudCodeSizeH.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiIntNudCodeSizeH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntNudCodeSizeH.Location = new System.Drawing.Point(418, 11);
            this.uiIntNudCodeSizeH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntNudCodeSizeH.Minimum = 0;
            this.uiIntNudCodeSizeH.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntNudCodeSizeH.Name = "uiIntNudCodeSizeH";
            this.uiIntNudCodeSizeH.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiIntNudCodeSizeH.ShowText = false;
            this.uiIntNudCodeSizeH.Size = new System.Drawing.Size(165, 29);
            this.uiIntNudCodeSizeH.Style = Sunny.UI.UIStyle.Purple;
            this.uiIntNudCodeSizeH.TabIndex = 21;
            this.uiIntNudCodeSizeH.Text = "uiIntegerUpDown1";
            this.uiIntNudCodeSizeH.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntNudCodeSizeH.Value = 70;
            this.uiIntNudCodeSizeH.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolBtnPrinterSetting
            // 
            this.uiSymbolBtnPrinterSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnPrinterSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSymbolBtnPrinterSetting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolBtnPrinterSetting.LightStyle = true;
            this.uiSymbolBtnPrinterSetting.Location = new System.Drawing.Point(0, 243);
            this.uiSymbolBtnPrinterSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnPrinterSetting.Name = "uiSymbolBtnPrinterSetting";
            this.uiSymbolBtnPrinterSetting.Size = new System.Drawing.Size(180, 58);
            this.uiSymbolBtnPrinterSetting.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolBtnPrinterSetting.Symbol = 61459;
            this.uiSymbolBtnPrinterSetting.TabIndex = 19;
            this.uiSymbolBtnPrinterSetting.Text = "Printer Setting";
            this.uiSymbolBtnPrinterSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnPrinterSetting.Click += new System.EventHandler(this.btnPrinterSetting_Click);
            // 
            // uiSymbolBtnPrint
            // 
            this.uiSymbolBtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolBtnPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiSymbolBtnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiSymbolBtnPrint.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolBtnPrint.Location = new System.Drawing.Point(0, 301);
            this.uiSymbolBtnPrint.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolBtnPrint.Name = "uiSymbolBtnPrint";
            this.uiSymbolBtnPrint.Radius = 2;
            this.uiSymbolBtnPrint.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiSymbolBtnPrint.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiSymbolBtnPrint.RectSize = 2;
            this.uiSymbolBtnPrint.Size = new System.Drawing.Size(180, 58);
            this.uiSymbolBtnPrint.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiSymbolBtnPrint.Symbol = 361487;
            this.uiSymbolBtnPrint.TabIndex = 19;
            this.uiSymbolBtnPrint.Text = "Print";
            this.uiSymbolBtnPrint.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolBtnPrint.Click += new System.EventHandler(this.btnPagePrint_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.uiLabel8.Location = new System.Drawing.Point(3, 219);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(224, 34);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Green;
            this.uiLabel8.StyleCustomMode = true;
            this.uiLabel8.TabIndex = 15;
            this.uiLabel8.Text = "Printer Model";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.uiSymbolBtnPrint);
            this.panel1.Controls.Add(this.uiSymbolBtnPrinterSetting);
            this.panel1.Controls.Add(this.uiSymbolBtnPagePreview);
            this.panel1.Controls.Add(this.uiSymbolBtnPageSetup);
            this.panel1.Controls.Add(this.symBtnGenerateQR);
            this.panel1.Controls.Add(this.uiSmoothlbSFTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 547);
            this.panel1.TabIndex = 24;
            // 
            // uiLine1
            // 
            this.uiLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.White;
            this.uiLine1.LineColor = System.Drawing.Color.White;
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.uiLine1.Location = new System.Drawing.Point(180, 0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(919, 43);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 25;
            this.uiLine1.Text = "PRINT SETTING";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiLine1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainFrm_MouseDown);
            // 
            // uiTabControl
            // 
            this.uiTabControl.Controls.Add(this.tabPage_Code);
            this.uiTabControl.Controls.Add(this.tabPage_PrintSetting);
            this.uiTabControl.Controls.Add(this.tabPage_History);
            this.uiTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.uiTabControl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl.Frame = null;
            this.uiTabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl.Location = new System.Drawing.Point(180, 43);
            this.uiTabControl.MainPage = "";
            this.uiTabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl.Name = "uiTabControl";
            this.uiTabControl.SelectedIndex = 0;
            this.uiTabControl.Size = new System.Drawing.Size(919, 504);
            this.uiTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiTabControl.TabIndex = 26;
            this.uiTabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiTabControl.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiTabControl.TabSelectedHighColor = System.Drawing.Color.DarkOrange;
            this.uiTabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiTabControl.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.uiTabControl.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage_Code
            // 
            this.tabPage_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.tabPage_Code.Controls.Add(this.uiLbErrorMsg);
            this.tabPage_Code.Controls.Add(this.uiLabel1);
            this.tabPage_Code.Controls.Add(this.uiTxtRFID);
            this.tabPage_Code.Controls.Add(this.uiLabel2);
            this.tabPage_Code.Controls.Add(this.uiTxtBarCode);
            this.tabPage_Code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage_Code.Location = new System.Drawing.Point(0, 40);
            this.tabPage_Code.Name = "tabPage_Code";
            this.tabPage_Code.Size = new System.Drawing.Size(919, 464);
            this.tabPage_Code.TabIndex = 0;
            this.tabPage_Code.Text = "掃條碼";
            // 
            // tabPage_PrintSetting
            // 
            this.tabPage_PrintSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel7);
            this.tabPage_PrintSetting.Controls.Add(this.picQRCode);
            this.tabPage_PrintSetting.Controls.Add(this.uiCboPrinterList);
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel8);
            this.tabPage_PrintSetting.Controls.Add(this.uiIntNudCodeSizeH);
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel3);
            this.tabPage_PrintSetting.Controls.Add(this.uiIntNudCodeSizeW);
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel5);
            this.tabPage_PrintSetting.Controls.Add(this.uiDoubleNudCodePosY);
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel6);
            this.tabPage_PrintSetting.Controls.Add(this.uiDoubleNudPageSizeH);
            this.tabPage_PrintSetting.Controls.Add(this.uiLabel4);
            this.tabPage_PrintSetting.Controls.Add(this.uiDoubleNudCodePosX);
            this.tabPage_PrintSetting.Controls.Add(this.uiSymbollbQRPreview);
            this.tabPage_PrintSetting.Controls.Add(this.uiDoubleNudPageSizeW);
            this.tabPage_PrintSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage_PrintSetting.Location = new System.Drawing.Point(0, 40);
            this.tabPage_PrintSetting.Name = "tabPage_PrintSetting";
            this.tabPage_PrintSetting.Size = new System.Drawing.Size(919, 464);
            this.tabPage_PrintSetting.TabIndex = 2;
            this.tabPage_PrintSetting.Text = "列印設定";
            // 
            // tabPage_History
            // 
            this.tabPage_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.tabPage_History.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage_History.Location = new System.Drawing.Point(0, 40);
            this.tabPage_History.Name = "tabPage_History";
            this.tabPage_History.Size = new System.Drawing.Size(919, 464);
            this.tabPage_History.TabIndex = 1;
            this.tabPage_History.Text = "歷史紀錄";
            // 
            // uiLbErrorMsg
            // 
            this.uiLbErrorMsg.AutoSize = true;
            this.uiLbErrorMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLbErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.uiLbErrorMsg.Location = new System.Drawing.Point(105, 91);
            this.uiLbErrorMsg.Name = "uiLbErrorMsg";
            this.uiLbErrorMsg.Size = new System.Drawing.Size(81, 21);
            this.uiLbErrorMsg.Style = Sunny.UI.UIStyle.Custom;
            this.uiLbErrorMsg.TabIndex = 17;
            this.uiLbErrorMsg.Text = "ERR MSG";
            this.uiLbErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLbErrorMsg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1099, 547);
            this.Controls.Add(this.uiTabControl);
            this.Controls.Add(this.uiSymbolBtnClose);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainFrm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.uiTabControl.ResumeLayout(false);
            this.tabPage_Code.ResumeLayout(false);
            this.tabPage_Code.PerformLayout();
            this.tabPage_PrintSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Sunny.UI.UISymbolButton uiSymbolBtnClose;
        private Sunny.UI.UIComboBox uiCboPrinterList;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTxtRFID;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTxtBarCode;
        private Sunny.UI.UISymbolButton symBtnGenerateQR;
        private Sunny.UI.UISmoothLabel uiSmoothlbSFTitle;
        private Sunny.UI.UISymbolLabel uiSymbollbQRPreview;
        private Sunny.UI.UISymbolButton uiSymbolBtnPageSetup;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDoubleUpDown uiDoubleNudPageSizeW;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDoubleUpDown uiDoubleNudPageSizeH;
        private Sunny.UI.UISymbolButton uiSymbolBtnPagePreview;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDoubleUpDown uiDoubleNudCodePosX;
        private Sunny.UI.UIDoubleUpDown uiDoubleNudCodePosY;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown uiIntNudCodeSizeW;
        private Sunny.UI.UIIntegerUpDown uiIntNudCodeSizeH;
        private Sunny.UI.UISymbolButton uiSymbolBtnPrinterSetting;
        private Sunny.UI.UISymbolButton uiSymbolBtnPrint;
        private Sunny.UI.UILabel uiLabel8;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITabControl uiTabControl;
        private System.Windows.Forms.TabPage tabPage_Code;
        private System.Windows.Forms.TabPage tabPage_History;
        private System.Windows.Forms.TabPage tabPage_PrintSetting;
        private Sunny.UI.UILabel uiLbErrorMsg;
    }
}

