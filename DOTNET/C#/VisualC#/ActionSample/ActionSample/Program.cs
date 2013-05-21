using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Command sample = new DelegateSample();
            Console.WriteLine("Enter command to write using Delegate sample");
            sample.Execute(Console.ReadLine());
            Command actionSample = new SimpleAction();
            Console.WriteLine("Enter command to write using Simple action sample");
            actionSample.Execute(Console.ReadLine());
            Command anonSample = new AnonymousAction();
            Console.WriteLine("Enter command to write using Anonymous action sample");
            anonSample.Execute(Console.ReadLine());
            Command lambdaSample = new LambdaAction();
            Console.WriteLine("Enter command to write using Lambda action sample");
            lambdaSample.Execute(Console.ReadLine());
            Command frSample = new ForEachAction();
            Console.WriteLine("Enter command to write using Foreach action sample");
            frSample.Execute(Console.ReadLine());
        }
    }
}
