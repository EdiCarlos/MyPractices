#include <iostream>
  typedef int Length;

using namespace std;

void modifyarr(int  arr[], int ln)
{
	for(int i = 0; i < ln; i++)
	{
		cout<<"arr[ "<<i<<"] = 200"<<endl;
		arr[i] = 200;
	}
}
void modifyele(int arr[])
{
	for(int i = 0; i< 2; i++)
	{
		*(arr + i) = 1000;
	} 
}

int main()
{
	
	int arr[] = {0, 1, 2, 3, 4};
	for(int i = 0; i < sizeof(arr)/sizeof(int); i++)
	{
		cout<<arr[i]<<endl;
	}
	
  Length ln = sizeof(arr) / sizeof(int);
  
  modifyarr(arr, ln);
  
	for(int i = 0; i < ln; i++)
	{
		cout<<arr[i]<<endl;
	}
	modifyele(arr);
	for(int i = 0; i < ln; i++)
	{
		cout<<"arr["<<i<<"] = "
		<<arr[i]<<endl;
	}
	
}

