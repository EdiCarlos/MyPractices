/*
 * Defined.cpp
 *
 *  Created on: Oct 9, 2012
 *      Author: axkhan2
 */
#include <iostream>;
#include "Defs.h";

using namespace std;

class Test{
public:
	int test = 200;
public:
	testMethod(test);
	ShowName("Arif Khan");
	void UsePointerAndAddressOf(int* p1);
};

void Test::UsePointerAndAddressOf(int* p1)
{
	int add = 100;
	cout<<add + *p1<<endl;
}
int main()
{
	int p = 100;
	Test test;
    test.SomeTest(p);
    cout<<p<<endln;
    cout<<Addition(100, 100)<<endln;
	Calculator m;
    cout<<m.Addition(100, 100)<<endln;
    cout<<test.getName()<<endln;
    int &pd = p;
    int* pt = new int();
    *pt = 1000;
    int* pt1 = pt;
    cout<<*pt1<<endl;
    cout<<*pt<<endl;
    cout<<pt<<endl;
    cout<<&pd<<endl;
    cout<<pd<<endl;
    test.UsePointerAndAddressOf(&pd);
	return 0;
}

