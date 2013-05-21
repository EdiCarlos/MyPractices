#define endln "\n";
#include <iostream>

using namespace std;
 int &getPages()
 {
 	int pages = 1000;
 	int &pg = pages;
 	return pg;
}
 int main(int argc, char* argv[])
{
	int number = 100;
	cout<<getPages();
}