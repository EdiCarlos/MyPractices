using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using av = Acrobat;
namespace UseAcrobatDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "D:\\T\\EDP\\In\\5057070_H1_DOC\\47020_5057070_00001.pdf";
            DocExp.PreviewControls.PdfPreview avdoc = new DocExp.PreviewControls.PdfPreview();
            //PdfPreview avdoc = new PdfPreview();
            avdoc.Preview(path);
            this.Controls.Add((Control)avdoc);
            avdoc.CreateControl();
        }
    }
   
}
