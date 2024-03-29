#include <iostream>
#include <cmath>
#include <cstdlib>

using namespace std;

class Abs
{
	public:

	double operator() (double v) const{
return abs(v);
}
};
class sine
{
	public:
	double operator() (double v) const{
return std::sin(v);
}
};

template <typename fo1, typename fo2>
class Composer
{
	private:
	fo1 o1;
	fo2 o2;
	public:
	Composer(fo1 oo1 , fo2 oo2): o1(oo1), o2(oo2)
	{
	}
	double operator()(double(v))
	{
	return o2(o1);
	}
};

template<typename fo>
void PrintValue(fo o1)
{
	for(int i = -2; i < 3; ++i)
	{
		cout<<"f("<<i * 0.1<<") = "<<o1(i * 0.1)<<endl;
	}
};
int main()
{
	cout<<Composer<Abs, sin>(Abs(), sine())(-0.5)<<endl<<endl;
  PrintValue(Abs());
  cout<<"starting to write sine values"<<endl;
 	PrintValue(sine());
	return 0;
}