#include <iostream>

using std::cout;
using std::endl;

class myclass
{
	public:
	myclass(int v)
	{
		value = v;
	}
	int getvalue()
	{
		return value;
	}
	private:
	mutable int value;
};

int main()
{
	 myclass cl(10);
	cout<<cl.getvalue()<<endl;
	return 0;
}