#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
   FILE * fi;
  
   char name[100];
   fi = fopen("mytext.txt", "w");
   for(int i = 0; i < 3; i++)
   {
   	puts("please enter your name down there ");
    gets(name);
   	fprintf(fi, "name: %d %s %s \n",i, name, "some thing extra");
   	
  }	
  
  fclose(fi);
	return 0;
}