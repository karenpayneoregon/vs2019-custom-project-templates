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
        [TestTraits(Trait.DbContextExtensions)]
        public async Task CanConnect()
        {
            await using var context = new NorthwindContext();
            Assert.IsTrue(await context.TestConnection());
        }

        /// <summary>
        /// Get all model names in DbContext
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestTraits(Trait.DbContextExtensions)]
        public async Task GetModelNames()
        {
            var expected = ModelNames();
            await using var context = new NorthwindContext();

            var modelNames = context.GetModelNames().ToArray();
            CollectionAssert.AreEqual(modelNames,expected);
        }

        /// <summary>
        /// Get all columns for a specific model
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestTraits(Trait.DbContextExtensions)]
        public async Task GetColumnNamesForTable()
        {
            var expected = CustomersColumnNames();
            await using var context = new NorthwindContext();

            var customersColumnNames = context
                .GetEntityProperties("Customers")
                .Select(sqlColumn => sqlColumn.Name)
                .OrderBy(x => x);

            CollectionAssert.AreEqual(customersColumnNames.ToArray(), expected);

        }


    }

}