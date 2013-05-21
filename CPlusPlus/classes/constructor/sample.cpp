#include <iostream>

using namespace std;

int main()
{
	try
	{
	int i[] = {1, 2, 3, 4, 5 };
	
	for(int k = 0; k < sizeof(i) /sizeof(int); k++)
	{
		cout<<(*i + k)<<endl;
	
	}
	for(int j = 0; j < sizeof(i) / sizeof(int); j++)
	{
		cout<<&i[j]<<endl;
	}
	cout<<sizeof(i) / sizeof(int)<<endl;
	}
	
	catch(bad_alloc xa)
	{
		cout<<"allocation failure"<<endl;
	}
	return 0;
}