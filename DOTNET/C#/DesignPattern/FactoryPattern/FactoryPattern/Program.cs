using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    interface IProduct
    {
        string ShipFrom();
    }
    class ProductA : IProduct
    {
        #region IProduct Members

        public string ShipFrom()
        {
            return "Ship from Africa";
        }

        #endregion
    }

    class ProductB : IProduct
    {
        #region IProduct Members

        public string ShipFrom()
        {
            return "Ship from Asia";
        }

        #endregion
    }
    class DefaultProduct : IProduct
    {
        #region IProduct Members

        public string ShipFrom()
        {
            return "No products at this time";
        }

        #endregion
    }

    class ProductFactory
    {
        public IProduct GetProductFactory(int productNumber)
        {
            IProduct product;
            if (productNumber <= 3)
            {
                product = new ProductA();
            }
            else if (productNumber <= 6)
            {
                product = new ProductB();
            }
            else
            {
                product = new DefaultProduct();
            }
            return product;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 12; i++)
            {
                IProduct product = new ProductFactory().GetProductFactory(i);
                Console.WriteLine(product.ShipFrom());
            }
        }
    }
}
