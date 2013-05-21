#include <iostream>
using namespace std;

class Base {
public:
  virtual bool method() { return false; } // Base is polymorphic
};

class Derived1: public Base {
public:
};

class Derived2: public Base {
public:
  bool method() { return true; }
};

class Derived3: public Base {
public:
};

Base *factory()
{
  switch(rand()) {
    case 0: return new Derived3;
    case 1: return new Derived1;
    case 2: return new Derived2;
  }
  return 0;
}

int main()
{
  Base *ptr;
  for(int i=0; i<10; i++) {
    ptr = factory(); // generate an object

    cout << "Object is " << typeid(*ptr).name();
    cout << endl;

    if(typeid(*ptr) == typeid(Derived3))
       cout << " Derived3";
    if(typeid(*ptr) == typeid(Derived1))
       cout << " Derived1";
    if(typeid(*ptr) == typeid(Derived2))
       cout << " Derived2";
  }
  return 0;
}