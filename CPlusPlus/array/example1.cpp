#include <iostream>

using namespace std;

int main()
{
int i[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

cout<<"value of i == "<<i<<endl;
cout<<"size of i == " << sizeof(i)<<endl;
cout<<"dimension of array "<<sizeof(i) / sizeof(int)<<endl;

for(int j = 0; j < sizeof(i) /sizeof(int); j++)
{
cout<<i[j]<<endl;
}
}