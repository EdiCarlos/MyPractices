#include "stdafx.h"

using namespace std;

class MyClass
{
	int data;
public:
	MyClass()
	{
	}
	MyClass(int data)
	{
		this->data = data;
	}
	MyClass(MyClass &cl)
	{
		data = cl.data;
		cout<<"Copy constructor Invoked \n";
	}
	void display()
	{
		cout<<data<<endl;
	}
	bool operator = (MyClass & cl)
	{
			cout<<"Assignment operator Invoked \n";
	
		return data == cl.data ? true : false;
	}
	int getData()
	{
		return data;
	}
};

class callofMyClass
{
public:
	void RunCopyConst()
	{
		MyClass c1(10);
		MyClass c2;
		cout<<"value of c1.data = "<<c1.getData()<<endl;
		cout<<"value of c2.data = "<<c2.getData()<<endl;

		c2 = c1;
		cout<<"value of c1.data = "<<c1.getData()<<endl;
		cout<<"value of c2.data = "<<c2.getData()<<endl;

		MyClass c3(c1);

		cout<<"value of c1.data = "<<c1.getData()<<endl;
		cout<<"value of c2.data = "<<c2.getData()<<endl;
		cout<<"value of c3.data = "<<c3.getData()<<endl;

	}
}