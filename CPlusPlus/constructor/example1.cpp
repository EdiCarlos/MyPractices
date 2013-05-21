#include <iostream>

using namespace std;

struct myclass
{
	public:
	    myclass(); //default constructor
	    myclass(int age, char* fname, char* lname, char* mname);
	    
	    private:
	    int myage;
	    char* fname;
	    char* lname;
	    char* mname;
	    public:
	       char* getfname();
	       char* getlname();
	       char* getmname();
	       int getage();
};
myclass::myclass()
{
	cout<<"default constructor called \n";
}
	    myclass::myclass(int age, char* fname, char* lname, char* mname)
	    {
	    	myage = age;
	    	fname = fname;
	    	lname = lname;
	    	mname = mname;
}
char* myclass::getfname()
{
	return fname;
}
char* myclass::getlname()
{
	return lname;
}
char* myclass::getmname()
{
	return mname;
}
int myclass::getage()
{
	return myage;
}
int main()
{
	myclass cl(22, "arif", "khan", "hasan");
	cout<<"your first name is "<<endl;
	char* name = cl.getfname();
	cout<<name;
	return 0;
}