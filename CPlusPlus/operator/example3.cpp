#include <iostream>

using namespace std;

struct Complex
{
	
	Complex(double d, double r):re(d), im(r){}
	Complex operator + (Complex &other);
	Complex operator - (Complex &other);
	void Display(){cout<<re<<" "<<im<<endl;}
	
	private:
	double re, im;
};
Complex Complex::operator + (Complex &other)
{
	return Complex(re + other.re, im + other.im);
}
Complex Complex::operator -(Complex &other)
{
	return Complex(re - other.re, im - other.im);
}
int main()
{
	Complex a = Complex(10, 20);
	Complex b = Complex(10, 20);
	Complex c =  a - b;
  
	
	c.Display();
	
	return 0;
}