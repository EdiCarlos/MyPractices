#include <iostream>

using namespace std;

class myclass
{
	
	mutable int i;
	int j;
	public:
	int geti()const
	{
		return i;
	}
	void seti(int x) const
	{
		i = x;
	}
	void set(int x)
	{
		i = x;
	}
	int get()
	{
		return i;
	}
};

int main()
{
	myclass obj;
	obj.seti(100);
	cout<<obj.geti()<<endl;
	obj.set(1000);
	cout<<obj.get()<<endl;
	return 0;
}