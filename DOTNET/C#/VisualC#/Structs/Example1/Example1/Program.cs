using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Security;

namespace Example1
{
    struct MyStruct
    {
        public string fname, lname, mname;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string address, city, state;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        
        public void AddressDetails()
        {
            
        }
        //public MyStruct(string f, string l, string m)
        //{
        //    this.fname = f;
        //    this.lname = l;
        //    this.mname = m;
        //    //this.age = 0;
        //    //this.address = "Juhu Lane";
        //    //this.city = "Mumbai";
        //    //this.state = "Maharastra";
        //}
        public void FullName()
        {
            //Console.WriteLine(fname + " " + lname + " " + mname);
            Console.WriteLine(string.Format("{0} {1} {2}", fname, lname, mname));
        
        }
        public void ShowAge()
        {
            Console.WriteLine(age);
        }
        public static MyStruct GetMyStruct()
        {
            return new MyStruct();
        }
        
    }
    interface MyInterface
    {
        void Show();
        void Write();
    }
    abstract class A
    {
        public abstract void ShowFunc();
        public virtual void WriteFunc()
        {
            Console.WriteLine("Virtual Function in Class A");
        }
    }
    class B : A
    {
        public override void ShowFunc()
        {
            Console.WriteLine("Show Function implemented in Class B");
        }
        public override void WriteFunc()
        {
            Console.WriteLine("Write Function in class B");
            base.WriteFunc();
        }
    }
    struct BaseStruct : MyInterface
    {
        #region MyInterface Members

        void MyInterface.Show()
        {
            Console.WriteLine("Show Function in BaseStruct");
        }

        void MyInterface.Write()
        {
            Console.WriteLine("Write Function in BaseStruct");
        }

        #endregion
    }
    struct DerivedStruct : MyInterface
    {

        #region MyInterface Members

        public void Show()
        {
            Console.WriteLine("Show function in DerivedStruct");
        }


        public void Write()
        {
            Console.WriteLine("Write function in DerivedStruct");
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyStruct mystr = MyStruct.GetMyStruct();
            //mystr.FullName();
            //MyInterface inter = new BaseStruct();
            //inter.Show();
            //inter.Write();
            //B b = new B();
            //b.ShowFunc();
            //b.WriteFunc();
            //DerivedStruct drive = new DerivedStruct();
            //drive.Show();
            //drive.Write();
            Console.WriteLine(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            
        }
    }
}
