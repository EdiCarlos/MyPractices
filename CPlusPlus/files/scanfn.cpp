#include <iostream>
#include <cstdio>

using namespace std;

void showchar(const char * name, ...)
{
	cout<<name<<endl;
	
}
void setint(int *i)
{
	*i = 100;
}
void setint(int &i)
{
	i = 1000;
}
int main()
{
	
	char  name[80];
	int i = 20;
	/*puts("Enter your name here");
	scanf("%s", &name);
  puts("Enter your age here");
  scanf("%d", &i);
  printf("you name is %s and your age is %d", name, i);
  printf("Enter hexadecimal number"); */
  cout<<"value of int before setint "<<i<<endl;
  
  setint(&i);
  cout<<"value of int after setint "<<i<<endl;

  setint(i);
  cout<<"value of int after setint "<<i<<endl;

  	//showchar("hello world", 10, 20);
  	
return 0;
}