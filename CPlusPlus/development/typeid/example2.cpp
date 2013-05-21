#include <iostream>

using namespace std;

class Base
{
};
class Derived1 : public Base
{
};
class Derived2 : public Base
{
};

int main()
{
	Base * p, b1;
	Derived1 d1;
	Derived2 d2;
	p = &b1;
	cout<<typeid(*p).name()<<endl;
	cout<<typeid(b1).name()<<endl;
	if(typeid(*p) == typeid(b1))
	{
		cout<<"same id"<<endl;
	}
   p = &d1;
   cout<<typeid(*p).name()<<endl;
   p = &d2;
   cout<<typeid(*p).name()<<endl;
   
	return 0;
}