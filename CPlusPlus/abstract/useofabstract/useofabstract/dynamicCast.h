#include "stdafx.h"

using namespace std;


class Base
{
public:
	virtual void f()
	{
		cout<<"Inside base class \n";
	}

};

class Derived : public Base
{
public:
  virtual void f()
  {
	  cout<<"Inside derived class \n";
  }
};

class callofdynamicCast
{
public:
	void callof()
	{
		    Base *bs, ob_bs;
	Derived *dv, ob_dv;

	dv = dynamic_cast<Derived*>(&ob_dv);
	if(dv)
	{
		cout<<"Cast From Derived *  to Derived *  \n";
		dv->f();
	}
	else
	{
		cout<<"Error \n";
	}
	dv = dynamic_cast<Derived *>(&ob_bs);
	if(dv)
	{

		cout<<"Cast from Derived * to Base *\n";
		dv->f();
 	}
	else
	{
			cout<<"Error \n";
	}
    /*bs = dynamic_cast<Derived*>(&ob_bs);
	if(bs)
	{
		cout<<"cast from Base * to Derived * \n"<<endl;
		bs->f();
	}
	else
	{
	   cout<<"Error \n";
	}
	bs = dynamic_cast<*/

	}
};