#ifndef __BASEDERIVED_H
#define __BASEDERIVED_H

#include "stdafx.h"

using namespace std;

class baseclass
{
	int x, y;
public: 
	baseclass()
	{
     cout<<"base class constructor called"<<endl;
	}
	baseclass(int j)
	{
		cout<<"base class constructor called with value  ="<<j<<endl;
	}
	void set(int x, int y)
	{
		this->x = x;
		this->y = y;
	}
	void show()
	{
		cout<<"value of x "<<x<<" " <<y<<endl;
	}
};
class derivedclass : public baseclass
{
	int j;
public:
	derivedclass()
	{
		cout<<"derived class constructor called"<<endl;
	}
	derivedclass(int j):baseclass(j)
	{
		cout<<"derived class constructor called which has one parameter"<<endl;
     this->j = j;
	}
	void showj()
	{
		cout<<"value of j "<<j<<endl;
	}
};

class callmain
{
public: 
	void mymain();
};

#endif