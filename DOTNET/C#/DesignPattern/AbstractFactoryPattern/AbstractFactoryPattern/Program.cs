using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    //interface IBrand
    //{
    //    int Price { get; }
    //    string Material { get; }
    //}
    //class Gucci : IBrand
    //{
    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return 1000; }
    //    }

    //    public string Material
    //    {
    //        get { return "Crocodile skin"; }
    //    }

    //    #endregion
    //}

    //class Poochy : IBrand
    //{
    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return  100; }
    //    }

    //    public string Material
    //    {
    //        get { return "Plastic"; }
    //    }

    //    #endregion
    //}

    //class GroundCover : IBrand
    //{
    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return 2000; }
    //    }

    //    public string Material
    //    {
    //        get { return "South African Leather"; }
    //    }

    //    #endregion
    //}

    //interface IFactory<T> where T : IBrand
    //{
    //    IBag CreateBag();
    //    IShoes CreateShoes();
    //}

    //class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    //{
    //    #region IFactory<Brand> Members

    //    public IBag CreateBag()
    //    {
    //        return new Bag<Brand>();
    //    }

    //    public IShoes CreateShoes()
    //    {
    //        return new Shoes<Brand>();
    //    }

    //    #endregion
    //}

    //interface IBag
    //{
    //    string Matherial { get; }
    //}

    //interface IShoes
    //{
    //    int Price { get; }
    //}

    //class Bag<Brand> : IBag where Brand : IBrand, new()
    //{
    //    private Brand brand;
    //    public Bag()
    //    {
    //        brand = new Brand();
    //    }
    //    #region IBag Members

    //    public string Matherial
    //    {
    //        get { return brand.Material; }
    //    }

    //    #endregion
    //}

    //class Shoes<Brand> : IShoes where Brand : IBrand, new()
    //{
    //    Brand brand;
    //    public Shoes()
    //    {
    //        brand = new Brand();
    //    }
    //    #region IShoes Members

    //    public int Price
    //    {
    //        get { return brand.Price; }
    //    }

    //    #endregion
    //}

    //class Client<Brand> where Brand : IBrand, new()
    //{
    //    public void ClientMain()
    //    {
    //        IFactory<Brand> factory = new Factory<Brand>();
    //        IBag bag = factory.CreateBag();
    //        IShoes shoes = factory.CreateShoes();
    //        Console.WriteLine("I brought a bag made from " + bag.Matherial);
    //        Console.WriteLine("I bought shoes at this price " + shoes.Price);
    //    }
    //}

    //interface IBrand
    //{
    //    int Price { get; }
    //    string Material { get; }
    //}

    //class Gucci : IBrand
    //{
    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return 1000; }
    //    }

    //    public string Material
    //    {
    //        get { return "Crocodile Skin"; }
    //    }

    //    #endregion
    //}

    //class Poochy : IBrand
    //{
    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return 100; }
    //    }

    //    public string Material
    //    {
    //        get { return "Plastic"; }
    //    }

    //    #endregion
    //}

    //class GroundCover : IBrand
    //{

    //    #region IBrand Members

    //    public int Price
    //    {
    //        get { return 100; }
    //    }

    //    public string Material
    //    {
    //        get { return "South African leather"; }
    //    }

    //    #endregion
    //}

    //interface IFactory<Brand>  where Brand : IBrand
    //{
    //    IBag CreateBag();
    //    IShoes CreateShoes();
    //}

    //interface IBag
    //{
    //    int Price();
    //}

    //interface IShoes
    //{
    //    string Material();
    //}

    //class Bag<Brand> : IBag where Brand : IBrand, new()
    //{
    //    Brand brand;
    //    public Bag()
    //    {
    //        brand = new Brand();
    //    }
    //    public int Price()
    //    {
    //        return brand.Price;
    //    }
    //}

    //class Shoes<Brand> : IShoes where Brand : IBrand, new()
    //{
    //    Brand brand;
    //    public Shoes()
    //    {
    //        brand = new Brand();
    //    }

    //    #region IShoes Members

    //    public string Material()
    //    {
    //        return brand.Material;
    //    }

    //    #endregion
    //}

    //class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    //{


    //    #region IFactory<Brand> Members

    //    public IBag CreateBag()
    //    {
    //        return new Bag<Brand>();
    //    }

    //    public IShoes CreateShoes()
    //    {
    //        return new Shoes<Brand>();
    //    }

    //    #endregion
    //}

    //class Client<Brand> where Brand : IBrand, new()
    //{
    //    public void ClientMain()
    //    {
    //        IFactory<Brand> factory = new Factory<Brand>();
    //        IBag bag = factory.CreateBag();
    //        IShoes shoes = factory.CreateShoes();

    //        Console.WriteLine("I bought bag at this price " + bag.Price());
    //        Console.WriteLine("I bought shoes which is made of " + shoes.Material());
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //new Client<Poochy>().ClientMain();
            //new Client<Gucci>().ClientMain();
            //new Client<GroundCover>().ClientMain();

            //new ClientFactory().ClientMain();
            //new ClientMain<ProductA1>().clientMain();
            //new ClientMain<ProductA2>().clientMain();
            //new ClientMain<ProductB1>().clientMain();
            //new ClientMain<ProductB2>().clientMain();
            //new ClientMain<ProductB3>().clientMain();
            //IFactoryB factoryb = new Factory().GetFactoryB1<ProductB1>();
            //factoryb.ShowB();
            //((ProductB1)factoryb).BSepcific();

            AnimalFactoryPattern.Client.RunMain();
        }
    }

    interface IProductA
    {
        void A();
    }

    interface IProductB
    {
        void B();
    }
    
    class ProductA1 : IProductA
    {
        #region IProductA Members

        public void A()
        {
            Console.WriteLine("This is Product A1");
        }

        #endregion
    }

    class ProductA2 : IProductA
    {
        #region IProductA Members

        public void A()
        {
            Console.WriteLine("This is product A2");
        }
        #endregion
    }

    class ProductB1 : IProductB
    {
        #region IProductB Members

        public void B()
        {
            Console.WriteLine("This is B1");
        }
        public void BSepcific()
        {
            Console.WriteLine("This is B Specific method");
        }
        #endregion
    }

    class ProductB2 : IProductB
    {
        #region IProductB Members

        public void B()
        {
            Console.WriteLine("This is B2");
        }

        #endregion
    }

    class ProductB3 : IProductB
    {
        #region IProductB Members

        public void B()
        {
            Console.WriteLine("This is B3");
        }

        #endregion
    }

    interface IFactory
    {
        IFactoryA GetFactoryA1<Product>() where Product : IProductA, new();
        IFactoryB GetFactoryB1<Product>() where Product : IProductB, new();
    }

    interface IFactoryB
    {
        void ShowB();
    }

    interface IFactoryA
    {
        void ShowA();
    }

    class FactoryA<Product> : IFactoryA where Product : IProductA, new()
    {
        Product prod;
        public FactoryA()
        {
            prod = new Product();
        }
        public void ShowA()
        {
            prod.A();
        }
    }

    class FactoryB<Product> : IFactoryB where Product : IProductB, new()
    {
        Product prod;
        public FactoryB()
        {
            prod = new Product();
        }
        public void ShowB()
        {
            prod.B();
        }
    }

    class Factory : IFactory
    {
        //public IFactoryA GetFactoryA1<Product>() where Product : IProductA, new()
        //{
        //    return new FactoryA1<Product>();
        //}
        //public IFactoryB GetFactoryB1<Product>() where Product : IProductB, new()
        //{
        //    return new FactoryB1<Product>();
        //}
        #region IFactory Members

        public IFactoryA GetFactoryA1<Product>() where Product : IProductA, new()
        {
            return new FactoryA<Product>();
        }

        public IFactoryB GetFactoryB1<Product>() where Product : IProductB, new()
        {
            return new FactoryB<Product>();
        }

        #endregion
    }

    class ClientMain<Product> where Product : class, new()
    {
        public void clientMain()
        {
            if (typeof(Product) == typeof(ProductA1))
            {
                IFactoryA factoryA1 = new Factory().GetFactoryA1<ProductA1>();
                factoryA1.ShowA();
            }
            else if (typeof(Product) == typeof(ProductA2))
            {
                IFactoryA factoryA2 = new Factory().GetFactoryA1<ProductA2>();
                factoryA2.ShowA();
            }
            else if (typeof(Product) == typeof(ProductB1))
            {
                IFactoryB factoryB1 = new Factory().GetFactoryB1<ProductB1>();
                factoryB1.ShowB();
            }
            else if(typeof(Product) == typeof(ProductB2))
            {
                IFactoryB factoryB2 = new Factory().GetFactoryB1<ProductB2>();
                factoryB2.ShowB();
            }
            else if (typeof(Product) == typeof(ProductB3))
            {
                IFactoryB factoryB3 = new Factory().GetFactoryB1<ProductB3>();
                factoryB3.ShowB();
            }

        }
    }

    //interface IProductA
    //{
    //    void A();
    //}

    //interface IProductB
    //{
    //    void B();
    //}

    //class ProductA1 : IProductA
    //{
    //    #region IProductA Members

    //    public void A()
    //    {
    //        Console.WriteLine("Product A1");
    //    }

    //    #endregion
    //}

    //class ProductA2 : IProductA
    //{
    //    #region IProductA Members

    //    public void A()
    //    {
    //        Console.WriteLine("Product A2");
    //    }

    //    #endregion
    //}

    //class ProductB1 : IProductB
    //{
    //    #region IProductB Members

    //    public void B()
    //    {
    //        Console.WriteLine("Product B1");
    //    }

    //    #endregion
    //}

    //class ProductB2 : IProductB
    //{
    //    #region IProductB Members

    //    public void B()
    //    {
    //        Console.WriteLine("Product B2");
    //    }

    //    #endregion
    //}

    //interface IFactory
    //{
    //    IProductA ProductA();
    //    IProductB ProductB();
    //}

    //class Factory1 : IFactory
    //{

    //    #region IFactory Members

    //    public IProductA ProductA()
    //    {
    //        return new ProductA1();
    //    }

    //    public IProductB ProductB()
    //    {
    //        return new ProductB1();
    //    }

    //    #endregion
    //}

    //class Factory2 : IFactory
    //{
    //    #region IFactory Members

    //    public IProductA ProductA()
    //    {
    //        return new ProductA2();
    //    }

    //    public IProductB ProductB()
    //    {
    //        return new ProductB2();
    //    }

    //    #endregion
    //}


    //class ClientFactory
    //{
    //    public void ClientMain()
    //    {
    //        ////Factory factory = new Factory();
    //        ////IProductA productA = factory.ProductA<IProductA>();
    //        ////IProductB productB = factory.ProductB<IProductB>();
    //        ////IProductA productA = new Factory<ProductA1>().ProductA();
    //        //Factory<ProductA1> product = new Factory<ProductA1>();
    //        new Factory1().ProductA().A();
    //        new Factory1().ProductB().B();
    //        new Factory2().ProductA().A();
    //        new Factory2().ProductB().B();


    //    }
    //}

}
