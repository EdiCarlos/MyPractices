#include <iostream>

using namespace std;
inline unsigned long Square(unsigned long a) { return a*a; }
inline unsigned long Cube(unsigned long b) {return b * b * b;}
int main()
{
	cout<<Square(10)<<endl;
	cout<<Cube(3)<<endl;
	return 0;
}