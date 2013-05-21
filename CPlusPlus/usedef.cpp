#define def1 "This is definition 1"

#ifndef def
#define def "This is first definition"
#else
#endif

#include <iostream.h>

int main()
{
cout<<def1<<"\n";
cout<<def<<"\n";
return 0;
}