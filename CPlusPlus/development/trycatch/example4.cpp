#include <iostream>

using namespace std;

void function(int test)
{
	cout<<"Starting function "<<endl;
	try
	{
	if(test == 0){throw test;}
	if(test == 1){ throw 'a';}
	if(test == 2){ throw "exception";}
}
catch(...)
{
	cout<<"caught one exception "<<endl;
}
}
int main()
{
	cout<<"inside main function "<<endl;
	function(0);
	function(1);
	function(2);
	return 0;
}