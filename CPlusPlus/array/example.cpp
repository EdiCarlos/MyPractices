#include <iostream>

using namespace std;

void setchar(char ch[])
{
		cout<<"Enter some string"<<endl;
	gets(ch);
	
	/*
	for(int i = 0; i < strlen(ch); i++)
	{
		*(ch + i) = (char)'a';
	} */
}
int main()
{
	char ch[] = "hello world";
	char *chp = ch;
   cout<<chp<<endl;
	/*
	
	int number[] = {1, 2, 3,4, 5,6, 7};
	
	cout<<"address of number " << number<<endl;
	cout<<"address of numbar[0] "<<&number[0]<<endl;
	
	int * ptr = number;
	cout<<"value of ptr = "<<*ptr<<endl; */
	return 0;
}