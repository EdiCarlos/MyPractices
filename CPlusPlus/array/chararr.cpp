#include <iostream>

using namespace std;

int main()
{
	const int days = 7;
	const int max = 10;
	char week[days][max] = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
	
	for(int i = 0; i < days; i++)
	{
		cout<<week[i]<<endl;
	}
	return 0;
}