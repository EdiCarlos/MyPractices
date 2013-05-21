using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThrowReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               ResultClass result = ThrowExceptionClass.ThrowException();
               Console.WriteLine(result.Status);
               Console.WriteLine(result.Error);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class ThrowExceptionClass
    {
        public static ResultClass ThrowException()
        {
            ResultClass result = new ResultClass();

            try
            {
                string str = null;
                string[] strResult = str.Split('-');
                Console.WriteLine(strResult[0]);
                result.Status = "Success";
                result.Error = "";
            }
            catch (Exception ex)
            {
                result.Status = "Failure";
                result.Error = ex.Message;
                return result;
                throw new Exception("This is my excpetion " + ex.Message);
            }
            return result;
        }
    }
}
