#include <iostream>

using namespace std;

void showvalue(int &value)
{
	value = value + value;
	
	cout<<value;
	
}
int main()
{
	int val;
	int &val1 = val;
	int &val2 = val1, &val3 = val2;
cout<<val1<<endl;
	cout<<val2<<endl;
	cout<<val3<<endl;
	cout<<val<<endl;
	
	val3 = 100;

	cout<<val1<<endl;
	cout<<val2<<endl;
	cout<<val3<<endl;
	cout<<val<<endl;
	
cout<<"showing value using reference"<<endl;
showvalue(val);
	cout<<val1<<endl;
	cout<<val2<<endl;
	cout<<val3<<endl;
	cout<<val<<endl;


	return 0;
}