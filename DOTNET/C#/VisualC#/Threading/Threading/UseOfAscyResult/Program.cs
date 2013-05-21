using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UseOfAscyResult
{
    class Program
    {
        public delegate string CallMethod(string firstName, string lastName);
        static void Main(string[] args)
        {
            Program prog = new Program();
            CallMethod call = new CallMethod(prog.ShowFullName);
           IAsyncResult result =  call.BeginInvoke("Aarif", "Khan", null, null);
           result.AsyncWaitHandle.WaitOne();
           string fullName = call.EndInvoke(result);
           Console.WriteLine(fullName);
        }

        public string ShowFullName(string firstName, string lastName)
        {
            Thread.Sleep(1000);
            return firstName + " - " + lastName;
        }
    }
}
