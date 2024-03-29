#include <iostream>
#include <string>
#include "myhead.h"

using namespace std;

void showAll(myclass cla)
{
	cout<<cla.getfname()<<endl;
}
myclass::myclass()
{
	cout<<"default constructor called \n";
}
	    myclass::myclass(int age, string fname, string lname, string mname)
	    {
	     this->myage = age;
	    	this->fname = fname;
	    	this->lname = lname;
	    	this->mname = mname;
}

void myclass::showcl(myclass& cla)
{
	cout<<"\n"<<cla.getfname();
	cout<<"\n"<<cla.getlname();
	cout<<"\n"<<cla.getmname();

}

int myclass::getage()
{
	return myage;
}
myclass::~myclass()
{
	cout<<"\nDestructor called"<<endl;
}

int main()
{
	myclass cl(22, "arif", "khan", "hasan");
	cout<<"your first name is "<<endl;
	string fullname = cl.getfname() + " " + cl.getlname() + " " + cl.getmname();
  cl.setcity("mumbai");
	cout<<fullname<<endl;
	cout<<cl.getcity();
  cl.showcl(cl);
	return 0;
}