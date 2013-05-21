#include <iostream>
#include <string.h>
#include "Headers/Person.h"

using namespace std;

Person::Person()
{

}
Person::Person(char* fName, char * lName, int page)
{
	firstName = fName;
	lastName = lName;
	age = page;
}

char* Person::FirstName()
{
	return firstName;
}

char* Person::LastName(){
	return lastName;
}
basic_string<char> Person::ShowFullName(){
return std::string(firstName)+ lastName;
}
int Person::GetAge(){
	return age;
}

Employee::Employee(double salary): Person("Arif ", "Khan", 25){
	baseSalary = salary;
}
Employee::Employee(double salary, char* fname, char* lname, int page): Person()
{
	baseSalary = salary;
	firstName = fname;
	lastName = lname;
	age = page;
}
void Employee::ShowNameAndSalary()
{
	cout<<"Employee Name: ";
	cout<<FirstName()<<" "<<LastName()<<endl;
    cout<<"Employee Salary: ";
    cout<<baseSalary<<endl;
}
basic_string<char> Employee::ShowFullName(){
	return Person::ShowFullName();
}
