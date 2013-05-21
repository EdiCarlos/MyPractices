#include <iostream>

using namespace std;
int main()
{
	int num1, div;
	cout<<"Enter number \n";
	cin>>num1;
	cout<<"Enter number to divide by \n";
	cin>>div;
	if(div)
	{
		cout<<"num1 / div = " << num1 /div<<endl;
	}
	else
	{
		cout<<"cannot divide by zero\n";
	}
	return 0;
}