#include <iostream>
#include <exception>

using namespace std;

int main()
{
  cout<<"starting try block "<<endl;
  try
  {
  	cout<<"inside try block"<<endl;
  	throw 0;
  	cout<<"this will not execute"<<endl;
  }
  catch(int i )
  {
  	cout<<"Exception caught exception number "<<i<<endl;
  }
  cout<<"end"<<endl;
	return 0;
}