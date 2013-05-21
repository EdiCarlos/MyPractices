#include <iostream>

using namespace std;

union Number
{
	int num1;
	int num2;
};

int main()
{
	Number n;
	n.num1 = 100;
	cout<<"value of num1 in Number Union = "<<n.num1<<endl;
	n.num2 = 200;
	cout<<"value of num1 in Number Union = "<<n.num1<<endl;
	
	cout<<"value of num2 in Number Union = "<<n.num2<<endl;
	
	return 0;
}