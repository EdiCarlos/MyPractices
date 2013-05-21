#include <iostream>

using namespace std;

int main()
{
	int arr[3] = {1, 3, 5};
	int *ar = arr;
	for(int i = 0 ;i < sizeof(arr) /sizeof(int); i++)
	{
		cout<<ar[i]<<endl;
	}
	return 0;
}