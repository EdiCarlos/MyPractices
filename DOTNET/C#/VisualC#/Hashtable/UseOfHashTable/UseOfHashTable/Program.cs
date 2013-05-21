using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace UseOfHashTable
{
    class Program
    {
        static object obj;
        static void Main(string[] args)
        {

            Hashtable table1 = new Hashtable();
            table1.Add("1", 100);
            table1.Add("2", 200);
            table1.Add("3", 300);
            table1.Add("4", 400);
            table1.Add("5", 500);
            AddToObj(table1);
            //obj = table1;
            ReadObject(obj);
            //
            Hashtable table2 = new Hashtable();
            table2.Add("1", 600);
            table2.Add("7", 700);
            table2.Add("8", 800);
            table2.Add("9", 900);
            table2.Add("10", 1000);
            AddToObj(table2);
            //obj = table2;
            ReadObject(obj);

        }

        private static void AddToObj(Hashtable table)
        {
            Hashtable objTable = (Hashtable)obj;
            if (objTable != null)
            {
                foreach (DictionaryEntry entry in objTable)
                {
                    if (!objTable.Contains(entry.Key))
                    {
                        objTable.Add(entry.Key, entry.Value);
                    }
                }
            }
            else
            {
                obj = table;
            }
        }

        private static void ReadObject(object obj)
        {
            Hashtable table = obj as Hashtable;
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }
            Console.WriteLine("End Reading");
        }
    }
}
