#include <iostream>

using namespace std;

double &sample();
double val = 100.00;

int main()
{
cout<<sample()<<endl;
sample() = 1000;
cout<<sample()<<endl;
	return 0;
}

double &sample()
{
	return val;
}
