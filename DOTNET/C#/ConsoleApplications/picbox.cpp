#include <windows.h>

#using <System.dll>
#using <System.Drawing.dll>
#using <System.Windows.Forms.dll>

using namespace System;
using namespace System::Drawing;
using namespace System::Windows::Forms;

public ref class CExercise : public Form
{
private:
    PictureBox ^ pctBox;

public:
    CExercise()
    {
	InitializeComponent();
    }

    void InitializeComponent()
    {
	pctBox = gcnew PictureBox;
	pctBox->Location = Point(10, 10);
	pctBox->Size = System::Drawing::Size(200, 150);
	Controls->Add(pctBox);
    }
};

int APIENTRY WinMain(HINSTANCE hInstance,
		     HINSTANCE hPrevInstance,
		     LPSTR lpCmdLine,
		     int nCmdShow)
{
    Application::Run(gcnew CExercise());

    return 0;
}
 
