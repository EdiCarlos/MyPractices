#ifndef __myabstract_h
#define __myabstarct_h

#include <iostream>
class area
{
	double dim1, dim2;
public:
	void setarea(double dim1, double dim2)
	{
		this->dim1 = dim1;
		this->dim2 = dim2;
	}
	void getdim(double &d1, double &d2)
	{
		d1 = dim1;
		d2 = dim2;
	}
	virtual double getarea() = 0;
};

class rectangle : public area
{
public:
	double getarea()
	{
		double d1, d2;
		getdim(d1, d2);
		return d1* d2;
	}
};
class triangle : public area
{
public:
	double getarea()
	{
		double d1, d2;
		getdim(d1, d2);
		return 0.5 * d1 * d2;
	}
};
#endif