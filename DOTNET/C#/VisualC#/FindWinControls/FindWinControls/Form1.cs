using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindWinControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Button btn in this.Controls.FindAll().OfType<Button>())
            {
                MessageBox.Show(btn.Name);
            }
            
            //Iter it = new Iter();

            ////foreach (string vr in it)
            ////{
            ////    MessageBox.Show(vr.ToString());
            ////}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Iter : System.Collections.IEnumerable
    {
        #region IEnumerable Members

        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "Arif";
            yield return "Khan";
            yield return "Bannehasan";
        }
        #endregion

    }
}
