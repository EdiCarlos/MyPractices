#include <iostream>

using namespace std;

int n = 10;
 
 int main()
 {
 	int n = 1;
 	cout<<"value of local variable is " << n<<" value of global n is " <<::n;
 	return 0;
}