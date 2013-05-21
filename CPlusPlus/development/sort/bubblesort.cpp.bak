#include <iostream>
#include <cstdlib>

using namespace std;
int main()
{
	int arr[10];
	int a, b, c;
	int size = 10;
	
	for(int i = 0; i < size; i++)
	{
		arr[i] = rand();
	}
	cout<<"orginal array"<<endl;
	
	for(int i = 0; i < sizeof(arr) / sizeof(int); i++)
	{
		cout<<arr[i]<<" ";
	}
	//this bubble sort
	
	for(a = 1; a < size; a++)
	{
		for(b = size - 1; b >= a; b--)
		{
			if(arr[b - 1] > arr[b])
			{
				c = arr[b-1];
				arr[b-1] = arr[b];
				arr[b] = c;
			}
		}
	}
	cout<<"sorted array "<<endl;

for(int i = 0; i < size; i++)
{
	cout<<arr[i]<<" ";
}
	return 0;
}