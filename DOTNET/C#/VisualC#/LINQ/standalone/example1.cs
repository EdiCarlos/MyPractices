using System;
using System.Linq;
using System.Collection;
using System.Collection.Generics;

class exe
{
public static void Main()
{
int [] numbers = new int[]{1, 2, 3, 4, 5,6, 7, 8, 9, 10};
IEnumerable<int> ie = from num in  number where (num % 2) = 0 select num;
foreach(int i in ie)
{
Console.WriteLine(i);
}

}
}