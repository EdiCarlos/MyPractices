#include <iostream>
#include <ostream>
#include <typeinfo>

using namespace std;

class Base
{
	public:
	virtual ~Base(){}
};

class derived : public Base
{
};

int main()
{
	Base* b;
	derived d1;
	b = &d1;
cout<<typeid(*b).name()<<endl;
cout<<typeid(Base).name()<<endl;
derived *d1 = new derived;

cout<<typeid(*d1).name()<<endl;
cout<<typeid(derived).name()<<endl; 
	return 0;
}