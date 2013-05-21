#include "stdafx.h"
#include <iostream>
#include "myabstract.h"

using namespace std;

void callabstract()
{
	   area * ar;
	   rectangle rect;
	   triangle tri;
	   rect.setarea(10, 20);
	   tri.setarea(10, 20);
	   ar = &tri;
	   cout<<"triangle has area "<<ar->getarea()<<endl;

	   ar = &rect;
	   cout<<"rectangle has area " <<ar->getarea()<<endl;
	
}