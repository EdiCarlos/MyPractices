#include <iostream>

using namespace std;

int main()
{
for(int i = 0; i < 10; i++)
{
if(i == 8)
{
cout<<"goto mamamia"<<endl;
goto mamamia;
}
cout<<i;
}
mamamia:
 for(int i =0; i < 3; i++)
 {
 	cout<<"mamamia called"<<endl;
}

}