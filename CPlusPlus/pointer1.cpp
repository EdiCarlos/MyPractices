#include <iostream>

using namespace std;

void DisplayPointerValue(int * p)
{
cout<<"Displaying pointer value " <<*p;
}
void DisplayAddressOfValue(int & v)
{
cout<<"address of v="<<v;
}

int main()
{
int firstvalue, secondvalue;
int *p1, *p2;
p1 = &firstvalue;
p2 = &secondvalue;
*p1 = 10;
*p2 = 20;
*p1 = *p2;
p1 = p2;
cout<<"First value ="<<firstvalue<<"Second value ="<<secondvalue;
cout<<"address of p1 ="<<p1<<" aaddress of p2 = "<<p2;
*p2 = 100; 
cout<<"First value ="<<firstvalue<<"Second value ="<<secondvalue;
DisplayPointerValue(p1);
DisplayAddressOfValue(firstvalue);
}
