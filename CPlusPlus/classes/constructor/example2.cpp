#include <iostream>
#include <cstdio>

using namespace std;

class date
{
   int year, month, day;
	public:
	date(char * ch)
	{
		sscanf(ch, "*c*cd", &year, &month, &day);
	}
	date(int year, int month, int day)
	{
		this->year = year;
		this->month = month;
	this->day = day;
	}
	void showDate()
	{
		cout<<day<<"/"<<month<<"/"<<year<<endl;
	}
};
int main()
{
 	date d1(1988, 01, 10);
date d2("2009/01/10");
 	d1.showDate();
 	d2.showDate();
	return 0;
}