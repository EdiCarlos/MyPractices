#include <iostream>

using namespace std;

template <class T> class tclass{
public:
T a;
public:
tclass(T i){a = i;}
void showT()
{
	cout<<a<<endl;
}
};

int main()
{
	tclass<int> o1(10), o2(20);
	tclass<char> c1('A');

if(typeid(o1) == typeid(o2))
{
	cout<<"object o1 and o2 are same"<<endl;
}
if(typeid(o1) == typeid(c1))
{
	cout<<"object o1 and c1 are same"<<endl;
}
else
{
	cout<<"object o1 and c1 are not same"<<endl;
}
}