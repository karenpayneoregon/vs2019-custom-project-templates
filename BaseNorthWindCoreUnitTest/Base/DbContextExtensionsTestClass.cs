using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace BaseNorthWindCoreUnitTest
{
    public partial class DbContextExtensionsTestClass
    {
        private static string[] ModelNames() =>
            new[]
            {
                "BusinessEntityPhone", "Categories", "ContactDevices", "ContactType",
                "Contacts", "Countries", "Customers", "EmployeeTerritories", "Employees", "OrderDetails",
                "Orders", "PhoneType", "Products", "Region", "Shippers", "Suppliers", "Territories"
            };

        private static string[] CustomersColumnNames() =>
            new[]
            {
                "City","CompanyName","ContactId","ContactTypeIdentifier","CountryIdentifier",
                "CustomerIdentifier","Fax","ModifiedDate","Phone","PostalCode","Region","Street"
            };

        /// <summary>
        /// Perform any initialize for the class
        /// </summary>
        /// <param name="testContext"></param>
        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            TestResults = new List<TestContext>();
        }
    }
}
