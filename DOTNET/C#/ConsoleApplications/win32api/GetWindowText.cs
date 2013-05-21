using System;
using System.Text;
using System.Runtime.InteropServices;

namespace enumchildren
{

    class WindowEnumerator
    {
        // declare the delegate
        public delegate bool WindowEnumDelegate(IntPtr hwnd,
                                                 int lParam);

        // declare the API function to enumerate child windows
        [DllImport("user32.dll")]
        public static extern int EnumChildWindows(IntPtr hwnd,
                                                  WindowEnumDelegate del,
                                                  int lParam);

        // declare the GetWindowText API function
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hwnd,
                                               StringBuilder bld, int size);

        static void Main(string[] args)
        {
            // instantiate the delegate
            //	 WindowEnumDelegate del 
            //        = new WindowEnumDelegate(WindowEnumProc);

            // call the win32 function
            //	 EnumChildWindows(IntPtr.Zero, del, 0);

            WindowEnumProc(IntPtr.Zero, 0);

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        public static bool WindowEnumProc(IntPtr hwnd, int lParam)
        {
            // get the text from the window
            StringBuilder bld = new StringBuilder(256);
            string text;

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
    }
}