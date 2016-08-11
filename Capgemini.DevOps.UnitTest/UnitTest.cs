using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capgemini.DevOps.UnitTest
{
    /// <summary>
    /// Summary description for UnitTest
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.AreEqual(5, 5);
        }

        [TestMethod]
        public void TestMethod3()
        {

            Assert.AreEqual(7, 7);
        }
    }
}
