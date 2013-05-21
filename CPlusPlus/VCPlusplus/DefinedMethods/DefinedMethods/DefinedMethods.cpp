// DefinedMethods.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Defs.h"

using namespace std;

extern const int ID;

class SomeClass
{
	int test;
public:
	SomeMethod();
	OBJECT_PID_NONE(1000);
	ShowName("Arif Khan");
};

int _tmain(int argc, _TCHAR* argv[])
{
	SomeClass cl;
	int p = 100;
	cout<<cl.GetProductId()<<endln;
	cout<<cl.GetObjectPID(p)<<endln;
	cout<<p<<endln;
	cout<<cl.getName()<<endln;
	return 0;
}

