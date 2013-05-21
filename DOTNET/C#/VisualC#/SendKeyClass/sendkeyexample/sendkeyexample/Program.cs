using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using SHDocVw;
using System.Reflection;
using mshtml;
using System.Diagnostics;

namespace sendkeyexample
{
    class Form1 : System.Windows.Forms.Form
    {
        
    }
    class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hwnd, StringBuilder build, int max);
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hwnd);

        public static bool WindowEnumProc(IntPtr hwnd, int lParam)
        {
            // get the text from the window
            StringBuilder bld = new StringBuilder(256);
            string text = string.Empty;

            try
            {
                GetWindowText(hwnd, bld, 256);
                text = bld.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (text.Length > 0)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("error");
            }
            return true;
        }
        static void Main(string[] args)
        {
            Form1 frm = new Form1();
            frm.Show();
            Process[] proc = Process.GetProcesses();
            IntPtr hwnd = IntPtr.Zero;
            foreach (var pr in proc)
            {
                hwnd = pr.MainWindowHandle;
                if (hwnd != IntPtr.Zero)
                {
                    int length = GetWindowTextLength(hwnd);
                    StringBuilder bd = new StringBuilder(length+ 1);
                    GetWindowText(hwnd, bd, bd.Capacity);
                    Console.WriteLine(bd.ToString());
                    ShowWindow(bd);
                }
            }
            
            //IntPtr hwnd = FindWindow("IEFrame", "Google - Microsoft Internet Explorer");
            //if (hwnd == IntPtr.Zero)
            //{
            //    Console.WriteLine("Calculator is not running");
            //    return;
            //}
            //SetForegroundWindow(hwnd);
            //Thread.Sleep(500);            
            ////SendKeys.SendWait("coolkamal89");
            ////Thread.Sleep(500);
            //SendKeys.SendWait("coolkamal89");
            //Thread.Sleep(500);
            //SendKeys.SendWait("{Enter}");

            //Object o = null;
            //InternetExplorer ie = new InternetExplorer();
            //object url = "http://www.gmail.com";
            //ie.Navigate2(ref url, ref o,ref o,ref o,ref o);
            //ie.Visible = true;
            //do
            //{
            //} while (ie.Busy);
            //HTMLDocument doc =  (HTMLDocument)ie.Document;
            ////IHTMLElementCollection htmlcollection;
            //HTMLInputElement inputgmail = (HTMLInputElement)doc.getElementsByName("Email").item(null, 0);
            //inputgmail.value = "arif788";
            //Thread.Sleep(500);
            //HTMLInputElement inputpass = (HTMLInputElement)doc.getElementsByName("Passwd").item(null, 0);

            //Thread.Sleep(500);
            //HTMLButtonElement submit = (HTMLButtonElement)doc.getElementsByName("signIn").item(null, 0);
            //submit.click();
            //BusyFunction(ie);
            //MessageBox.Show("user logged in");

        }

        private static void ShowWindow(StringBuilder bd)
        {
             IntPtr hwnd =  FindWindow("IEFrame", bd.ToString());
            SetForegroundWindow(hwnd);
        }

        private static void BusyFunction(InternetExplorer ie)
        {
            do
            {
            } while (ie.Busy);
        }
    }
}
