using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Interfaces;
using System.Windows.Forms;

namespace DocExp.PreviewControls
{
    public class PdfPreview : AxAcroPDFLib.AxAcroPDF, IPreview
    {
        #region IPreview Members

        public void Preview(string path)
        {
            this.src = path;
            this.setShowToolbar(false);
            //this.Url = new Uri(path);
        }

        #endregion
    }
}
