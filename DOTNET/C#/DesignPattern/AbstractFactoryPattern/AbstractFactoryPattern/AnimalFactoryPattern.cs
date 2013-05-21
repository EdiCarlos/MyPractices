using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    class AnimalFactoryPattern
    {
        abstract class ContinentFactory
        {
            public abstract Herbivorse CreateHerbivores();
            public abstract Carnivorse CreateCarnivores();
        }
        
        abstract class Herbivorse
        {
 
        }
        
        abstract class Carnivorse
        {
           public abstract void Eats(Herbivorse herbivorse);
        }

        class Lion : Carnivorse 
        {
            public override void Eats(Herbivorse herbivorse)
            {
                Console.WriteLine("Lion eats "+herbivorse.ToString());
            }
        }

        class Cow : Herbivorse
        {
        }

        class Wolf : Carnivorse
        {
            public override void Eats(Herbivorse herbivorse)
            {
                Console.WriteLine(this.GetType() + " eats " + herbivorse.ToString());
            }
        }

        class Bison : Herbivorse { }

        class AmericanAnimalFactory : ContinentFactory
        {
            public override Herbivorse CreateHerbivores()
            {
                return new Bison();
            }

            public override Carnivorse CreateCarnivores()
            {
                return new Wolf();
            }
        }

        class AfricanAnimalFactory : ContinentFactory
        {
            public override Herbivorse CreateHerbivores()
            {
                return new Cow();
            }

            public override Carnivorse CreateCarnivores()
            {
                return new Lion();
            }
        }

        class AnimalWorld
        {
            public Herbivorse _herbivorse;
            public Carnivorse _carnivorse;
            public AnimalWorld(ContinentFactory factory)
            {
                _herbivorse = factory.CreateHerbivores();
                _carnivorse = factory.CreateCarnivores();
            }
            public void Run()
            {
                _carnivorse.Eats(_herbivorse);
            }
        }

        public class Client
        {
            public static void RunMain()
            {
                ContinentFactory americanFactory = new AmericanAnimalFactory();
                ContinentFactory africanFactory = new AfricanAnimalFactory();
                AnimalWorld world = new AnimalWorld(americanFactory);
                world.Run();
                AnimalWorld world1 = new AnimalWorld(africanFactory);
                world1.Run();
            }
        }
    }
}
