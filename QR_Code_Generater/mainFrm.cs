using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using QR_Code_Generater.Common.IO;
using System.Diagnostics;

namespace QR_Code_Generater
{
    public partial class mainFrm : Form
    {
        private const float mm2Inch = 0.25f;
        private ClsIniFile m_Inifile;
        private System.Windows.Forms.Timer m_Timer;
        private bool m_IsLock = true;

        #region"---user32---"
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32")]
        private static extern short GetKeyState(int vKey);
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();
        #endregion

        #region"---MouseDown_ForMoveForm---"
        private void mainFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public mainFrm()
        {
            InitializeComponent();
            this.m_Inifile = new ClsIniFile(clsSysDef.INI_FILE_ROOT, clsSysDef.INI_FILE_NAME);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.m_Timer = new System.Windows.Forms.Timer();
            this.m_Timer.Enabled = true;
            this.m_Timer.Interval = 1000;
            this.m_Timer.Tick += new System.EventHandler(this.m_LockTimer_Tick);

            this.pageSetupDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printDialog1.Document = this.printDocument1;
            //
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.Name = "dgvBtn";
            dgvBtn.HeaderText = "Print";
            dgvBtn.Text = "...";
            dgvBtn.DefaultCellStyle.NullValue = "...";

            //
            this.uiDgvCurrentInfo.Columns.Add(dgvBtn);            
        }
        

        private void mainFrm_Load(object sender, EventArgs e)
        {
            ClsKeyboardHook.Hook_Start(GetCurrentThreadId());
            this.uiCboPrinterList.Items.Clear();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                string printerName = PrinterSettings.InstalledPrinters[i];
                this.uiCboPrinterList.Items.Add(printerName);
            }
            this.m_Timer.Start();
            this.Loadsysconfig();
            this.uiLbErrorMsg.Text = string.Empty;

           int i_dgvRowIdx =  this.uiDgvCurrentInfo.Rows.Add();
            DataGridViewRow dgvRow = this.uiDgvCurrentInfo.Rows[i_dgvRowIdx];
            dgvRow.Cells[0].Value = 123;
            dgvRow.Cells[1].Value = 456;

        }

