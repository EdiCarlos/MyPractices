using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class BuilderPatternSample1
    {
        class Director
        {
            public void Constructor(IBuilder builder)
            {
                builder.BuildProductA();
                builder.BuildProductB();
                builder.BuildProductB();
            }
        }

        interface IBuilder
        {
            void BuildProductA();
            void BuildProductB();
            Product GetResult();
        }
        class Builder1 : IBuilder
        {
            Product prod;
            public Builder1()
            {
                prod = new Product();
            }
            #region IBuilder Members

            public void BuildProductA()
            {
                prod.Add("PartA");
            }

            public void BuildProductB()
            {
                prod.Add("PartB");
            }

            public Product GetResult()
            {
                return prod;
            }

            #endregion
        }
        class Builder2 : IBuilder
        {
            #region IBuilder Members
            Product product;
            public Builder2()
            {
                product = new Product();
            }
            public void BuildProductA()
            {
                product.Add("PartX");
            }

            public void BuildProductB()
            {
                product.Add("PartY");
            }

            public Product GetResult()
            {
                return product;
            }

            #endregion
        }

        class Product
        {
            List<string> product = new List<string>();
            public void Add(string productName)
            {
                product.Add(productName);
            }
            public void Display()
            {
                Console.WriteLine("Porduct list =====================");
                foreach (string item in product)
                {
                    Console.Write(item+"\t");
                }
            }
        }
        
        public class Client
        {
            public static void RunMain()
            {
                IBuilder builder1 = new Builder1();
                IBuilder builder2 = new Builder2();
                Director director = new Director();
                director.Constructor(builder1);

                Product product = builder1.GetResult();
                product.Display();

                director.Constructor(builder2);
                product = builder2.GetResult();
                product.Display();

            }
        }
    }
}
