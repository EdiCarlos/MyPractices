#include <iostream>

using namespace std;

class power
{
	public:
	power(){x = 0; cout<<"no initilizer"<<endl;}
	int x;
	
};
int main()
{
	
	try
	{
	 power 	p[10];
	 
	 for(int i =0; i < 10; ++i)
	 {
	 	p[i].x = 10 - i;
	 	
	} 
	for(int k = 0; k < 10; k++)
	{
		cout<<p[k].x<<endl;
	}
	}
	catch(bad_alloc xa)
	{
		cout<<" Allocation failure"<<endl;
	return 1;
	}
	return 0;
}