using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generater
{
    internal class ClsKeyboardHook
    {        
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        private static int hHook = 0;
        public const int WH_KEYBOARD_LL = 02; //13 - 全局監聽, 02-鍵盤監聽
        public static bool IsPressed = false;

        //LowLevel-catch keyboard information 
        private static HookProc KeyBoardHookProcedure;

        //Windows hook setting 
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        //Close hook
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //Call next hook - the system aviod failure.
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        /// <summary>
        /// Start Hook by ThreadID
        /// </summary>
        public static void Hook_Start(int ThreadID)
        {
            // 安装键盘钩子 
            if (hHook == 0)
            {
                KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);

                hHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyBoardHookProcedure, IntPtr.Zero, ThreadID); //
                //If it's fail, it clear hook
                if (hHook == 0)
                {
                    Hook_Clear();
                }
            }
        }

        /// <summary>
        /// Close current hook
        /// </summary>
        public static void Hook_Clear()
        {
            bool retKeyboard = true;
            if (hHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
            //Unhook failure, show error message.
            if (!retKeyboard) throw new Exception("UnhookWindowsHookEx failed.");
        }

        //Callback-Coding area
        private static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Keys keyData = (Keys)wParam;
                if (keyData == Keys.V && (int)Control.ModifierKeys == (int)Keys.Control) 
                {
                    IsPressed = true;
                    return 1;
                }
            }

            IsPressed = false;
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }
}
