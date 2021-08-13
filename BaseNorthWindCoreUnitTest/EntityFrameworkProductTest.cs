using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BaseNorthWindCoreUnitTest.Base;
using BaseNorthWindCoreUnitTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseNorthWindCoreUnitTest
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public partial class EntityFrameworkProductTest : TestBase
    {
        /// <summary>
        /// Simple GroupBy 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestTraits(Trait.SqlServerGroupingEntityFramework)]
        public async Task GroupProductByCategoryThenByProduct()
        {
            var result = await DataOperations.GetProductsWithProjectionGroupByCategory();
            var returnCount = result.Count;
            var products = DataOperations.ReadProductsFromJsonFile("products.json");

            Assert.IsTrue(returnCount == products.Count);

        }
        /// <summary>
        /// Test for working with dates and multiple where conditions on int properties
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestTraits(Trait.SqlServerDatesEntityFramework)]
        public async Task DiscontinuedDateWithoutNulls()
        {
            var categoryIdentifier = 6;
            var discontinuedYear = 2004;
            var expectedCount = 2;

            var result = await DataOperations
                .GetProductsNotNullDiscontinuedDate(categoryIdentifier, discontinuedYear);

            Assert.IsTrue(result.Count == 2,
                $"Expected {expectedCount} products on category " +
                $"{categoryIdentifier} and discontinued before {discontinuedYear}");
        }

    }

}