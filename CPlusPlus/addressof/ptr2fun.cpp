#include <iostream>

using namespace std;

int main()
{
int * getValue();
int * val;
val = getValue();

cout<<"getValue returned  "<<*val<<endl;
cout<<"address of value is "<<&val<<endl;
*val = 1000;
cout<<"getValue returned  "<<*val<<endl;

return 0;

}
int *getValue()
{
	
	int *ptr = new int(2000);
  cout<<"addres ptr is "<<&ptr<<endl;
  return ptr;
}