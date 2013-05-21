using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mshtml;
using SHDocVw;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoMateIExplore
{
    public delegate bool CallBack(int hwnd, int Lparam);

    class Program
    {
        [DllImport("user32.dll")]
        public static extern int EnumWindows(CallBack call, int y);
        [DllImport("user32.dll")]
        public static extern void GetWindowText(int h, StringBuilder sb, int MaxCount);
        [DllImport("user32.dll")]
        public static extern void GetClassName(int h, StringBuilder sb, int MaxCount);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        static StringBuilder sb;

        public static bool EnumeratorWindow(int hwnd, int lParam)
        {
            //windowHandler = (IntPtr)hwnd;
            sb = new StringBuilder(1024);
            GetClassName(hwnd, sb, sb.Capacity);
            GetWindowText(hwnd, sb, sb.Capacity);
            Console.WriteLine(sb.ToString());
            return true;
        }

        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            
            process.Kill();
            //InternetExplorer ie = new InternetExplorer();
            //object Empty = 0;
            
            //ie.BeforeNavigate2 += new DWebBrowserEvents2_BeforeNavigate2EventHandler(ie_BeforeNavigate2);
            //ie.Visible = true;
            //ie.Navigate("http://www.google.com", ref Empty, ref Empty, ref Empty, ref Empty);
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(500);
            //    SendKeys.Send("{Tab}");
            //}
            //Thread.Sleep(10000);
            //ie.Quit();
           
            //CallBack call = new CallBack(EnumeratorWindow);
            //EnumWindows(call, 0);
        }

        static void ie_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            Console.WriteLine("Before navigate called");
        }
    }
}
