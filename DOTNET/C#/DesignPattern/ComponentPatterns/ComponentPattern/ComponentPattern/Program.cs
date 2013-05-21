using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ComponentPattern
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> a);
        IComponent<T> Remove(T a);
        IComponent<T> Find(T s);
        string Display(int depth);
        T Name { get; set; }
    }
    public class Component<T> : IComponent<T>
    {

        public Component(T name)
        {
            Name = name;
        }
        public void Add(IComponent<T> a)
        {
            Console.WriteLine("Cannont add to item");
        }

        public IComponent<T> Remove(T a)
        {
            Console.WriteLine("Cannont remove directly");
            return this;
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public string Display(int depth)
        {
            return new String('-', depth) + Name + "\n";
        }

        public T Name
        {
            get;
            set;
        }
    }
    public class Composite<T> : IComponent<T>
    {
        List<IComponent<T>> list;
        IComponent<T> holder = null;
        public Composite(T name)
        {
            Name = name;
            list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> a)
        {
            list.Add(a);
        }

        public IComponent<T> Remove(T a)
        {
            holder = this;
            IComponent<T> p = holder.Find(a);
            if (holder != null)
            {
                (holder as Composite<T>).list.Remove(p);
                return holder;
            }
            else
                return this;
        }

        public IComponent<T> Find(T s)
        {
            holder = this;
            if (Name.Equals(s))
                return this;
            IComponent<T> found = null;
            foreach (IComponent<T> item in list)
            {
                found = item.Find(s);
                if (found != null)
                {
                    break;
                }
            }
            return found;
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new String('-', depth));
            s.Append("Set " + Name + " Length " + list.Count + "\n");
            foreach (IComponent<T> component in list)
            {
                s.Append(component.Display(depth + 2));
            }
            return s.ToString();
        }

        public T Name
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> album = new Composite<string>("Album");
            IComponent<string> point = album;
            string[] s;
            string parameter, command;
            StreamReader inStream = new StreamReader("Composite.dat");
            do
            {
                string line = inStream.ReadLine();
                Console.WriteLine("\t\t\t\t" + line);
                s = line.Split();
                command = s[0];
                if (s.Length > 1)
                {
                    parameter = s[1];
                }
                else
                    parameter = null;
                switch (command)
                {
                    case "AddSet":
                        IComponent<string> addset = new Composite<string>(parameter);
                        point.Add(addset);
                        point = addset;
                        break;
                    case "AddPhoto":
                        point.Add(new Component<string>(parameter));
                        break;
                    case "Remove":
                        point.Remove(parameter);
                        break;
                    case "Find":
                        point = album.Find(parameter);
                        break;
                    case "Display":
                        Console.WriteLine(point.Display(0));
                        break;
                    case "Quit":
                        
                        break;

                }
            } while (!command.Equals("Quit"));
        }
    }
}
