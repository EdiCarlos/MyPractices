#include <iostream>

using namespace std;

class base
{
	protected:
	int i;
	public:
	base(int x)
{
	i =x ;
	cout<<"base class constructor called"<<endl;
}
	~base()
	{
		cout<<"base class destructor called"<<endl;
	}	
};
class derived : public base
{
		int j;

	public:
	derived(int x, int y):base(y)
	{
		j = x;
		cout<<"derived class constructor called"<<endl;
	}
	~derived()
	{
		cout<<"derived class constructor called"<<endl;
	}
	void show()
	{
		printf("value of x = %d and y = %d \n", i, j);
	}
};

int main()
{
	derived d(10, 20);
	d.show();
	return 0;
}