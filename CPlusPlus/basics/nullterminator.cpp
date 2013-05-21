#include <iostream>
#include <cstring>
#include <cctype>

using namespace std;

int main()
{
	char *ch = "hello world";
  for(int i = 0; i < strlen(ch); i++)
  {
  	cout<<(char)toupper(ch[i]);
  }
	return 0;
}