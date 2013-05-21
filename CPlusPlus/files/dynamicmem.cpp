#include <iostream>

using namespace std;

void func(int * p)
{
	*p = 100;
}
void func(char &ch[])
{
	ch = static_cast<char>"hello india";
}

int main()
{
	int * i;
	i = new int;
	char ch[30];
	printf("%s", "Enter some message for compiler");
  gets(ch);
	cout<<*i<<endl;
	func(i);
  cout<<ch<<endl;
	func(ch);
	cout<<*i;
  cout<<ch<<endl;

	return 0;	
}
