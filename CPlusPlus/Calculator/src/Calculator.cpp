//============================================================================
// Name        : Calculator.cpp
// Author      : Arif Khan
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================

#include <iostream>
#include "Headers\Calculator.h"
#include "Headers\Person.h"
#include <string.h>
#include <stdio.h>
using namespace std;

double Calculator::Addition(double n1, double n2)
{
	return n1 + n2;
}

double Calculator::Subtraction(double n1, double n2)
{
	return n1 - n2;
}
double *& Calculator::ShowResult(){

	double nresult = 100;
	static double *ret = &nresult;
	return ret;
}

//double *& showNumber()
//{
//	double n = 100;
//	static double *v = &n;
//	return v;
//}

int main() {
//Calculator c1;
//cout<<c1.Addition(100, 100)<<endl;
//cout<<c1.Subtraction(200, 100)<<endl;
//cout<<calc.Addition(100, 100);
	Employee emp(100, "Aarif", "Khan", 25);
	emp.ShowNameAndSalary();
	cout<<emp.ShowFullName();
}
