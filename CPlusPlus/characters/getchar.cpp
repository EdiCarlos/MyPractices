#include <iostream>

using namespace std;

char *getName()
{
	char *flname = new char[20];
	cout<<"Enter your full name"<<endl;
	gets(flname);
	return flname;
}
int main()
{
cout<<strlen(getName());
}