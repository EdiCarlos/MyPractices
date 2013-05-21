using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPatternSample
{
    public interface IGenericCommand
    {
        void Add();
        void Remove();
        void RemoveAt();
        void PrintList();
    }
    public class CommandSample1
    {
        private List<string> command = new List<string>();
        public void AddCommand(string commandName)
        {
            this.command.Add(commandName);
        }

        public void ExecuteCommand(IGenericCommand gncommand)
        {
            foreach (string cm in command)
            {
                if (cm.Equals("Add"))
                {
                    gncommand.Add();
                }
                else if (cm.Equals("Remove"))
                {
                    gncommand.Remove();
                }
                else if (cm.Equals("RemoveAt"))
                {
                    gncommand.RemoveAt();
                }
                else if (cm.Equals("PrintList"))
                {
                    gncommand.PrintList();
                }
            }
        }
    }
    public class Functions
    {
        private List<string> liStr = new List<string>();
        public void AddString(string str)
        {
            liStr.Add(str);
        }
        public void RemoveString(string str)
        {
            liStr.Remove(str);
        }
        public void RemoveStringAt(int num1)
        {
            liStr.RemoveAt(num1-1);
        }
        public void PrintList()
        {
            int counter = 0;
            Console.WriteLine("Printing List");
            foreach (string str in liStr)
            {
                Console.WriteLine((++counter).ToString() +" = " + str );
            }
        }
    }
    public class UseGenericCommand : IGenericCommand
    {
        Functions _func;
        public UseGenericCommand(Functions func)
        {
            _func = func;
        }
        public void Add()
        {
            Console.WriteLine("Enter word to enter");
            _func.AddString(Console.ReadLine());
            _func.PrintList();
        }

        public void Remove()
        {
            Console.WriteLine("Enter word to remove from list");
            _func.RemoveString(Console.ReadLine());
            _func.PrintList();
        }

        public void RemoveAt()
        {
            Console.WriteLine("Enter number to remove specific item");
            _func.RemoveStringAt(Convert.ToInt32(Console.ReadLine()));
            _func.PrintList();
        }
        public void PrintList()
        {
            _func.PrintList();
        }
    }

}
