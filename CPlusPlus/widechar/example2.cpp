#include <iostream>
#include <cwctype>
#include <cctype>
#include <string>

using namespace std;

int main()
{
	wstring str = L"hello world";
	wstring str1 = L"hello world";
//	printf("%s", "hello world");
	wchar_t a = (wchar_t)L"hello world";
	cout<<a;
	return 0;
}