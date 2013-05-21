#ifndef __useOfOperator_h
#define __useOfOperator_h
#endif

#include "stdafx.h"

using namespace std;

class myCalc
{
	int num1, num2;
public:
       myCalc(int num1, int num2)
	   {
		   this->num1 = num1;
		   this->num2 = num2;
	   }

	   bool operator == (myCalc &c1)
	   {
		   if(num1 == c1.num1 && num2 == c1.num2)
		   {
			   return true;
		   }
		   return false;
	   }

};