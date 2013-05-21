#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <cstdlib>

using namespace std;

void writeToFile(const string& filename)
{
	fstream file(filename.c_str());
	if(!file)
	{
		cout<<"Cannot open output file "<<filename<<endl;
		exit(0);
	}
	for(int i =1; i < 256; i++)
	{
		file<<"value of int = "<<i<<" ascii = "<<static_cast<char>(i)<<endl;
	}
}
int main()
{
	writeToFile("charset.out");
	return 0;
}