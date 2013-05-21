#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	try
	{
	char * mystring;
	mystring = new char[10];
	
	
	if(mystring == NULL)
	{
		throw "NUll pointer exception object cannot have null value";
	}
	for(int i = 0; i <= 100; i++)
	{
		if(i >9)
	{
		throw i;
	}
	mystring[i] =  'a';
	}
	
}
catch(int i)
{
cout<<"Index " <<i<<" Out of range"<<endl;
}
catch(char * str)
{
	cout<<"exception : " <<str<<endl;
}
	return 0;
}