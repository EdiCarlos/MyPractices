using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LowLevelHooks
{

    public partial class Form1 : Form
    {
        const int WH_KEYBOARD_LL = 13;
        const int WH_KEYDOWN = 0x100;
        const int WH_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        const int CONTROL = 0x11;
        const int LALT_DOWN = 0x12;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetAsyncKeyState(int keycode);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, ref KBDLLHOOKSTRUCT lParam);
        private IntPtr ptrHook = IntPtr.Zero;
        private LowLevelKeyboardProc objKeyboardProcess;

        [StructLayout(LayoutKind.Sequential)]
        public struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        public IntPtr CaptureKeys(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lparam)
        {
            if (nCode >= 0)
            {
                Keys key = lparam.key;

                if (((int)wParam == WH_KEYDOWN)&& key == Keys.Tab && Convert.ToBoolean(GetAsyncKeyState(CONTROL)))
                {
                    MessageBox.Show("Alt tab pressed");
                }

                //MessageBox.Show(GetAsyncKeyState(Keys.A).ToString());
                
            }
            return CallNextHookEx(ptrHook, nCode, wParam,ref lparam);
        }
        public Form1()
        {
            InitializeComponent();
            hook();
        }

        private void unhook()
        {
            UnhookWindowsHookEx(ptrHook);
        }
        private void hook()
        {
            objKeyboardProcess = new LowLevelKeyboardProc(CaptureKeys);
            ptrHook = SetWindowsHookEx(WH_KEYBOARD_LL, objKeyboardProcess, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
        }
        ~Form1()
        {
            unhook();
        }

    }
}

