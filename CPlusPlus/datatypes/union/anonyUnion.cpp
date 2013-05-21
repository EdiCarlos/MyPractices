#include <iostream>
#include <cstdlib>
#include <cstring>

using namespace std;

int main()
{
   union
   {
   	long l;
   	double d;
   	char s[4];
  };	
  l  = 1000000;
  cout<<"value of l in anonymous union  "<<l<<endl;
  cout<<"value of d in anonymous union  "<<d<<endl;
  cout<<"value of s in anonymous union  "<<s<<endl;

  d = 123.1243;
  cout<<"value of l in anonymous union  "<<l<<endl;

  cout<<"value of d in anonymous union  "<<d<<endl;
  cout<<"value of s in anonymous union  "<<s<<endl;

  strcpy(s, "hi");
  cout<<"value of l in anonymous union  "<<l<<endl;
  cout<<"value of d in anonymous union  "<<d<<endl;

  cout<<"value of s in anonymous union  "<<s<<endl;
  
	return 0;
}