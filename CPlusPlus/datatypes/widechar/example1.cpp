#include <iostream>
#include <cwctype>

using namespace std;

int main()
{
	wctype_t x;
	x = wctype("space");
	
	if(iswctype(L' ', x))
	{
		cout<<" is a space "<<endl;
	}
	cout<<x<<endl;
	
	return 0;
}