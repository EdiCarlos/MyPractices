#include <iostream>

using namespace std;

int main()
{
outer:
for(int i =0; i < 10; i++)
{
cout<<"outer loop"<<i<<endl;

inner:
for(int j =0; j < 10; j++)
{
cout<<"inner loop"<<j<<endl;

	if(j == 5)
	{
   cout<<"if j equals to 5 goto outer loop"<<endl;
   cout<<"going to outer loop"<<endl;
   break;
	}
	
}
if(i == 8)
{
cout<<"breaking out early"<<endl;
break;
}
}
}