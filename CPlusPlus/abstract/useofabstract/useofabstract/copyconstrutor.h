#include "stdafx.h"
#include <cstring>
using namespace std;

class StringClass
{
	char *p;
public:
	StringClass(char * s);
	StringClass(const StringClass &o);
	~StringClass()
	{
		delete [] p;
	}
	char * get()
	{
		return p;
	}
	void Show(StringClass x)
	{
		char *s;
		s = x.get();
		cout<<s<<endl;
	}
};

StringClass::StringClass(char * s)
{
	int i;
	i = strlen(s) +1;
	p = new char[i];
	if(!p)
	{
		cout<<"Allocation Error \n";
		exit(1);
	}
	strcpy(p, s);
}
StringClass::StringClass(const StringClass &o)
{
	int i;
	i = strlen(o.p) +1;
	p = new char[i];
	if(!o.p)
	{
		cout<<"Allocation Error \n";
		exit(1);
	}
	strcpy(p,o.p); 
}
