#include <iostream>
#include <complex>
#include <iomanip>

using namespace std;

int main()
{
   complex<double> cmplx(1, 0);
   complex<double> cmplx1(2, 0);
   cout<<cmplx<<setw(5)<<cmplx1<<endl;	
	return 0;
}