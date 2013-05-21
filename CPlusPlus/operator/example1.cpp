#include <iostream>
#include "mytest.h"
using namespace std;

int test::operator+(const int& d)
{
	this->age = d;
	return  this->age;
}
int main()
{
	test t;
	return 0;
}