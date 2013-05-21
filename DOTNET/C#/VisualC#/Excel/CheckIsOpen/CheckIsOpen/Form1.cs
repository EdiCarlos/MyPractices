using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace CheckIsOpen
{
    public partial class Form1 : Form
    {
        public static FileStream fs;
        public static string __message;
        public Form1()
        {
            string excelPath = @"d:\documents and settings\axkhan2\desktop\excel.xls";
            InitializeComponent();
            try
            {

                if (FileInUse(excelPath, ref __message ))
                {
                    MessageBox.Show(__message);
                }
                else
                {
                    MessageBox.Show("File is not in use");
                }
            }
            catch
            { }
        }
        
        static bool FileInUse(string path,ref string __message)
        {
            try
            {
                //Just opening the file as open/create
                using (fs = new FileStream(path, FileMode.Open))
                {
                    //If required we can check for read/write by using fs.CanRead or fs.CanWrite
                    fs.Lock(0, int.MaxValue);
                }
                return false;
            }
            catch (IOException ex)
            {
                //check if message is for a File IO
                __message = ex.Message.ToString();
                if (__message.Contains("The process cannot access the file"))
                    return true;
                else
                    throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fs.Unlock(0, int.MaxValue);
        }

    }
}
