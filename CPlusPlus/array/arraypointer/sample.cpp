typedef char* (*cp)(char fname[]);


#include <iostream>

using namespace std;
char* tocap(char fname[])
{
	int index = 0;
for(int i=0; i < strlen(fname); i++)
{
	if(i == index)
	{
		fname[i] = toupper(fname[i]);
	}
	if(fname[i] == ' ')
	{
		fname[i + 1] = toupper(fname[i + 1]);
	}
}

	return fname;
}
int main()
{
	char fname[] = "arif khan hasan";
  cp captialize = tocap;
  char* name =  captialize(fname);
  
  cout<<fname<<endl;
  cout<<name<<endl;	
	return 0;
}