        private void btnGenertateQR_Click(object sender, EventArgs e)
        {
            this.uiTabControl.SelectedTab = tabPage_Code;
            this.uiLbErrorMsg.Text = string.Empty;
            if (uiTxtRFID.Text == string.Empty )
            {
                this.uiLbErrorMsg.Text = "[ERR]-未輸入RFID";
                return;
            }
            BarcodeWriter codeWriter = new BarcodeWriter();
            codeWriter.Format = BarcodeFormat.QR_CODE;
            codeWriter.Options = new QrCodeEncodingOptions()
            { Height = uiIntNudCodeSizeW.Value, Width = uiIntNudCodeSizeH.Value };

            string CodeMsg = uiTxtRFID.Text + uiTxtBarCode.Text;
            Bitmap img = codeWriter.Write(CodeMsg);

            picQRCode.Image = img;
            picQRCode.Width = uiIntNudCodeSizeW.Value;
            picQRCode.Height = uiIntNudCodeSizeH.Value;
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            //1/100 inch = 0.25 mm
            //convert mm to inch
            int _pageSizeWidth = (int)Math.Round((float)this.uiDoubleNudPageSizeW.Value / mm2Inch, MidpointRounding.AwayFromZero);
            int _pageSizeHeight = (int)Math.Round((float)this.uiDoubleNudPageSizeH.Value / mm2Inch, MidpointRounding.AwayFromZero);
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", _pageSizeWidth
                , _pageSizeHeight);
            //this.pageSetupDialog1.ShowDialog();
            this.uiTabControl.SelectedTab = tabPage_PrintSetting;
            this.Savesysconfig();
        }

        private void btnPagePreview_Click(object sender, EventArgs e)
        {
            if (this.printPreviewDialog1.Document == null)
            {
                string msg = "The Document hasn't into this PagePreview dialog.";
                this.PrintMessage(eMsgType.ERROR, msg);
                return;
            }
            this.printPreviewDialog1.ShowDialog();
            this.uiTabControl.SelectedTab = tabPage_PrintSetting;
            this.Savesysconfig();
        }
        private void btnPrinterSetting_Click(object sender, EventArgs e)
        {
            PrinterSettings printerSetting = new PrinterSettings();
            printerSetting.PrinterName = (string)this.uiCboPrinterList.SelectedItem;
            this.printDocument1.PrinterSettings = printerSetting;
            this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION, clsSysDef.INI_PRINTER_KEY,
                printerSetting.PrinterName);
            this.uiTabControl.SelectedTab = tabPage_PrintSetting;
            this.Savesysconfig();
        }

        private void btnPagePrint_Click(object sender, EventArgs e)
        {
            this.Savesysconfig();
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //列印內容 為 整個Form
            //Image myFormImage;
            //myFormImage = new Bitmap(this.Width, this.Height);
            //Graphics g = Graphics.FromImage(myFormImage);
            //g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //e.Graphics.DrawImage(myFormImage, 0, 0);

            //列印內容 為 局部的 this.groupBox1
            //Bitmap _NewBitmap = new Bitmap(picQRCode.Width, picQRCode.Height);
            //picQRCode.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            //groupBox1.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            if (picQRCode.Image == null) { return; }
            picQRCode.Image.Save(@"D:\Test.bmp");
            float codePosX = (float)Math.Round(((float)uiDoubleNudCodePosX.Value / mm2Inch), MidpointRounding.AwayFromZero);
            float codePosY = (float)Math.Round(((float)uiDoubleNudCodePosY.Value / mm2Inch), MidpointRounding.AwayFromZero);
            e.Graphics.DrawImage(picQRCode.Image, codePosX, codePosY,
                picQRCode.Width, picQRCode.Height);
        }

        #region"Private_Method"
        /// <summary>
        /// Load System setting file (Type-INI)
        /// </summary>
        private void Loadsysconfig()
        {
            string str_IniValue = string.Empty;
            double d_IniValue = 0;
            int i_IniValue = 0;
            try
            {
                str_IniValue = this.m_Inifile.GetString(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PRINTER_KEY);
                //Set default printer
                if (str_IniValue != string.Empty)
                {
                    this.uiCboPrinterList.SelectedItem = str_IniValue;
                }
                else
                {
                    this.uiCboPrinterList.SelectedItem = this.printDocument1.PrinterSettings.PrinterName;
                }
                //Set default Page Width
                d_IniValue = this.m_Inifile.GetDouble(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PAGE_WIDTH_KEY);
                if (d_IniValue != 0)
                {
                    uiDoubleNudPageSizeW.Value = d_IniValue;
                }
                else
                {
                    uiDoubleNudPageSizeW.Value = this.printDocument1.DefaultPageSettings.PaperSize.Width;
                }
                //Set default Page Height
                d_IniValue = this.m_Inifile.GetInt16(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PAGE_HEIGHT_KEY);
                if (d_IniValue != 0)
                {
                    uiDoubleNudPageSizeH.Value = d_IniValue;
                }
                else
                {
                    uiDoubleNudPageSizeH.Value = this.printDocument1.DefaultPageSettings.PaperSize.Height;
                }
                //Set default Code Pos X
                d_IniValue = this.m_Inifile.GetDouble(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_POS_X_KEY);
                uiDoubleNudCodePosX.Value = d_IniValue;
                //Set default Code Pos Y
                d_IniValue = this.m_Inifile.GetDouble(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_POS_Y_KEY);
                uiDoubleNudCodePosY.Value = d_IniValue;
                //Set default QRCode Size Width
                i_IniValue = this.m_Inifile.GetInt16(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_WIDTH_KEY);
                if (i_IniValue != 0)
                {
                    uiIntNudCodeSizeW.Value = i_IniValue;
                }
                //Set default QRCode Size Height
                i_IniValue = this.m_Inifile.GetInt16(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_HEIGHT_KEY);
                if (i_IniValue != 0)
                {
                    uiIntNudCodeSizeH.Value = i_IniValue;
                }
            }
            catch (Exception ex)
            {
                string msg = "ERR_MSG - " + ex.Message;
                PrintMessage(eMsgType.ERROR, msg);
            }
        }

        private void Savesysconfig()
        {
            string str_IniValue = string.Empty;
            double d_IniValue = 0;
            int i_IniValue = 0;
            try
            {
                //Set default printer
                str_IniValue = (string)this.uiCboPrinterList.SelectedItem;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PRINTER_KEY, str_IniValue);
                //Set default Page Width
                d_IniValue = uiDoubleNudPageSizeW.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PAGE_WIDTH_KEY, d_IniValue);
                //Set default Page Height
                d_IniValue = uiDoubleNudPageSizeH.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_PAGE_HEIGHT_KEY, d_IniValue);
                //Set default Code Pos X
                d_IniValue = uiDoubleNudCodePosX.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_POS_X_KEY, d_IniValue);
                //Set default Code Pos Y
                d_IniValue = uiDoubleNudCodePosY.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_POS_Y_KEY, d_IniValue);
                //Set default QRCode Size Width
                i_IniValue = uiIntNudCodeSizeW.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_WIDTH_KEY, i_IniValue);
                //Set default QRCode Size Height
                i_IniValue = uiIntNudCodeSizeH.Value;
                this.m_Inifile.WriteValue(clsSysDef.INI_SYS_SECTION,
                    clsSysDef.INI_QRCODE_HEIGHT_KEY, i_IniValue);
            }
            catch (Exception ex)
            {
                string msg = "ERR_MSG - " + ex.Message;
                PrintMessage(eMsgType.ERROR, msg);
            }
        }

        /// <summary>
        /// Show Message into richTextBox
        /// </summary>
        /// <param name="msgType"></param>
        /// <param name="msg"></param>
        public delegate void printMsgHandler(eMsgType msgType, string msg);
        private void PrintMessage(eMsgType msgType, string msg)
        {
            //TODO - show message

            MessageBox.Show(msg);
        }

        #endregion

        private void uiSymbolBtnClose_Click(object sender, EventArgs e)
        {
            ClsKeyboardHook.Hook_Clear();
            this.Close();
        }

        private void m_LockTimer_Tick(object sender, EventArgs e)
        {
            if(ClsKeyboardHook.IsPressed)
            {
                m_IsLock = (m_IsLock) ? false : true;
                this.uiTxtBarCode.ReadOnly = !m_IsLock;
                this.uiTxtRFID.ReadOnly = !m_IsLock;
            }
        }

        private void uiDgvCurrentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)//button
            {
                
            }
        }
    }

}

