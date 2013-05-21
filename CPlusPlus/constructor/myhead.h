#ifndef myheadH
#define myheadH

#include <iostream>
#include <string>

using namespace std;

class myclass
{
	public:
	    myclass(); //default constructor
	    myclass(int age, string fname, string lname, string mname);
	    ~myclass();
	    private:
	    int myage;
	    string fname;
	    string lname;
	    string mname;
	       char* city;
	       static char* state;

	    public:
	       string getfname() const {return fname;};
	       string getlname() const {return lname;};
	       string getmname() const {return mname;};
   char* getcity() const {return this->city;};
   void setcity(char* city){ this->city = city; };
   static char* getstate();
   static void setage(char* age)
   {
   	
  }
	       int getage();
  void showcl(myclass& cla);
  
};

#endif //end of myheadH