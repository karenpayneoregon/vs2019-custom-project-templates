using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseNorthWindCoreLibrary.Classes;
using BaseNorthWindCoreLibrary.Classes.North.Classes;
using BaseNorthWindCoreLibrary.Data;
using BaseNorthWindCoreLibrary.Projections;
using BaseNorthWindCoreUnitTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseNorthWindCoreUnitTest
{
    [TestClass]
    public partial class CustomersTests : TestBase
    {
      
        [TestMethod]
        [TestTraits(Trait.EfCoreCustomersSelect)]
        public void CustomerCount()
        {
            using var context = new NorthwindContext();

            var customers = context.Customers.ToList();
            Assert.IsTrue(customers.Count == 91);
        }
        [TestMethod]
        [TestTraits(Trait.EfCoreCustomersSelect)]
        public async Task CustomersProject()
        {
            var customers = await CustomersOperations.GetCustomersWithProjectionAsync();

            string firstName = customers
                .FirstOrDefault(customer => customer.FirstName == "Maria").FirstName;

            Assert.IsTrue(firstName == "Maria");

        }
        #region Positive and negative test

        [TestMethod]
        [TestTraits(Trait.EfCoreCustomersSelect)]
        public void SingleCustomerByIdentifierGood()
        {
            int customerIdentifier = 1;
            CustomerEntity customer = CustomersOperations.CustomerByIdentifier(customerIdentifier);

            Assert.IsNotNull(customer);
            Assert.IsTrue(customer.CompanyName == "Alfreds Futterkiste");
        }
        [TestMethod]
        [TestTraits(Trait.EfCoreCustomersSelect)]
        public void SingleCustomerByIdentifierBad()
        {
            int customerIdentifier = 134;
            CustomerEntity customer = CustomersOperations.CustomerByIdentifier(customerIdentifier);
            Assert.IsNull(customer);
        }

        #endregion

        /// <summary>
        /// Uses <see cref="Task.WhenAll"/> to create a task that will complete when all of the supplied tasks have completed.
        /// In this case we are obtaining the same data although one is unsorted and the other sorted
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task WhenAll()
        {
            Task<List<CustomerItem>> customersTask1 = CustomersOperations.GetCustomersWithProjectionAsync();
            Task<List<CustomerItemSort>> customersTask2 = CustomersOperations.GetCustomersWithProjectionSortAsync();
            await Task.WhenAll(customersTask1, customersTask2);

            List<CustomerItem> test1 = customersTask1.Result;
            List<CustomerItemSort> test2 = customersTask2.Result;

            Assert.AreEqual(customersTask1.Result.Count, 91);
            Assert.AreEqual(customersTask2.Result.Count, 91);

        }
    }
}
