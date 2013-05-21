#include <iostream>
#include <cctype>

using namespace std;
int main()
{
	int arr[10];
	int count = 0;
	char reply;
	do
	{
		cout<<"Enter the number"<<endl;
		cin>>arr[count++];
		cout<<"do you want to continue"<<endl;
		cin>>reply;
	}while(count < 10 & tolower(reply) != 'n');
	
	for(int i = 0; i < sizeof(arr) / sizeof(int); i++)
	{
		cout<<arr[i]<<endl;
	}
	return 0;
}