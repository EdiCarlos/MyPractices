#define DEBUG
#include <iostream>


#ifndef DEBUG
#define ASSERT(x)
#else
#define ASSERT(x) \
if(!(x)) \
{\
	std::cout<<"ERROR !! Assert "<<#x<<" failed \n"; \
	std::cout<<" on line "<<__LINE__<<std::endl;\
	std::cout<<" on file "<<__FILE__<<std::endl;\
}
#endif

int main()
{ 
	int x = 5;
	std::cout<<" First Assert "<<std::endl;
	ASSERT(x == 5);
	std::cout<<" Second Assert "<<std::endl;
	ASSERT(x != 5);
	std::cout<<" Done "<<std::endl;
	return 0;
	
}