#include <iostream>

using namespace std;

class Animal
{
	public:
	Animal(){cout<<"animal constructor called"<<endl;}
	virtual ~Animal(){cout<<"animal destructor called"<<endl;}
	virtual void Speak(){cout<<"animal speack"<<endl;}
	protected:
	int itsAge;
	
};

class Cat : public Animal
{
	public:
	Cat(){cout<<"Cat constructor called"<<endl; }
	~Cat(){cout<<"Cat Destructor called"<<endl; }
	void Speak(){cout<<"Meow!!!"<<endl;}
};
class cl : public Cat
{
	public:
	cl();
	~cl(){cout<<"class destructor called"<<endl;}
};
int main()
{
   Animal *pCat = new Cat;
	pCat->Speak();
	return 0;
}