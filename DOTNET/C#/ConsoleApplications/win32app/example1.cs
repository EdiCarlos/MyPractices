using System;
using System.Windows.Forms;
using System.Drawing;

using System.Runtime.InteropServices;

class mylabel : Form
{
public mylabel()
{
}

}

class exe
{
[STAThread]
static void Main()
{
Application.Run(new mylabel());
}
}