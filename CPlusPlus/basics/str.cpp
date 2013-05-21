#include <iostream>
#include <cstring>

using namespace std;

int main()
{
	char ch[80], ch1[80];
	//ch1 = "hello world";
	strcpy(ch, "hello world");
	strcpy(ch1, "hello worldd");
	cout<<ch<<endl;
if(strcmp(ch, ch1))
{
	cout<<"is not equal"<<endl;
}
else
{
	cout<<"is equal"<<endl;
	}
	strcpy(ch1, ch);
if(strcmp(ch, ch1))
{
	cout<<"is not equal"<<endl;
}
else
{
	cout<<"is equal"<<endl;
}
cout<<ch<<endl;
cout<<ch1<<endl;

	return 0;
}