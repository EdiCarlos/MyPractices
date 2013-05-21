#include <iostream>

using namespace std;

int main()
{
	char fn[] = "hello world";
	char ln[] = "world";
	strncpy(fn, ln, 4);
	cout<<fn<<endl;
	return 0;
}