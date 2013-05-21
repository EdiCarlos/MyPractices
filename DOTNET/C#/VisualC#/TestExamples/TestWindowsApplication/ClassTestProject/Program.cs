using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "RIV35070-0677-DHLES_0000067072.xls";
            int setupid = GetSivSetUpId(filename);
        }
        public static int GetSivSetUpId(string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            int indexofHphye = filePath.IndexOf('-');
            int retInt = Convert.ToInt32(filePath.Substring(indexofHphye + 1, 4));
            return retInt;
        }
    }
}
