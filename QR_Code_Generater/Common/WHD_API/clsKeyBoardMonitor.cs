using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generater
{
    class clsKeyBoardMonitor
    {
        const int WH_KEYBOARD = 2;
        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static int m_HookHandle = 0;    // Hook handle
        private HookProc m_KbdHookProc;            // 鍵盤掛鉤函式指標
        // 設置掛鉤.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn,
            IntPtr hInstance, int threadId);
        // 將之前設置的掛鉤移除。記得在應用程式結束前呼叫此函式.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);
        // 呼叫下一個掛鉤處理常式（若不這麼做，會令其他掛鉤處理常式失效）.
        [DllImport("user32.dll", CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode,
            IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        static extern int GetCurrentThreadId();
        private void Hooks()
        {
            if (m_HookHandle == 0)
            {
                m_KbdHookProc = new HookProc(clsKeyBoardMonitor.KeyboardHookProc);
                m_HookHandle = SetWindowsHookEx(WH_KEYBOARD, m_KbdHookProc, IntPtr.Zero, GetCurrentThreadId());
                if (m_HookHandle == 0)
                {
                    MessageBox.Show("呼叫 SetWindowsHookEx 失敗!");
                    return;
                }
            }
            else
            {
                bool ret = UnhookWindowsHookEx(m_HookHandle);
                if (ret == false)
                {
                    MessageBox.Show("呼叫 UnhookWindowsHookEx 失敗!");
                    return;
                }
                m_HookHandle = 0;
            }
        }
        public static int KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // 當按鍵按下及鬆開時都會觸發此函式，這裡只處理鍵盤按下的情形。
            bool isPressed = (lParam.ToInt32() & 0x80000000) == 0;
            Console.WriteLine(isPressed);
            Console.WriteLine(nCode);
            if (nCode < 0 || !isPressed)
            {
                return CallNextHookEx(m_HookHandle, nCode, wParam, lParam);
            }
            // 取得欲攔截之按鍵狀態
            KeyStateInfo ctrlKey = KeyboardInfo.GetKeyState(Keys.ControlKey);
            KeyStateInfo altKey = KeyboardInfo.GetKeyState(Keys.Alt);
            KeyStateInfo shiftKey = KeyboardInfo.GetKeyState(Keys.ShiftKey);
            KeyStateInfo f8Key = KeyboardInfo.GetKeyState(Keys.F8);
            if (ctrlKey.IsPressed)
            {
                System.Diagnostics.Debug.WriteLine("Ctrl Pressed!");
            }
            if (altKey.IsPressed)
            {
                System.Diagnostics.Debug.WriteLine("Alt Pressed!");
            }
            if (shiftKey.IsPressed)
            {
                System.Diagnostics.Debug.WriteLine("Shift Pressed!");
            }
            if (f8Key.IsPressed)
            {
                System.Diagnostics.Debug.WriteLine("F8 Pressed!");
            }
            return CallNextHookEx(m_HookHandle, nCode, wParam, lParam);
        }
    }
    public class KeyboardInfo
    {
        private KeyboardInfo() { }
        [DllImport("user32")]
        private static extern short GetKeyState(int vKey);
        public static KeyStateInfo GetKeyState(Keys key)
        {
            int vkey = (int)key;
            if (key == Keys.Alt)
            {
                vkey = 0x12;    // VK_ALT
            }
            short keyState = GetKeyState(vkey);
            int low = Low(keyState);
            int high = High(keyState);
            bool toggled = (low == 1);
            bool pressed = (high == 1);
            return new KeyStateInfo(key, pressed, toggled);

        }

        private static int High(int keyState)
        {
            if (keyState > 0)
            {
                return keyState >> 0x10;
            }
            else
            {
                return (keyState >> 0x10) & 0x1;
            }
        }
        private static int Low(int keyState)
        {
            return keyState & 0xffff;
        }
    }
    public struct KeyStateInfo
    {
        Keys m_Key;
        bool m_IsPressed;
        bool m_IsToggled;
        public KeyStateInfo(Keys key, bool ispressed, bool istoggled)
        {
            m_Key = key;
            m_IsPressed = ispressed;
            m_IsToggled = istoggled;
        }
        public static KeyStateInfo Default
        {
            get
            {
                return new KeyStateInfo(Keys.None, false, false);
            }
        }
        public Keys Key
        {
            get { return m_Key; }
        }

        public bool IsPressed
        {
            get { return m_IsPressed; }
        }
        public bool IsToggled
        {
            get { return m_IsToggled; }
        }
    }
}
