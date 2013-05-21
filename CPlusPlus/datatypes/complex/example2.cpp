#include <iostream>
#include <complex>
#include <iomanip>

using namespace std;

int main()
{
   complex<double> cmplx(1, 3);
   complex<double> cmplx1(2, 1);
   cout<<cmplx<<setw(5)<<cmplx1<<endl;	
	complex<double> cmplx3 = cmplx + cmplx1;
	cout<<"value of complex number cmplx3 "<<cmplx3<<endl;
	return 0;
}