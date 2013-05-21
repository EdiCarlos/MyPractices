using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost; Database=mydb; uid=root; pwd=andheri; encrypt=true"))
            {
                try
                {
                    con.Open();
                    //MySqlCommand cmd = new MySqlCommand("insert into mytb (username, userpass, useremail) values ('saima788','password', 'saima@gmail.com'); ", con);
                    //int i = cmd.ExecuteNonQuery();
                    //if (i != 0)
                    //{
                    //    Console.WriteLine("Number of rows affected " + i.ToString());

                    //}
                    //else
                    //{
                    //    Console.WriteLine("insertion failed " + i.ToString());
                    //}
                }
                catch (MySqlException myexception)
                {
                    Console.WriteLine(myexception.Message);
                }
            }
        }
    }
}
