#include <iostream>

using namespace std;
void changeNumber(int * num1);

int main()
{
int i = 10;
cout<<i<<endl;
changeNumber(&i);
cout<<i<<endl;
}

void changeNumber(int * num1)
{
	*num1 = *num1 +  100;
}