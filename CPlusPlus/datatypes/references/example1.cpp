#include <iostream>

using namespace std;

int main()
{
	int x = 10;
	int &y = x;
	cout<<"value x is "<<x<<endl;
	cout<<"value of y " <<y<<endl;
	y = 100;
	cout<<"value x is "<<x<<endl;
	cout<<"value of y " <<y<<endl;
 
	return 0;
}