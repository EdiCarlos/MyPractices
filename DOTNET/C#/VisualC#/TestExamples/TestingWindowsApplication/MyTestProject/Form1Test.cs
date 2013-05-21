using TestingWindowsApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyTestProject
{
    
    
    /// <summary>
    ///This is a test class for Form1Test and is intended
    ///to contain all Form1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Form1Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for sum
        ///</summary>
        [TestMethod()]
        public void sumTest()
        {
            Form1 target = new Form1(); // TODO: Initialize to an appropriate value
            int num1 = 10; // TODO: Initialize to an appropriate value
            int num2 = 10; // TODO: Initialize to an appropriate value
            int expected = 20; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.sum(num1, num2);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for button1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestingWindowsApplication.exe")]
        public void button1_ClickTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = target.button1; // TODO: Initialize to an appropriate value
            EventArgs e = new EventArgs();  // TODO: Initialize to an appropriate value
            target.textBox1.Text = "20";
            target.textBox2.Text = "10";
            try
            {
                target.button1_Click(sender, e);
                Assert.IsTrue(true);
            }
            catch(Form1.NotIntegerException fr)
            {
                System.Windows.Forms.MessageBox.Show(fr.Message);
                Assert.IsTrue(false);
            }
        }
    }
}
