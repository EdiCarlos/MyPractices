#include <iostream>

using namespace std;

int main()
{
int number = 10;
int value = 20;
int *nbr = &number;
int **ptr = &nbr;
cout<<"address of number is " <<&number<<endl;
cout<<"address of nbr is " << &nbr<<endl;
cout<<"value at the address of number is " <<number<<endl;
cout<<"value at the address of nbr is " <<*nbr<<endl;
cout<<"valud at the address of ptr is " <<**ptr<<endl;
**ptr = 300;
cout<<"value at the address of number is " <<number<<endl;
cout<<"value at the address of nbr is " <<*nbr<<endl;
cout<<"valud at the address of ptr is " <<**ptr<<endl;

}