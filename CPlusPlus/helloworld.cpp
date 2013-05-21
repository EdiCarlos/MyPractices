#include <iostream>

#define endln "\n"

using namespace std;

int main()
{
 int firstvalue, secondvalue;
 int * mypointer;

 mypointer = &firstvalue;
 *mypointer = 10;
  cout<<*mypointer<<endln;
 mypointer = &secondvalue;
 *mypointer = 20;
 cout<<*mypointer<<endln;

cout<<"first value = "<<firstvalue<<"Second value = "<<secondvalue<<endln;

}