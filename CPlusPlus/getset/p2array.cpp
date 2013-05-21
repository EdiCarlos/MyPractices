#include <iostream>

using namespace std;
const double  PI = 3.14159;

double Diameter(double R)
{
	return (R * 2);
	}
	double Circumference(double R)
	{
		return Diameter(R) * PI;
	}
	double Area(double R)
	{
		return R * R * PI;
		}

int main()
{
typedef double (*members)(double R);

members calc[] = {Diameter, Circumference, Area};

cout<<"Diameter of circle"<<endl;
cout<<calc[0](2)<<endl;
cout<<"Circumference of circle"<<endl;
cout<<calc[1](2)<<endl;
cout<<"Area of circle"<<endl;
cout<<calc[2](2)<<endl;
}