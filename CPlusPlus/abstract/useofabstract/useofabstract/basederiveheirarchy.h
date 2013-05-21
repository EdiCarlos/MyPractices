#include "stdafx.h"

class Base
{
};
//class Derived : public Base
//{
//public:
//	Derived();
//	virtual ~Derived();
//};

class myDerived :public Base
{
};

class callbasederive
{
public:
	void useofcallderive()
	{
		    Base *b;
	myDerived *d;
	//d = new myDerived();
	b = d;
	d = static_cast<myDerived*>(b);
    Base base;
	myDerived derive;

	Base &bs = base;
	myDerived &dv = static_cast<myDerived&>(base);
    int i = 3;
	double j = static_cast<double>(i);

	}

};
