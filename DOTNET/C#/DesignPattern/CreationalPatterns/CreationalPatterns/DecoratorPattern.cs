using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class DecoratorPattern
    {
        interface IDecorator
        {
            string CoffeeType();
            double getPrice();
        }
        class Coffee : IDecorator
        {
            double price;
            IDecorator iCoffee;
            public Coffee(IDecorator iCoffee)
            {
                this.iCoffee = iCoffee;
                price = 1.50;
            }
            public string CoffeeType()
            {
                return "Coffee is with milk";
            }

            public double getPrice()
            {
                return price;
            }
        }
        class BlackCoffee : IDecorator
        {
            double price = 0;
            public BlackCoffee()
            {
                price = 1.2;
            }
            public string CoffeeType()
            {
                return "Coffee without milk";
            }

            public double getPrice()
            {
                return price;
            }
        }

        class ChoclateCoffee : IDecorator
        {
            IDecorator iCoffee;
            double price;
            public ChoclateCoffee(IDecorator iCoffee)
            {
                this.iCoffee = iCoffee;
                price = 1;
            }
            public string CoffeeType()
            {
                return iCoffee.CoffeeType() + " and with some choclate";
            }
            public double getPrice()
            {
                return price + iCoffee.getPrice();
            }
        }

        class CreamCoffee : IDecorator
        {
            IDecorator iCoffee;
            double price = 0;
            public CreamCoffee(IDecorator iCoffee)
            {
                this.iCoffee = iCoffee;
                price = 0.5;
            }
            public string CoffeeType()
            {
                return iCoffee.CoffeeType() + " and with some \"Cream\"";
            }

            public double getPrice()
            {
                return iCoffee.getPrice() + price;
            }
        }

        public class MakeCoffee
        {
            public static void CoffeePanel()
            {
                IDecorator blackCoffee = new BlackCoffee();
                ShowCoffee(blackCoffee);
                IDecorator coffee = new Coffee(blackCoffee);
                ShowCoffee(coffee);
                IDecorator chocolate = new ChoclateCoffee(coffee);
                ShowCoffee(chocolate);
                IDecorator cream = new CreamCoffee(coffee);
                ShowCoffee(cream);
                IDecorator creamAndChocolate = new CreamCoffee(chocolate);
                ShowCoffee(creamAndChocolate);
            }

            private static void ShowCoffee(IDecorator coffee)
            {
                Console.WriteLine("Type : "+coffee.GetType().Name);
                Console.Write("Coffee Ingredients : " + coffee.CoffeeType());
                Console.WriteLine(String.Format("\nPrice in Rupees : {0}", coffee.getPrice().ToString()));
            }
        }
    }
}
