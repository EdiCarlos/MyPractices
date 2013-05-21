using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;

namespace LWithDatabase
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //mydbsqlDataContext db = new mydbsqlDataContext();
            //int result = new int();
            //Console.WriteLine("1. Insert");
            //Console.WriteLine("2. update");
            //Console.WriteLine("3. delete");
            //Console.WriteLine("4. Show Table");
            //result = Convert.ToInt32(Console.ReadLine());
            //switch (result)
            //{
            //    case 1:
            //        InsertDet(db);
            //        break;
            //    case 2:
            //        UpdateDet(db);
            //        break;
            //    case 3:
            //        DeleteDet(db);
            //        break;
            //    case 4:
            //        ShowTable(db);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;

            //}
            //Console.WriteLine("Enter Employee id");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Application.Run(new Form1());
            mydbsqlDataContext db = new mydbsqlDataContext();
            //var vr = from d in db.dets
            //        let firstName = string.Format("First Name {0}", d.fname)
            //         select new { EmployeeId = d.empid, FirstName = firstName.ToUpper()};
            var vr = from dt in db.dets join con in db.condets on dt.empid equals con.id into condt select condt;

           
            foreach (var item in vr)
            {
                //Console.WriteLine("Employee Id " + item.EmployeeId + " City " + item.City + " State " + item.State);
                foreach (var item1 in item)
                {
                  
                }
               
            }

            //DeleteRow(new mydbsqlDataContext());

        }
        public static void InsertInto(mydbsqlDataContext db)
        {
            int i = db.condetInsert("asdf", "maharastra", "india", "400057", "andheri(west)");
        }
        public static void DeleteRow(mydbsqlDataContext db)
        {
            int i = db.condetDelete(2);
        }
        private static void ShowTable(mydbsqlDataContext db)
        {
            //IQueryable<det> dt = from t1 in db.dets select t1;
            
            IEnumerable<det> dt = db.ExecuteQuery<det>(@"select * from det where empid = 3");
            Console.Write("| employee id |");
            Console.Write(" First Name |");
            Console.Write(" Last Name |");
            Console.Write(" Middle Name |");

            foreach (var v in dt)
            {
                Console.WriteLine();
                Console.Write(v.empid);
                Console.Write(" ");
                Console.Write(v.fname);
                Console.Write(" ");
                Console.Write(v.lname);
                Console.Write(" ");
                Console.Write(v.mname);
            }
        }

        private static void DeleteDet(mydbsqlDataContext db)
        {
            Console.WriteLine("Enter id to be deleted");
            IQueryable<det> iq = from t1 in db.dets where t1.empid == Convert.ToInt32(Console.ReadLine()) select t1;
            db.dets.DeleteOnSubmit(iq.First());
            db.SubmitChanges();
        }

        private static void UpdateDet(mydbsqlDataContext db)
        {
            Console.WriteLine("Enter employee id to be updated");
            int id = Convert.ToInt32(Console.ReadLine());
            var dt = from tdet in db.dets where tdet.empid == id select tdet;
            foreach (var v in dt)
            {
                Console.WriteLine("Enter you first name");
                v.fname = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                v.lname = Console.ReadLine();
                Console.WriteLine("Enter your middle name");
                v.mname = Console.ReadLine();
            }
            db.SubmitChanges();


        }

        private static void InsertDet(mydbsqlDataContext db)
        {
            Table<det> tb = db.GetTable<det>();
            det dt = new det();
            Console.WriteLine("Enter your first Name");
            dt.fname = Console.ReadLine();
            Console.WriteLine("Enter your last Name");
            dt.lname = Console.ReadLine();
            Console.WriteLine("Enter your middle Name");
            dt.mname = Console.ReadLine();
            db.dets.InsertOnSubmit(dt);
            db.SubmitChanges();
        }
    }
}
