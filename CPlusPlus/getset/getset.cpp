#include <iostream>
#include <string>

using namespace std;
string fname, lname, mname;

void SetFname(string fn)
{
	::fname = fn;
	}
	void SetLname(string ln)
	{
		::lname = ln;
	}
	void SetMname(string mn)
	{
		::mname = mn;
	}
	string GetFname()
	{
		return ::fname;
	} 
	string GetLname()
	{
		return ::lname;
	} 
	string GetMname()
	{
		return ::mname;
	} 

int main()
{
cout<<"Enter your first name \n\r";
string fname,lname,mname;
cin>>fname;
cout<<"enter you last name \n\r";
cin>>lname;
cout<<"Enter you middle name\n ";
cin>>mname;

SetFname(fname);
SetLname(lname);
SetMname(mname);

cout<<"your full name is"<<endl;
cout<<GetFname()<<endl;
cout<<GetLname()<<endl;
cout<<GetMname()<<endl;
}