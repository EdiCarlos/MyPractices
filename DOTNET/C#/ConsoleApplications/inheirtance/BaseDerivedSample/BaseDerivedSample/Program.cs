using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseDerivedSample
{
    class Parent
    {
        protected int Cars = 0;
        public Parent()
        {

        }
        public Parent(int numberOfCars)
        {
            Cars = numberOfCars;
        }
        public void showNumberOfCar()
        {
            Console.WriteLine(Cars);
        }
    }
    class Child : Parent
    {
        string carName;
        int childOwnedCars;
        public Child()
        {
        }
        public Child(string carName, int ownCars) : base(ownCars)
        {
            this.carName = carName;
            childOwnedCars = ownCars;
        }
        public Child(string carName, int ownCars, int age) 
        {
            this.carName = carName;
            childOwnedCars = ownCars;
        }

        public void showNumberOfCars()
        {
            Console.WriteLine("Car Name " + carName + " Number of cars : "+childOwnedCars);
        }
        public void ShowParentCars()
        {
            this.showNumberOfCar();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("Ferrari", 2);
            child.showNumberOfCars();
            child.ShowParentCars();
            //Parent parent = child;
            //parent.showNumberOfCar();
        }
    }
}
