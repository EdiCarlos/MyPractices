#ifndef endln
#define endln "\n"
#endif
#include  <stdio.h>
#include  <string.h>
#include <strings.h>
#include <iostream>



using namespace std;

typedef unsigned int Positive;
typedef string FiveStrings[5];
typedef double (*Addition)(double value1, double value2);
double Add(double x, double y)
{
	double result = x + y;
	return result;
}

int main()
{
FiveStrings countries = {"India", "Pakistan", "UAE", "Bangladesh", "Maharastra"};
Positive pos = 1000;
short temp = -248;
unsigned int height = 1024;
double distance = 390.83;
cout<<temp<<"\n";
cout<<height<<"\n";
cout<<distance<<"\n";
Addition plus;
plus = Add;

for(int i =0; i < 5; i++)
{
cout<<countries[i]<<endln;
}
cout<<"10.05 + 200.10 = " << plus(10.05 , 200.10)<<endln;
return 0;
}
