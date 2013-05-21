#include <iostream>

using namespace std;
class myclass
{
	public:
	void Myfunction()
	{
		cout<<"this is my function"<<endl;
	}
	int getValue()
	{
		return value;
	}	
		int value;
};
void sample()
{
	cout<<"this is sample fucntion";
}
void f(myclass* cl);
void f2(myclass* cl);
int f3(myclass* cl);
int main()
{
	typedef void(myclass::*showfunction)();

  	myclass function;
  	function.value = 8;
  	f(&function);
  	f2(&function);
	  cout<< f3(&function);
   
    return 0;
}

int f3(myclass* cl)
{
	int(myclass::*getv)() = &myclass::getValue;
	return (cl->*getv)();
}
void f(myclass* cl)
{
	void(myclass::*fun)() = &myclass::Myfunction;
	(cl->*fun)();
}
void f2(myclass* cl)
{
	int(myclass::*intPtr) = &myclass::value;
	cout<<cl->*intPtr<<endl;
	}