using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
               
            }
            catch (FormatException fr)
            {
                    throw new NotIntegerException("Entered string is not an Integer");
            }
            
          
        }
        public int sum(int num1, int num2)
        {
            return (num1 + num2);
        }
        [global::System.Serializable]
        public class NotIntegerException : Exception
        {
            //
            // For guidelines regarding the creation of new exception types, see
            //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
            // and
            //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
            //

            public NotIntegerException() { }
            public NotIntegerException(string message) : base(message) { }
            public NotIntegerException(string message, Exception inner) : base(message, inner) { }
            protected NotIntegerException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }
        }
    }

}
