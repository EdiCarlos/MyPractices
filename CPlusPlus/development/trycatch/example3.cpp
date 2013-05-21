#include <iostream>
#include <exception>

using namespace std;

void function(int test)
{
	try
	{
		if(test)
		{
			throw test;
		}
		else
		{
			cout<<"function called with test value = "<<test<<endl;
		}
	}
	catch(int i)
	{
		cout<<"caught exception : exception number " <<i<<endl;
	}
}

int main()
{
	cout<<"Starting main function "<<endl;

	function(0);
	function(1); 
	return 0;
}