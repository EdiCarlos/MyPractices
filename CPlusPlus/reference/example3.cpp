#include <iostream>

using namespace std;
double &f();
double val = 100.00;

int main()
{
	double &x = f();
	cout<<x<<endl;
	x = 1000;
	
	return 0;
}

double &f()
{
	return val;
}