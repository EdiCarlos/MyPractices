/*
 * Pointer.cpp
 *
 *  Created on: Oct 9, 2012
 *      Author: axkhan2
 */
#define endln "\n"

#include <iostream>;

using namespace std;

class ShowStatic
{
public:
  static void HelloString();
};

void ShowStatic::HelloString()
{
cout<<"hello static string";
}
int Sum(int &num1, int &num2) {
return num1 + num2;
}

int main() {
	int num1 = 10;
	int num2 = 20;
	int *ptnum1 = &num1;
	int **ptpt = &ptnum1;
	cout << ptnum1 << endl;
	cout << &ptnum1 << endl;
	cout << *ptnum1 << endl;
	cout<<Sum(num1, num2)<<endl;
	cout<<*ptpt<<endl;
	cout<<**ptpt<<endl;
     ShowStatic::HelloString();
	return 0;
}

