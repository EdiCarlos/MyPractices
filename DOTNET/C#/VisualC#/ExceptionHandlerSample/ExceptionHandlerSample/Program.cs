using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyExceptionGeneration.NullException();
            }
            catch (Exception ex)
            {
                SampleException sample = new SampleException(ex.ToString());
               
            }

        }

    }
    class MyExceptionGeneration
    {
        public static int number1 = 10;
        public static void NullException()
        {
            try
            {
                if (number1 != 100)
                {
                    throw new Exception("Number1 is not equal to 100");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("{0} : {1}", "NullException", ex.Message));
            }
        }
    }
    [Serializable]
    public class SampleException : Exception
    {
        public SampleException()
        {
            Console.WriteLine("Exception Occured");
        }
        public SampleException(string message)
            : base(message)
        {
            Console.WriteLine(message);
        }
        public SampleException(string message, Exception inner)
            : base(message, inner)
        {
            Console.WriteLine(message);
            Console.WriteLine(inner.StackTrace);
        }
        protected SampleException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
        public void PrintStackTrace()
        {
            Console.WriteLine(this.StackTrace);
        }
    }

}
