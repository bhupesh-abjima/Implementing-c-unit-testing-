using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassesTest
{
    [TestClass]
    public class MyClassesTestInitialization
    {
        [AssemblyInitialize()]
        public static void AssemblyInitialize(TestContext tc)
        {
            // TODO: Initialize for all tests within an assembly
            tc.WriteLine("In AssemblyInitialize() method");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            
        }
    }
}
