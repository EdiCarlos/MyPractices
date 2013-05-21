#include "stdafx.h"

using namespace std;
class Dummy
{
		float x, y;

public:
};


class CAddition : public Dummy
{
	int x, y;
public: 
	CAddition(int a, int b)
	{
		x = a;
		y = b;
	}
	int result()
	{
		return x + y;
	}
};

class callTypeClass
{
public:
	void calltypeclassfun()
	{
		    Dummy d;
    CAddition * add;
	add = static_cast<CAddition*>(&d);
	cout<<add->result();
	}
};
