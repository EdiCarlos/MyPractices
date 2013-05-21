#include <iostream>

using namespace std;

int main()
{
	char str[64];
	time_t t = time(NULL);
	strftime(str, 64, "%A %B", localtime(&t));
	cout<<str;
	
	return 0;
	
}