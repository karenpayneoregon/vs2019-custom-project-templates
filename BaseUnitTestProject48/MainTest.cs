using System;
using BaseUnitTestProject48.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseUnitTestProject48
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod1()
        {
            Assert.IsTrue(Environment.UserName == "PayneK");
        }
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod2()
        {
            // TODO
        }
    }
}