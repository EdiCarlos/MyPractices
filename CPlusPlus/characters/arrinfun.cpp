#include <iostream>
using namespace std;

void showFname(const char fname[])
{
cout<<"your full name is "<<endl<<fname;
}

void showPtr(const char *fname)
{
	cout<<"your full name is"<<endl<<fname;
}
int main()
{
const char name[] = "arif khan hasan";
showFname(name);
const char *fname = "arif khan hasan";
showPtr(fname);
}