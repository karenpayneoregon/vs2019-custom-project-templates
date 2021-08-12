using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BaseNorthWindCoreLibrary.Classes;
using BaseNorthWindCoreUnitTest.Base;
using BaseNorthWindCoreUnitTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWindCoreLibrary.Models;

namespace BaseNorthWindCoreUnitTest
{
    [TestClass]
    public partial class OrderTests
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// SELECT
        ///     EmployeeID,
        ///     COUNT(EmployeeID) AS Counter
        /// FROM
        ///     NorthWind2020.dbo.Orders
        /// GROUP BY
        ///     EmployeeID
        /// ORDER BY
        ///     Counter DESC
        /// </remarks>
        [TestMethod]
        [TestTraits(Trait.GroupingEntityFramework)]
        public async Task GroupByEmployeeIdentifierGetHighCountInOrders()
        {

            List<Employees> employeeList = await OrderOperations.GetEmployeesTask();
            IGrouping<int, Employees> employee = OrderOperations.EmployeeMostOrders(employeeList);

            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
            Assert.IsTrue(employee != default);

            Debug.WriteLine($"Order count: {employee.Count()} employee id: {employee.Key}");

            SqlOperations.Server = ".\\SQLEXPRESS";
            SqlOperations.Database = "NorthWind2020";

            //    |   |
            //    V   V    <- Discards
            var (_, _, dictionary) = SqlOperations.EmployeeMostOrders();

            Assert.AreEqual(employee.Count(), dictionary.FirstOrDefault().Value);

        }

    }
}
