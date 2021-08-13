using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
