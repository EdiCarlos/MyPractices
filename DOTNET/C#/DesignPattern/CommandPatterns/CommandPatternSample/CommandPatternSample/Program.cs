using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPatternSample
{
    public interface ICommand
    {
        void Execute();
    }
    public class Switch : ICommand
    {
        private List<ICommand> commandHistory = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            
            this.commandHistory.Add(command);
        }
        public void Execute()
        {
            foreach (ICommand command in commandHistory)
            {
                command.Execute();
            }
        }
    }
    public class Light
    {
        public void TrunOn()
        {
            Console.WriteLine("Light is on");
        }
        public void TrunOff()
        {
            Console.WriteLine("Light is off");
        }
    }
    public class FlipUp : ICommand
    {
        Light _light;
        public FlipUp(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TrunOn();
        }
    }
    public class FlipDown : ICommand
    {
        Light _light;
        public FlipDown(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TrunOff();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICommand commandON = new CommandPatternSample.FlipUp(new Light());
            ICommand commandOff = new CommandPatternSample.FlipDown(new Light());
            Switch s = new Switch();
            try
            {
                while (true)
                {
                    Console.WriteLine("Press x to Exit");
                    Console.WriteLine("Press a to Execute"); 
                    Console.WriteLine("Press 0 to Switch the lights on");
                    Console.WriteLine("Press 1 to Switch the lights off");
                    char result = Console.ReadKey().KeyChar;

                    if (result.ToString().Equals("0"))
                    {
                        s.AddCommand(commandON);
                    }
                    else if (result.ToString().Equals("1"))
                    {
                        s.AddCommand(commandOff);
                    }
                    else if (result.ToString().Equals("a"))
                    {
                        s.Execute();
                    }
                    if (result.ToString().ToLower().Equals("x"))
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            //IGenericCommand gnCommand = new UseGenericCommand(new Functions());
            //CommandSample1 sample = new CommandSample1();
            //while (true)
            //{
            //    Console.WriteLine("Enter \"e\" to enter command");
            //    Console.WriteLine("Enter \"a\" to execute all commands");
            //    string result = Console.ReadKey().KeyChar.ToString();
            //    if (result.Equals("e"))
            //    {
            //        Console.WriteLine("Press 1 For Add Command");
            //        Console.WriteLine("Press 2 For Remove Command");
            //        Console.WriteLine("Press 3 For Remove from particular position");
                    
            //        string res = Console.ReadKey().KeyChar.ToString();
            //        switch (res)
            //        {
            //            case "1":
            //                sample.AddCommand("Add");
            //                break;
            //            case "2":
            //                sample.AddCommand("Remove");
            //                break;
            //            case "3":
            //                sample.AddCommand("RemoveAt");
            //                break;
            //        }
            //    }
            //    else if (result.Equals("a"))
            //    {
            //        sample.ExecuteCommand(gnCommand);
            //    }
            //    else if (result.Equals("x"))
            //    {
            //        break;
            //    }
            //}
        }
    }
}
namespace CommandSample
{
    public interface ICommand
    {
        void Execute();
    }
    public class Switch : ICommand
    {
        List<ICommand> command = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            this.command.Add(command);
        }
        public void Execute()
        {
            command.ForEach((s) => { s.Execute(); });
        }
    }
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turned off");
        }
    }
   
    public class FileUP : ICommand
    {
        Light light;
        public FileUP(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
    }
    public class FileDown : ICommand
    {
        Light _light;
        public FileDown(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
    public class Execution
    {
        public static void Run()
        {
            ICommand flipUPcomand = new FileUP(new Light());
            ICommand flipDowncomand = new FileDown(new Light());

            Switch s = new Switch();
            s.AddCommand(flipDowncomand);
            s.AddCommand(flipUPcomand);
            s.Execute();

        }
    }
}
