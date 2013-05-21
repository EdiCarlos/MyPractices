/*
 * Person.h
 *
 *  Created on: Nov 26, 2012
 *      Author: axkhan2
 */
#include <iostream>

using namespace std;

#ifndef PERSON_H_
#define PERSON_H_

class Person
{
	protected:
		char* firstName;
		char* lastName;
		int age;
	public:
	Person();
		Person(char* firstName, char * lastName, int age);

       int GetAge();
       char* FirstName();
       char* LastName();
       virtual basic_string<char> ShowFullName();
};

class Employee : Person
{
private:
	double baseSalary;
public:
	Employee(double salary);
	Employee(double salary, char* fname, char* lname, int age);
	void ShowNameAndSalary();
	virtual basic_string<char> ShowFullName();
};



#endif /* PERSON_H_ */
