#include <iostream>

using namespace std;

int main()
{
char fname[20];
char MI;
char lname[20];
cout<<"Enter you firstname "<<endl;
cin.getline(fname, 20);

cout<<"Enter your last name"<<endl;
cin.getline(lname, 20);

cout<<"Enter initial "<<endl;
cin>>MI;
cout<<"your full name is "<<fname<<" "<<MI<<" "<<lname;


}