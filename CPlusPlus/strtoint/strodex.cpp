#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	double d;
	const char * string1 = "51.33 is inserted";
	char * stringptr;
	d = strtod(string1, &stringptr);
	cout<< d<<endl;
	
	return 0;
}