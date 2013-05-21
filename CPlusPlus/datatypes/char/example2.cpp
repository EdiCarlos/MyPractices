#include <iostream>

using namespace std;

int main()
{
	char c;
	cout<<"value of c = "<<c<<endl;
	cout<<"Enter the value of c "<<endl;
	cin>>c;
	
	char choice = 'y';
	
	do
{	
	if(c >= 'A')
	{
		if(c <= 'Z')
		{
			cout<<"is upper"<<endl;
		}
	}
	if(c >= 'a')
	{
		if(c <= 'z')
		{
			cout<<"is lower"<<endl;
		}
	}
	cout<<"do you want to continue press n to exit or press cntrl+c"<<endl;
	cin>>choice;
	if(choice == 'n')
	{
		break;
	}
	cout<<"Enter the value of c "<<endl;
	cin>>c;
	
}while(choice != 'n');
	return 0;
}