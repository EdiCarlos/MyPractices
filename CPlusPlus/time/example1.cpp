#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	time_t currenttime;
	time(&currenttime);
	cout<<asctime(localtime(&currenttime));
	return 0;
}