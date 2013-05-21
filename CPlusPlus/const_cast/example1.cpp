#include <iostream>

using namespace std;
void sqrval(const int *val)
{
	int * p;
	p = const_cast<int *>(val);
	*p = *val * *val;
	
}
void sqrval1(const int* val)
{
	int* ptr;
	ptr = const_cast<int *>(val);
	*ptr = 1000;
}
int main()
{
	int x = 10;
	int *ptr = &x;
  cout<<"value fo x before calling sqrval "<<x<<endl;
    sqrval1(ptr);
  cout<<"value fo x after calling sqrval "<<x<<endl;
  
/*
	cout<<"value of x before calling sqrval "<<x<<endl;
	sqrval(ptr);
	cout<<"value of x after calling sqrval "<<x<<endl;
*/	
	return 0;
}