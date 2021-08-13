using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseNetCoreDbContextExtensionsProject.LanguageExtensions;
using BaseNetCoreLanguageExtensionsProject.LanguageExtensions;
using BaseNorthWindCoreLibrary.Data;
using BaseNorthWindCoreUnitTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseNorthWindCoreUnitTest
{
    /// <summary>
    /// TODO Move to a new unit test project
    /// </summary>
    [TestClass]
    public partial class DbContextExtensionsTestClass : TestBase
    {
        /// <summary>
        /// Test connection 
        /// </summary>
        [TestMethod]
        public async Task CanConnect()
        {
            await using var context = new NorthwindContext();
            Assert.IsTrue(await context.TestConnection());
        }

        [TestMethod]
        public async Task GetModelNames()
        {
            var expected = ModelNames();
            await using var context = new NorthwindContext();

            var modelNames = context.GetModelNames().ToArray();
            CollectionAssert.AreEqual(modelNames,expected);
        }

    }

}