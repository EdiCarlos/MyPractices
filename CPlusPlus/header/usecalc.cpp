#define endln "\n"
#include <iostream>
#include <conio.h>
#include "calc.h"

using namespace std;

int main()
{
	int num1, num2;
	cout<<"Enter number 1"<<endln;
cin>>num1;
cout<<"Enter number 2"<<endln;
cin>>num2;
	
	cout<<"Addition of num1 and num2"<<endln;
	cout<<Addition(num1, num2);
  
}