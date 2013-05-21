#include <iostream>

using namespace std;

double &sample(int val);

double arr[] = {1.1, 2.1, 3.1, 4.1, 5.1, 6.1};

int main()
{
	for(int i =0; i < sizeof(arr) /sizeof(double); i++)
	{
		cout<<arr[i]<<" ";
	}
	sample(0) = 1.2;
	sample(1) = 2.3;
	cout<<endl;
	for(int i =0; i < sizeof(arr) /sizeof(double); i++)
	{
		cout<<arr[i]<<" ";
	}
	
	return 0;
}

double &sample(int i)
{
	return arr[i];
}