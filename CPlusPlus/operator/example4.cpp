#include <iostream>

using namespace std;

class Complex
{
	public:
	Complex();
	Complex(double d, double x):re(d), im(x){}
	Complex operator + (Complex &other);
	Complex operator - (Complex &other);
  bool operator == (Complex &other);
  bool operator != (Complex &other);
  int  operator ++ (int);
	int operator -- (int);
	void Display(){cout<<re<<" "<<im<<endl;}
	int num1;
	private:
	double re, im;

};

int Complex::operator -- (int j)
{
	return j--;
}
int Complex::operator ++ (int i)
{
	
	return i++;
}
Complex Complex::operator + (Complex &other)
{
	
	return Complex(re + other.re, im +other.im);
}
Complex Complex::operator - (Complex &other)
{
	return Complex(re - other.re, im - other.im);
}
bool Complex::operator == (Complex & other)
{
  	return (re == other.re & im == other.im);
} 
bool Complex::operator !=(Complex & other)
{
	return (re != other.re & im != other.im);
}
int main()
{
	Complex a = Complex(10, 20);
	Complex b = Complex(10, 20);
	Complex c = a + b;
	c.Display();
	c.num1 = 10;
	cout<<"value of num 1 "<<c.num1<<endl;
	c.num1++;
	cout<<"value of num1 " <<c.num1<<endl;
	
	cout<<(a != b)<<endl;
	return 0;
}