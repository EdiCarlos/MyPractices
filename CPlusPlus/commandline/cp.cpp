#include <iostream>
#include <fstream>
using namespace std;

int main(int argc, char* argv[])
{
	if(argc != 3)
	{
		cout<<"Usage: cp infile_name out_filename"<<endl;
	}
	else
	{
		ifstream infile(argv[1], ios::in);
		ofstream outfile(argv[2], ios::out);
		if(!infile)
		{
			cout<<argv[1]<<" could not be opened"<<endl;
		return -1;
		}
		if(!outfile)
		{
			cout<<argv[2]<<"could not be opened"<<endl;
		return -1;
		}
		char c = infile.get();
		
		while(infile)
		{
			outfile.put(c);
			c = infile.get();
		}
		
	}
	return 0;
}