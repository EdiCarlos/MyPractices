using System;
using System.ComponentModel;

    class MainClass
    {
        static void Main()
        {
            var tom = new { Name = "Tom", Age = 4 };
            var holly = new { Name = "Holly", Age = 31 };
            var jon = new { Name = "Jon", Age = 31 };

            Console.WriteLine("{0} is {1} years old", jon.Name, jon.Age);
        }
    } 
