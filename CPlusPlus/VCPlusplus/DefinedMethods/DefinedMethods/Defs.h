#include <iostream>


#ifndef SomeMethod()
#define SomeMethod() int GetProductId(){ return 100;}
#endif

#define OBJECT_PID_NONE( iPropID ) \
virtual bool GetObjectPID(int &iPID) { iPID = iPropID; return false; }

#define ShowName( name ) \
	virtual char* getName(){return name;}

#ifndef endln
#define endln "\n"
#endif