#include <iostream>
#include <new>
#include <cstdlib>

using namespace std;

class array
{
	int *p;
	int size;
	public:
	//constructor 0
	array();
	//constructor 1
	array(int size)
	{
		try
		{
		p = new int[size];
	}
	catch(bad_alloc xa)
	{
		cout<<"bad allocation"<<endl;
	
	}
	this->size = size;
	}
	//constructor 2
	array(const array &a)
	{
		int i;
		
		try
		{
			p = new int[a.size];
			
		}
		catch(bad_alloc xa)
		{
			cout<<"bad allocation"<<endl;
		}
		for(int i = 0; i < a.size; i++)
		{
			p[i] = a.p[i];
		}
	}
	void put(int i, int j)
	{
		if(i >= 0 && i <= size) p[i] = j;
	}
	int get(int i)
	{
		return p[i];
	}
};
int main()
{
	array num(10);
	
	for(int i =0; i< 10; i++)
	{
		num.put(i, i);
	}
	for(int i = 0; i < 10; i++)
	{
		cout<<num.get(i)<<" ";
	}
	array x(num);
	cout<<"\n";
		
	for(int i =0; i < 10; i++)
	{
		cout<<x.get(i)<<" ";
	}
	return 0;
}