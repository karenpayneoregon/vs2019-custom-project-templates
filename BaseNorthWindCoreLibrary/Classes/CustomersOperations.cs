using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseNorthWindCoreLibrary.Classes.North.Classes;
using BaseNorthWindCoreLibrary.Data;
using BaseNorthWindCoreLibrary.Projections;
using Microsoft.EntityFrameworkCore;
using NorthWindCoreLibrary.Models;

namespace BaseNorthWindCoreLibrary.Classes
{
    public class CustomersOperations
    {
        public static async Task<List<CustomerItem>> GetCustomersWithProjectionAsync()
        {

            return await Task.Run(async () =>
            {
                await using var context = new NorthwindContext();
                return await context.Customers
                    .Select(CustomerItem.Projection)
                    .ToListAsync();
            });
        }

        #region Not part of part 4 lesson
        /// <summary>
        /// Custom projection for teaching sorting by property name as a string
        /// </summary>
        /// <returns>List&lt;<see cref="CustomerItemSort"/>&gt;</returns>
        public static async Task<List<CustomerItemSort>> GetCustomersWithProjectionSortAsync()
        {

            return await Task.Run(async () =>
            {
                await using var context = new NorthwindContext();
                return await context.Customers
                    .Select(CustomerItemSort.Projection)
                    .ToListAsync();
            });
        }

        #endregion

        public static CustomerEntity CustomerByIdentifier(int identifier)
        {
            using var context = new NorthwindContext();
            return context.Customers.Select(Customers.Projection)
                .FirstOrDefault(custEntity => custEntity.CustomerIdentifier == identifier);
        }
    }
}
