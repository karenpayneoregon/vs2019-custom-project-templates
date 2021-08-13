using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNorthWindCoreLibrary.Classes;
using BaseNorthWindCoreLibrary.Data;
using BaseNorthWindCoreLibrary.Projections;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NorthWindCoreLibrary.Models;

namespace BaseNorthWindCoreUnitTest.Classes
{
    public class DataOperations
    {
        /// <summary>
        /// Get products by category identifier
        /// </summary>
        /// <param name="categoryIdentifier">Existing category identifier</param>
        /// <returns>Product list</returns>
        /// <remarks>
        /// Note .TagWith, this will add the information to the results in SQL-Server Profiler output
        /// which can assist a DBA and/or developer to see who wrote and executed the statement and
        /// from what code e.g. in this case the class and method names
        /// </remarks>
        public static async Task<List<Products>> GetProductsWithoutProjection(int categoryIdentifier)
        {
            var productList = new List<Products>();

            await Task.Run(async () =>
            {
                await using var context = new NorthwindContext();

                productList = await context.Products
                    .Include(product => product.Supplier)
                    .Where(product => product.CategoryId == categoryIdentifier)
                    .TagWith($"From: {nameof(DataOperations)}.{nameof(GetProductsWithoutProjection)} by Karen Payne for teaching")
                    .ToListAsync();

            });

            return productList;
        }
        public static async Task<List<Product>> GetProductsWithProjectionGroupByCategory()
        {
            List<Product> productList = new();

            await Task.Run(async () =>
            {

                var products = await GetProductsWithProjection();

                productList = products
                    .GroupBy(product => new CategoryProduct { CategoryName = product.CategoryName, ProductName = product.ProductName })
                    .Select(product => new Product()
                    {
                        ProductId = products.FirstOrDefault().ProductId,
                        CategoryName = product.FirstOrDefault().CategoryName,
                        CategoryId = product.FirstOrDefault().CategoryId,
                        ProductName = product.FirstOrDefault().ProductName,
                        SupplierName = products.FirstOrDefault().SupplierName
                    })
                    .ToList();

            });

            return productList;
        }
        /// <summary>
        /// Example for retrieving products via nested projection
        /// </summary>
        /// <returns>Task&lt;List&lt;Product&gt;&gt;</returns>
        public static async Task<List<Product>> GetProductsWithProjection()
        {
            var productList = new List<Product>();

            await Task.Run(async () =>
            {
                await using var context = new NorthwindContext();

                productList = await context.Products
                    .Include(product => product.Supplier)
                    .Select(Product.Projection)
                    .ToListAsync();

            });

            return productList;
        }
        /// <summary>
        /// Example for working with dates
        /// </summary>
        /// <param name="categoryIdentifier"></param>
        /// <param name="discontinuedDate"></param>
        /// <returns></returns>
        /// <remarks>
        /// Equivalent WHERE statement
        /// WHERE P.DiscontinuedDate IS NOT NULL AND P.CategoryID = 6 AND year(P.DiscontinuedDate) &lt; 2004
        ///
        /// In earlier versions of Entity Framework the following
        ///    prod.DiscontinuedDate.Value.Year
        /// would not be evaluated and cause a runtime exception
        /// </remarks>
        public static async Task<List<Product>> GetProductsNotNullDiscontinuedDate(int categoryIdentifier, int discontinuedDate)
        {
            var productList = new List<Product>();

            await Task.Run(async () =>
            {
                await using var context = new NorthwindContext();

                productList = await context.Products
                    .Include(product => product.Supplier)
                    .Select(Product.Projection).Where(prod =>
                        prod.CategoryId == categoryIdentifier &&
                        prod.DiscontinuedDate.HasValue &&
                        prod.DiscontinuedDate.Value.Year < discontinuedDate)
                    .ToListAsync();

            });

            return productList;
        }


        public static List<Product> ReadProductsFromJsonFile(string fileName)
        {
            List<Product> products = new();

            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return products;
        }
    }
}
