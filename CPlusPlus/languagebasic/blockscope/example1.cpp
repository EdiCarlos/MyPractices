#include <iostream>

using namespace std;

int main()
{
	int count1 = 10;
	int count3 = 20;
	
	cout<<"value of outer count1 is "<<count1<<endl;
	{
		int count1 = 20;
		int count2 = 30;
		cout<<"value of inner count1 is " <<count1<<endl;
		count1 += 10;
		count3 += count2;
		
	}
	cout<<"Value of outer count1 is "<<count1<<endl;
	cout<<"value of outer count3 is "<<count3<<endl;
	
	return 0;
}