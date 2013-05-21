#define endln "\n";
#include <iostream>

using namespace std;
 int main()
{
 int number = 100;
 int &nbr = number;
  cout<<"number "<<number<<endln;
 	cout<<"nbr = "<< nbr<<endln;
 	nbr = 200;
  cout<<"number "<<number<<endln;
 	cout<<"nbr = "<< nbr<<endln;
 	number = 1000;
 	cout<<"number "<<number<<endln;
 	cout<<"nbr = "<< nbr<<endln;
}