using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;


namespace Common
{
    public class BardCodeHooK
    {
        public delegate void BardCodeDeletegate(BarCodes barCode);
        public event BardCodeDeletegate BarCodeEvent;


        public struct BarCodes
        {
            public int VirtKey;//虚拟吗
            public int ScanCode;//扫描码
            public string KeyName;//键名
            public uint Ascll;//Ascll
            public char Chr;//字符


            public string BarCode;//条码信息
            public bool IsValid;//条码是否有效
            public DateTime Time;//扫描时间
        }


        private struct EventMsg
        {
            public int message;
            public int paramL;
            public int paramH;
            public int Time;
            public int hwnd;
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(int idHook);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);


        [DllImport("user32", EntryPoint = "GetKeyNameText")]
        private static extern int GetKeyNameText(int IParam, StringBuilder lpBuffer, int nSize);


        [DllImport("user32", EntryPoint = "GetKeyboardState")]
        private static extern int GetKeyboardState(byte[] pbKeyState);


        [DllImport("user32", EntryPoint = "ToAscii")]
        private static extern bool ToAscii(int VirtualKey, int ScanCode, byte[] lpKeySate, ref uint lpChar, int uFlags);


        delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        BarCodes barCode = new BarCodes();
        int hKeyboardHook = 0;
        string strBarCode = "";


        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            if (nCode == 0)
            {
                EventMsg msg = (EventMsg)Marshal.PtrToStructure(lParam, typeof(EventMsg));
                if (wParam == 0x100)//WM_KEYDOWN=0x100
                {
                    barCode.VirtKey = msg.message & 0xff;//虚拟吗
                    barCode.ScanCode = msg.paramL & 0xff;//扫描码
                    StringBuilder strKeyName = new StringBuilder(225);
                    if (GetKeyNameText(barCode.ScanCode * 65536, strKeyName, 255) > 0)
                    {
                        barCode.KeyName = strKeyName.ToString().Trim(new char[] { ' ', '\0' });
                    }
                    else
                    {
                        barCode.KeyName = "";
                    }
                    byte[] kbArray = new byte[256];
                    uint uKey = 0;
                    GetKeyboardState(kbArray);

                    if (ToAscii(barCode.VirtKey, barCode.ScanCode, kbArray, ref uKey, 0))
                    {
                        barCode.Ascll = uKey;
                        barCode.Chr = Convert.ToChar(uKey);
                    }


                    TimeSpan ts = DateTime.Now.Subtract(barCode.Time);


                    if (ts.TotalMilliseconds > 50)
                    {
                        strBarCode = barCode.Chr.ToString();
                    }
                    else
                    {
                        if ((msg.message & 0xff) == 13 && strBarCode.Length > 3)
                        {
                            barCode.BarCode = strBarCode;
                            barCode.IsValid = true;
                        }
                        strBarCode += barCode.Chr.ToString();
                    }
                    barCode.Time = DateTime.Now;
                    if (BarCodeEvent != null) BarCodeEvent(barCode);//触发事件
                    barCode.IsValid = false;
                }
            }
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }


        //安装钩子
        public bool Start()
        {
            if (hKeyboardHook == 0)
            {
                //WH_KEYBOARD_LL=13
                hKeyboardHook = SetWindowsHookEx(13, new HookProc(KeyboardHookProc), Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
            }
            return (hKeyboardHook != 0);
        }


        //卸载钩子
        public bool Stop()
        {
            if (hKeyboardHook != 0)
            {
                return UnhookWindowsHookEx(hKeyboardHook);
            }
            return true;
        }
    }
}



//页面中用法：
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//namespace Common
//{
//    public partial class FrmMain : Form
//    {
//        BardCodeHooK BarCode = new BardCodeHooK();
//        public FrmMain()
//        {
//            InitializeComponent();
//            BarCode.BarCodeEvent += new BardCodeHooK.BardCodeDeletegate(BarCode_BarCodeEvent);
//        }
//        private delegate void ShowInfoDelegate(BardCodeHooK.BarCodes barCode);
//        private void ShowInfo(BardCodeHooK.BarCodes barCode)
//        {
//            if (this.InvokeRequired)
//            {
//                this.BeginInvoke(new ShowInfoDelegate(ShowInfo), new object[] { barCode });
//            }
//            else
//            {
//                textBox1.Text = barCode.KeyName;
//                textBox2.Text = barCode.VirtKey.ToString();
//                textBox3.Text = barCode.ScanCode.ToString();
//                textBox4.Text = barCode.Ascll.ToString();
//                textBox5.Text = barCode.Chr.ToString();
//                textBox6.Text = barCode.IsValid ? barCode.BarCode : "";//是否为扫描枪输入，如果为true则是 否则为键盘输入
//                textBox7.Text += barCode.KeyName;
//                //MessageBox.Show(barCode.IsValid.ToString());
//            }
//        }
//        //C#中判断扫描枪输入与键盘输入
//        //Private DateTime _dt = DateTime.Now;  //定义一个成员函数用于保存每次的时间点
//        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
//        //{
//        //    DateTime tempDt = DateTime.Now;          //保存按键按下时刻的时间点
//        //    TimeSpan ts = tempDt .Subtract(_dt);     //获取时间间隔
//        //    if (ts.Milliseconds > 50)                           //判断时间间隔，如果时间间隔大于50毫秒，则将TextBox清空
//        //        textBox1.Text = "";
//        //    dt = tempDt ;
//        //}

//        void BarCode_BarCodeEvent(BardCodeHooK.BarCodes barCode)
//        {
//            ShowInfo(barCode);
//        }
//        private void FrmMain_Load(object sender, EventArgs e)
//        {
//            BarCode.Start();
//        }
//        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            BarCode.Stop();
//        }
//        private void textBox6_TextChanged(object sender, EventArgs e)
//        {
//            if (textBox6.Text.Length > 0)
//            {
//                MessageBox.Show("条码长度：" + textBox6.Text.Length + "\n条码内容：" + textBox6.Text, "系统提示");
//            }
//        }
//    }
//}