#include <iostream>
#include <stdlib.h>

using namespace std;

int compare(const void * first_arg, const void * second_arg)
{
	int first = *(int*)first_arg;
	int second = *(int*) second_arg;
	
	if(first < second)
	{
		return -1;
	}
	else if(first == second)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}

int main()
{
	int arr[10];
	
	for(int i = 0; i < sizeof(arr) / sizeof(int); i++)
	{
		arr[i] = 10 - i;
	cout<<arr[i]<<endl;
	}
	cout<<"sorting value "<<endl;
	qsort(arr, 10, sizeof(int), compare);
	cout<<"sorted value "<<endl;
	for(int i = 0; i < sizeof(arr) / sizeof(int); i++)
	{
//		arr[i] = 10 - i;
	cout<<arr[i]<<endl;
	}

	return 0;
}