#ifndef endln
typedef const char *  Def ;
#endif
#include <iostream>	
#include "calc.h"
#include "MyName.h"
using namespace std;

int main(void)
{
	//TCHAR* firstName;
	//firstName = 
	//wchar_t * ch;
	//ch = L"Hello World";
	//wprintf(ch);
	TCHAR * ch;
	ch = L"hello world";
	wprintf(ch);

    Calculator* calc = new Calculator;
	    Calculator& cl = *calc;
	cout<<calc->Addition(10, 10);
	
	cout<<cl.Multiplication(2, 2);

	LPCSTR str = "hello world";
    cout<<endln;
	printf(str);

	myChar ch;
	ch = "my custom charater";

	return 0;
}