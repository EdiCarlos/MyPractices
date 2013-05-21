#include <iostream>

using namespace std;

int main()
{
int arr[2][4] = {{1, 2, 3, 4}, {6,7,8,9}};
int *ptr[2];

*ptr = arr[0];

(*ptr)[0] = arr[0][0];
(*ptr)[1] = arr[0][1];
(*ptr)[2] = arr[0][2];
(*ptr)[3] = arr[0][3];

*(ptr + 1) = arr[1];
(*(ptr + 1))[0] = arr[1][0];
(*(ptr + 2))[1] = arr[1][1];
(*(ptr + 3))[2] = arr[1][2];
(*(ptr + 4))[3] = arr[1][3];


cout<<(*ptr)[0]<<endl;
cout<<(*ptr)[1]<<endl;
cout<<(*ptr)[2]<<endl;
cout<<(*ptr)[3]<<endl;

cout<<(*(ptr))[0]<<endl;
cout<<(*(ptr))[1]<<endl;
cout<<(*(ptr))[2]<<endl;
cout<<(*(ptr))[3]<<endl;

}