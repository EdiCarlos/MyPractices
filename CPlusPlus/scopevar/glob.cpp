#include <iostream>

using namespace std;

void fun1();
void fun2();

int count = 0;

int main()
{
for(int i = 1; i <= 10; i++)
{
::count = i * 2;
fun1();
}
}

void fun1()
{
	cout<<::count;
fun2();
}
void fun2()
{
for(int i = 0; i < 3; i++)
cout<<".";
}