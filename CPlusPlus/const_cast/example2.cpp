#include <iostream>

using namespace std;

void conchar(const char* c)
{
	char * a;
	a = const_cast<char *>(c);
	*a = static_cast<char>('k') ;
}
int main()
{
	char * a = "L";
	cout<<"value of a before calling function"<<a<<endl;
	conchar(a);
	cout<<"value of a after calling function"<<a<<endl;
	return 0;
}