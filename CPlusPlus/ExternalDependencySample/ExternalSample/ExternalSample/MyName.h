#ifndef mych
#typedef const char * mych
#endif
#include <iostream>

using namespace std;

class Name{
private:
	const char * firstName;
public:
	void SetFirstName(const char * fname) { firstName = fname;}
	const char * GetFirstName(){return firstName;}
};