#include <iostream>

using namespace std;

int main()
{
	int arr [] = {10, 2, 3, 4};
	int *ptr = arr;
	int size = sizeof(arr) / sizeof(int);
	
	for(int i = 0; i < size; i++)
	{
		cout<<*(arr + i)<<endl;
	} 
	for(int i = 0 ;i < size; i++)
	{
		cout<<arr[i]<<endl;
	}
	for(int i = 0 ;i < size; i++)
	{
		cout<<*(ptr + i)<<endl;
	}
	return 0;
}