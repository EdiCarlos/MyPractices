using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using HelloWorldRemote;

namespace AppDomainExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create your own app domain
            AppDomain appDomain = AppDomain.CreateDomain("HelloWorld");
            appDomain.ExecuteAssembly(@"d:\temp\csc\HelloWorldRemote.exe");

            //load the exe into an assembly and calling desired class
            //Assembly newAssembly = Assembly.LoadFrom(@"d:\temp\csc\HelloWorldRemote.exe");
         //   newAssembly.CreateInstance("HelloWorldRemote.RemoteObject");
        //newAssembly.Execute

            //HelloWorldRemote.RemoteObject remote = new RemoteObject();
            //MyRemoteObject myremote = new MyRemoteObject();
            //myremote.ShowName();
        }
    }
}
