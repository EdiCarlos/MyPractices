#include <iostream>

using namespace std;
int main()
{
	int arr[10];
	firstloop:
	for(int i = 0; i < sizeof(arr) /sizeof(int); i++)
	{
		arr[i] = rand();
	}
	secondloop:
	for(int j = 0; j < sizeof(arr) /sizeof(int); j++)
	{
		cout<<arr[j]<<endl;
	}
	return 0;
}