#include <iostream>

using namespace std;
int main()
{
	int *i, g[10] = {10, 20, 30, 50, 60};
	
	long *x, h[10];
	i = g;
	x = h;
	for(int j = 0; j < sizeof(g) / sizeof(int); j++)
	{
		cout<<*(i + j)<<endl;
	}
	return 0;
}