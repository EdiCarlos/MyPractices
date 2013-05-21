using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyGenerics<int> mygen = new MyGenerics<int>(100);
            

            //    myclass[] m = new myclass[5];
            //    //for (int i = 0; i <= m.GetUpperBound(0); i++)
            //    //{
            //    //    m[i] = new myclass("Sub" + i);
            //    //}
            //    //Console.WriteLine(m.GetUpperBound(0));
            //    //Console.WriteLine(m.GetLowerBound(0));

            //    //MyGenerics<myclass> mygen = new MyGenerics<myclass>(m);
            //    ////mygen.ShowT();
            //    //mygen.IterateT();
            //    int num1 = 10;
            //    int num2 = 20;
            //    string fname = "arif";
            //    string lname = "khan";
            //    Console.WriteLine("Number1 : " + num1 + " Number2 : " + num2);

            //    GenericMethod method = new GenericMethod();
            //    method.Swap<int>(ref num1, ref num2);
            //    method.Swap<string>(ref fname, ref lname);
            //    Console.WriteLine("Frist name " + fname + " Lname " + lname);
            //    Console.WriteLine("Number1 : " + num1 + " Number2 : " + num2);
            //}
            BaseClass<int> bs = new BaseClass<int>(100, 200);
            bs.Show();
            bs.Swap();
            bs.Show();
            
            
        }
        class myclass
        {
            string classname = String.Empty;
            public myclass()
            {

            }
            public myclass(string t)
            {
                classname = t;
            }
            public override string ToString()
            {
                //return base.ToString();
                return classname;
            }
        }
    }
}

