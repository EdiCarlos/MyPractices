/*
 * Defs.h
 *
 *  Created on: Oct 9, 2012
 *      Author: axkhan2
 */
#ifndef HelloWorld
#define HelloWorld
class Calculator
{
public:
	int Addition(int n1, int n2);
};
#endif

#ifndef MySum
#define MySum
int Addition(int num1, int num2);
int Subtraction(int num1, int num2);
#endif

#ifndef endln
#define endln "\n"
#endif

#define testMethod( Productid ) void SomeTest(int &pid){pid = Productid; pid++;}

#define ShowName( name ) \
	virtual char* getName(){return name;}



