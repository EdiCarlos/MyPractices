#include <iostream>

using namespace std;

int main()
{
	int arr[] = {1, 2, 3,4,5, 6};
	int i = 2;
	int &x = arr[i];
	cout<<"value of x is "<<x<<endl;
	cout<<"value of arr[i] is "<<arr[i]<<endl;
	x = 100;
	
	cout<<"value of x is "<<x<<endl;
	cout<<"value of arr[i] is "<<arr[i]<<endl;
	
	return 0;
}