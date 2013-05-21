using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class CarBuilderSample
    {
        class CarParts
        {
            List<string> carParts = new List<string>();
            public void AssembleParts(string partName)
            {
                carParts.Add(partName);
            }
            public void ShowAllThePartsInCar()
            {
                int count = 1;
                foreach (string part in carParts)
                {
                    Console.WriteLine(count+" " + part);
                }
            }
        }
        interface ICarBuilder
        {
            void BuildCar();
            CarParts GetParts();
        }
        class LuxuryCar : ICarBuilder
        {
            #region ICarBuilder Members
            CarParts parts = new CarParts();
            public void BuildCar()
            {
                parts.AssembleParts("Wheels");
                parts.AssembleParts("Upholestry");
                parts.AssembleParts("Color");
                parts.AssembleParts("AirCondition");
            }

            public CarParts GetParts()
            {
                return parts;
            }

            #endregion
        }
        class EconomyCar : ICarBuilder
        {
            #region ICarBuilder Members
            CarParts parts = new CarParts();
            
            public void BuildCar()
            {
                parts.AssembleParts("Wheels");
                parts.AssembleParts("Color");
            }

            public CarParts GetParts()
            {
                return parts;
            }
            #endregion
        }
        class MediumCar : ICarBuilder
        {
            #region ICarBuilder Members
            CarParts parts = new CarParts();
            public void BuildCar()
            {
                parts.AssembleParts("Wheels");
                parts.AssembleParts("Color");
                parts.AssembleParts("AirCondition");
            }

            public CarParts GetParts()
            {
                return parts;
            }

            #endregion
        }
        class CarBuilderDirector
        {
            public void Constructor(ICarBuilder builder)
            {
                builder.BuildCar();
            }
        }
        public class Client
        {
            public static void UseCar()
            {
                ICarBuilder luxuryCar = new LuxuryCar();
                ICarBuilder mediumCar = new MediumCar();
                ICarBuilder economyCar = new EconomyCar();

                Console.WriteLine("Car Components");
                Console.WriteLine("1. Luxury Cars");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Economy Cars");

                CarBuilderDirector builder = new CarBuilderDirector();
                
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    builder.Constructor(luxuryCar);
                    luxuryCar.GetParts().ShowAllThePartsInCar();
                }
                else if (Console.ReadKey().KeyChar.ToString() == "2")
                {
                    builder.Constructor(mediumCar);
                    mediumCar.GetParts().ShowAllThePartsInCar();
                }
                else if(Console.ReadKey().KeyChar.ToString() == "3") {
                    builder.Constructor(economyCar);
                    mediumCar.GetParts().ShowAllThePartsInCar();
                }
            }
        }
    }
}
