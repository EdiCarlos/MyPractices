
#include <iostream>

using namespace std;
#include "mycalc.h"
 int gnum;
mycalc::mycalc(int num1, int num2)
{
	number1 = num1;
	number2 = num2;
}
void mycalc::add()
{
	cout<<endl;
	cout<<(number1 + number2);
}
void mycalc::sub()
{
	cout<<endl;
	cout<<(number1 - number2);
}
void mycalc::div()
{
	cout<<endl;
	cout<<(number1 / number2);
}
void mycalc::mul()
{
	cout<<endl;
	cout<<(number1 * number2);
}

int main()
{
mycalc calc(20, 10);
calc.add();
calc.sub();
calc.div();
calc.mul();
cout<<"number1 is "<<calc.getNumber1()<<endl;
cout<<"number2 is "<<calc.getNumber2()<<endl;
calc.setNumber1(30);
calc.setNumber2(50);
cout<<"number1 is "<<calc.getNumber1()<<endl;
cout<<"number2 is "<<calc.getNumber2()<<endl;
gnum = 100;
return 0;	
}