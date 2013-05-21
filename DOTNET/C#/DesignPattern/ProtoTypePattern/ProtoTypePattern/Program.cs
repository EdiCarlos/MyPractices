using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProtoTypePattern
{
    [Serializable]
    public abstract class IPrototype<T>
    {
        public T Clone()
        {
            return (T) this.MemberwiseClone();
        }

        public T DeepCopy()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            T copy = (T)binaryFormatter.Deserialize(ms);
            ms.Close();
            return copy;
        }
    }

    [Serializable]
    class DeeperData
    {
        public string Data { get; set; }
        public DeeperData(string data)
        {
            this.Data = data;
        }
        public override string ToString()
        {
            return Data;
        }
    }
    
    [Serializable]
    class Prototype : IPrototype<Prototype>
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public DeeperData Language { get; set; }
        public Prototype(string country, string capital, string language)
        {
            this.Country = country;
            this.Capital = capital;
            Language = new DeeperData(language);
        }
        public override string ToString()
        {
            return Country + "\t\t" + Capital + "\t\t->" + Language;
        }

    }

    [Serializable]
    class PrototypeManager : IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes = new Dictionary<string, Prototype> { {"Germany", new Prototype("Germany", "Berlin", "German")},
        {"Italy", new Prototype("India", "Delhi", "Hindi")},
        {"Pakistan", new Prototype("Pakistan", "Islamabad", "Urdu")}};
    }

    class PrototypeClient : IPrototype<Prototype>
    {
        static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n"+s);
            Console.WriteLine("Prototype "+a+"\nClone"+b);
        }
        public static void Run()
        {
            PrototypeManager prototypeManager = new PrototypeManager();
            Prototype c2, c3;
            c2 = prototypeManager.prototypes["Germany"].Clone();
            Report("Shallow clonging Germany \n=============", prototypeManager.prototypes["Germany"], c2);

            c2.Capital = "Bejing";
            Report("Altered clone stated \n=============", prototypeManager.prototypes["Germany"], c2);
            
            c2.Language.Data = "Chinese" ;

            Report("Alter clone deep prototype affected \n=============", prototypeManager.prototypes["Germany"], c2);

            c3 = prototypeManager.prototypes["Pakistan"].DeepCopy();

            Report("Deep clonin Pakistan \n=============", prototypeManager.prototypes["Pakistan"], c3);

            c3.Capital = "Lahore";

            Report("Alter Shallow cloning state affected \n=============", prototypeManager.prototypes["Pakistan"], c3);

            c3.Language.Data = "Hindi";

            Report("Alter deep cloning state, prototype unaffected \n=============", prototypeManager.prototypes["Pakistan"], c3);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrototypeClient.Run();

        }
    }
}
