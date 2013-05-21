using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace SupremeTransport
{
    class FormStatus
    {
        public FormStatus()
        {
        }
        /// <summary>
        /// This method checks if mdichildren is active or not
        /// </summary>
        /// <param name="mdiParent">Enter MdiParent</param>
        /// <param name="frm">Enter Form to check</param>
        /// <returns></returns>
        public static bool IsActive(Form mdiParent, Form frm)
        {
            //foreach (Form f in mdiParent.MdiChildren)
            //{
            //    if (f.Name == frm.Name)
            //    {
            //        return true;
            //    //    break;
            //    }
            //}
            return false;
        }
    }
}
