#ifndef mycalcH
#define mycalcH
#include <iostream>
using namespace std;
class mycalc
{
	private:
	int number1, number2;
	public:
	mycalc();
	mycalc(int num1, int num2);
	void add();
	void sub();
	void mul();
	void div();
  int getNumber1()const {return number1;}
  void setNumber1(int num1){number1 = num1;}
  int getNumber2()const{return number2;}
  void setNumber2(int num1){number2 = num1;}
  
};
#endif

