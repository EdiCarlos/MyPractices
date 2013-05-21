#include <iostream>
#include <iostream>
#include <algorithm>
#include <cctype>
#include <cwctype>

using namespace std;
inline bool caseInsCharCompareW(wchar_t a, wchar_t b)
{
	return (towupper(a) == towupper(b));
}
bool caseInsCompare(const wstring& s1, const wstring& s2)
{
	return ((s1.size() == s2.size()) && equal(s1.begin(), s1.end(), s2.begin(), caseInsCharCompareW)); 
}

int main()
{
	wstring str1 = L"the end";
	wstring str2 = L"THE END";
	
	if(caseInsCompare(str1, str2))
	{
		cout<<"Equals \n";
	}

   bool b = caseInsCharCompareW(str1, str2);
   
	
	return 0;
}