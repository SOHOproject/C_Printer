using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QR_Code_Generater
{
    public class clsSysDef
    {
        #region [INI]
        internal static string INI_FILE_ROOT = Application.StartupPath;
        internal static string INI_FILE_NAME = "sysconfig";

        internal static string INI_SYS_SECTION = "SYS_CONFIG";
        internal static string INI_PRINTER_KEY= "PRINT";
        internal static string INI_PAGE_WIDTH_KEY = "PAGE_WIDTH";
        internal static string INI_PAGE_HEIGHT_KEY = "PAGE_HEIGHT";
        internal static string INI_QRCODE_POS_X_KEY = "QR_CODE_POS_X";
        internal static string INI_QRCODE_POS_Y_KEY = "QR_CODE_POS_Y";
        //
        internal static string INI_QRCODE_WIDTH_KEY = "QR_CODE_WIDTH";
        internal static string INI_QRCODE_HEIGHT_KEY = "QR_CODE_HEIGHT";

        #endregion
    }
}
