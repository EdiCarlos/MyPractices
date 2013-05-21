#include <iostream>

using namespace std;

double &sample();
double sample1();

double val = 100.00;

int main()
{
	double &x = sample();
	cout<<x<<endl;
	x = 200;
	cout<<x<<endl;
	cout<<sample()<<endl;
	cout<<"address of val "<<&val<<endl;
	cout<<"address of x "<<&x<<endl;
	
	return 0;
}

double &sample()
{
	return val;
}
double sample1()
{
	return 100;
}