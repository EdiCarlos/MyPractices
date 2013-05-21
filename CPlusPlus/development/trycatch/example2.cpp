#include <iostream>
#include <exception>

using namespace std;
void function(int test )
{
	cout<<"starting function which will throw exception " <<endl;
	if(test)
	{
		throw test;
	}
	else
	{
		cout<<"Function called with the value "<<test<<endl;
	}
}
int main()
{
	cout<<"Start catching exception"<<endl;
	try
	{
		function(0);
		function(1);
		function(2);
		cout<<"if excpetion occurs this will not be executed"<<endl;
	}
	catch(int n)
	{
		cout<<"Value of exception "<<n<<endl;
	}
	return 0;
}