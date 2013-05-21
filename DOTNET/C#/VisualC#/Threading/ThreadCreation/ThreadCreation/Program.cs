using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultiThreadCreation creation = new MultiThreadCreation("Child 1");
            //MultiThreadCreation creation1 = new MultiThreadCreation("Child 2");
            //MultiThreadCreation creation2 = new MultiThreadCreation("Child 3");

            //ThreadWithArugment.RunThreadWithArugment();
            //AnonymousDelegate.AnonymousMain();
            //AddingThreadObject.MyMain();
            //AutoEvents.MainAutoEvents();
            //threadJoining.MainThreadJoining();
            
            //Calling SharedClass

            //SharingDataInThread.MainSharedThread();
            MyThreadPooling.MainMyThreadPooling();
                       
        }

    }
}
