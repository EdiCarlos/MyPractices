#include <iostream>

using namespace std;

namespace n
{
	struct counter
	{
	  
	  static int n;
	};
	double n = 2.8;
}

int n::counter::n = 17;
int main()
{
	int counter = 0;
	int n = 10;
  cout<<n::n<<endl;	
	cout<<n::counter::n<<endl;
  cout<<counter<<endl;
  cout<<n<<endl;
//  cout<<x.n<<endl;
return 0;	
}