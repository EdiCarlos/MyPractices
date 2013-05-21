#include <iostream>

using namespace std;

void foo(int i, int j = 30)
{
cout<<i + j<<endl;
}
int main()
{
foo(20, 20);
}