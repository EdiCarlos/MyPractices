#include <iostream>

using namespace std;

int main(void)
{
	int num1, num2, iand, ior, ixor;
	num1 = 0;
	num2 = 1;
	cout<<"value of num1 is "<<num1<<endl;
	cout<<"value of num2 is "<<num2<<endl;
	iand = num1 & num2;
	ior = num1 | num2;
	ixor = num1 ^ num2;
	cout<<num1<<" AND "<<num2<<" = "<<iand<<endl;
	cout<<num1<<" OR "<<num2<<" = "<<ior<<endl;
	 
	cout<<num1<<" XOR "<<num2<<" = "<<ixor<<endl;
	 
	return 0;
}