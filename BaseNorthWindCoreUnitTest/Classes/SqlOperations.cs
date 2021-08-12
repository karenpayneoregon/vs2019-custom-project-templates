using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaseNorthWindCoreUnitTest.Classes
{
    public class SqlOperations
    {
        /// <summary>
        /// SQL-Server name
        /// </summary>
        public static string Server { get; set; }
        /// <summary>
        /// Database in Server
        /// </summary>
        public static string Database { get; set; }

        public static (bool, Exception, Dictionary<int, int>) EmployeeMostOrders()
        {
            Dictionary<int, int> resultsDictionary = new();

            var selectStatement = 
                "SELECT EmployeeID, COUNT(EmployeeID) AS Counter " + 
                "FROM dbo.Orders  " + 
                "WHERE EmployeeID is not null " +
                "GROUP BY EmployeeID " + 
                "ORDER BY Counter DESC;";

            try
            {
                using var cn = new SqlConnection($"Server={Server};Database={Database};Integrated Security=true");
                using var cmd = new SqlCommand(selectStatement, cn);
                
                cn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultsDictionary.Add(reader.GetInt32(0), reader.GetInt32(1));
                }

                return (true, null, resultsDictionary);

            }
            catch (Exception exception)
            {
                return (false, exception, null);
            }
        }
        
    }
}
