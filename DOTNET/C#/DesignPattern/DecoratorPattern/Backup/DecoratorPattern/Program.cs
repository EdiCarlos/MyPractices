using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Display(string s, IComponent c)
        {
            Console.WriteLine(s + " " + c.Operation());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern \n");
            IComponent component = new Component();

            Display("A: BasicPattern", component);
            Display("B: DecoratorAPattern", new DecoratorA(component));
            Display("C: DecoratorBPattern", new DecoratorB(component));
            Display("D: MixedPattern A>>B>> ", new DecoratorA(new DecoratorB(component)));
            Display("E: MixedPattern B>>A>>C ", new DecoratorB(new DecoratorA(component)));

            DecoratorB b = new DecoratorB(new Component());
            Console.WriteLine("F: " + new DecoratorA(b));
            Console.WriteLine(b.addBehavior());
            Console.WriteLine(b.addState);
        }
    }
    interface IComponent
    {
        string Operation();
    }
    class Component : IComponent
    {
        public string Operation()
        {
            return "I'm in Component Class>>";
        }
    }
    class DecoratorA : IComponent
    {
        IComponent component;
        public DecoratorA(IComponent c)
        {
            component = c;
        }
        public string Operation()
        {
            string decoratorA = component.Operation();
            return decoratorA + "I'm in DecoratorA Class>>";
        }
    }
    class DecoratorB : IComponent
    {
        IComponent component;
        public string addState = "State added to DecoratorB>>";
        public DecoratorB(IComponent c)
        {
            component = c;
        }
        public string Operation()
        {
            return component.Operation() + "I'm in DecoratorB Class>>";
        }
        public string addBehavior()
        {
            return "Added Behaviour to DecoratorB";
        }
    }
}

