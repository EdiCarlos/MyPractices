using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParameterizedThreading
{
    public delegate void mydel(int i);
    class ArrForEachClass
    {
        public event mydel meve;   
        public ArrForEachClass()
        {

        }
        public void RunForEach()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Action<int> act = new Action<int>(this.ShowMultiple);
            Array.ForEach(i, act);
            
        }
        public void ShowMultiple(int j)
        {
           Console.WriteLine(" i " + j + " i + i = " + (j + j));
           meve(j);
        }
        
    }
    class usemeve
    {
        public static void ShowMyEve()
        {
            ArrForEachClass fr = new ArrForEachClass();
            fr.meve += new mydel(fr_meve);
            fr.RunForEach();

        }

        static void fr_meve(int i)
        {
            Console.WriteLine(i);
        }
    }
}
