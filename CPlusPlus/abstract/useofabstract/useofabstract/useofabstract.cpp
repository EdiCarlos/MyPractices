// useofabstract.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
//#include "myabstract.h"
#include "basederived.h"
//#include "argstobase.h"
//#include "basederiveheirarchy.h"
//#include "classtypecast.h"
//#include "dynamicCast.h"
//#include "copyconstrutor.h"
//#include "copyconst.h"
#include "useOfOperator.h"

using namespace std;

void useofconst(const char * arr);
char * mystrcpy(char * str1, const char * var);



int _tmain(int argc, _TCHAR* argv[])
{
	//StringClass a("hello world"), b(a);
	//cout<<a.get()<<endl;
	//cout<<b.get()<<endl;
  //  myCalc m1(100, 200), m2(100, 200);
  //   bool var = (m1 == m2);
	 //cout<<var<<endl;
      callmain main;
	  main.mymain();
	return 0;
}

char * mystrcpy(char * str1, const char * var)
{
	str1 = const_cast<char *>(var);
	return str1;
}

void useofconst(const char * arr)
{
	cout<<arr<<endl;
}


