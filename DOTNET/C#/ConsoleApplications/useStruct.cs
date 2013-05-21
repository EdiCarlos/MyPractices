using System;

struct MyStruct
{
private bool car;
private string carName;
private string carModel;
public bool Car
{
get{return this.car;}
set{ this.car = value;}
}
public string CarName
{
get{return this.carName;}
set{this.carName = value;}

}
public string CarModel
{
get{return this.carModel;}
set{this.carModel = value;}
}
}
public class myclass
{
public static void Main()
{
MyStruct st = new MyStruct();
Console.WriteLine("Enter Car name true or false");
st.Car = bool.Parse(Console.ReadLine());

if(st.Car)
{

Console.WriteLine("Enter Car Name");
st.CarName = Console.ReadLine();
Console.WriteLine("Enter Car model");
st.CarModel = Console.ReadLine();
Console.WriteLine("Car name {0} ", st.CarName);
Console.WriteLine("Car Model {0} " , st.CarModel);

}
}
}