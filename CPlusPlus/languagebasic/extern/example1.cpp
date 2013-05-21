#include <iostream>

using namespace std;

extern "C" void mycfunc();

int main()
{
	mycfunc();
	return 0;
}
void mycfunc()
{
	cout<<"This is c function"<<endl;
}