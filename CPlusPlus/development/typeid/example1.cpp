#include <iostream>

using namespace std;
class myclass
{
	public:
	myclass(){cout<<"myclass constructor called"<<endl;}
};

int main()
{
	int i, f;

	myclass cl;
	cout<<"typeid for int "<<typeid(i).name()<<endl;
	cout<<"typeid for int "<<typeid(f).name()<<endl;
	cout<<"typeid for myclass "<<typeid(cl).name()<<endl;
	if(typeid(i) == typeid(f))
	{
		cout<<"typeid is same"<<endl;
	}
	if(typeid(i) == typeid(cl))
	{
		cout<<"typeid are not same"<<endl;
	}
	else
	{
		cout<<"typeid is not same"<<endl;
	}
	return 0;
	
}