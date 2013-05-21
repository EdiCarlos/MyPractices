using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.IO;

namespace AutomateUnitTest.UnitTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestInitialize]
        public void InitializeTest()
        {

        }
        [TestMethod]
        public void AdditionTest()
        {
            foreach(string fileName in Directory.GetFiles(@"D:\Documents and Settings\axkhan2\Desktop\APS\UnittestAutomation\XMLS"))
            {
            }
            Program prog = new Program();
            int result = prog.Addition(10, 10);
            int actual = 20;
            Assert.AreEqual<int>(result, actual);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Program prog = new Program();
            int result = prog.Subtraction(100, 10);
            int actual = 90;
            Assert.AreEqual<int>(result, actual);
        }

        [TestMethod]
        public void RunTest()
        {
            Type tp = CreateTest();
            object myinstance = Activator.CreateInstance(tp);
            tp.InvokeMember("DynamicTestMethod", BindingFlags.InvokeMethod, null, myinstance, new object[] { });
        }
        public static Type CreateTest()
        {
            AppDomain currentDomain = Thread.GetDomain();

            AssemblyName assName = new AssemblyName();
            assName.Name = "DynamicTest";
            AssemblyBuilder assemblyBuilder = currentDomain.DefineDynamicAssembly(assName, AssemblyBuilderAccess.Run);
            
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicModule");

            TypeBuilder typeBuilder = moduleBuilder.DefineType("DynamicType", TypeAttributes.Public);

            CustomAttributeBuilder customTypeAttributeBuilder = new CustomAttributeBuilder(typeof(TestClassAttribute).GetConstructors()[0], new object[]{});
            typeBuilder.SetCustomAttribute(customTypeAttributeBuilder);

            MethodBuilder methodBuilder = typeBuilder.DefineMethod("DynamicTestMethod", MethodAttributes.Public, null, new Type[] { });
            CustomAttributeBuilder customMethodAttributeBuilder = new CustomAttributeBuilder(typeof(TestMethodAttribute).GetConstructors()[0], new object[] { });
            methodBuilder.SetCustomAttribute(customMethodAttributeBuilder);


            ILGenerator il = methodBuilder.GetILGenerator();

            il.EmitWriteLine("Hello world");
            il.Emit(OpCodes.Ret);
            return typeBuilder.CreateType();

        }
    }
}
