#include <iostream>

using namespace std;

int main()
{
try
{
	throw "out of range";
}
catch(char * ch)
{
	cout<<"Exception message : " <<ch<<endl;
}
	return 0;
}