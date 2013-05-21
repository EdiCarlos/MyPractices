#ifndef __argstobase_h
#define __argstobase_h

#include "stdafx.h"

using namespace std;

class baseclass
{
	int basevar;
public: 
	baseclass()
	{
	}
	baseclass(int basevar)
	{
		this->basevar = basevar;
	}
	void showbase()
	{
		cout<<basevar<<endl;
	}
};
class derivedclass : public baseclass
{
	int m, n;
public:
	derivedclass(int m, int n) : baseclass(n)
	{
      this->m = m;
	  this->n = n;
	}
	void showbase()
	{
		cout<<"value of m "<<m<<endl<<"value of n"<<n<<endl;
	}
};

class callargstobase
{
public:
	void callmain()
	{
		     derivedclass d(10, 20);
     d.showbase();
	 baseclass * bs = &d;
	 bs->showbase();

	}
};


#endif
