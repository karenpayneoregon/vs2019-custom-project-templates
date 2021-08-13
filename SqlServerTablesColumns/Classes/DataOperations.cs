using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerTablesColumns.Classes
{
    public class DataOperations
    {
        public delegate void OnGenerate(string sender);
        public static event OnGenerate GeneratedHandler;
        /// <summary>
        /// SQL-Server name
        /// </summary>
        public static string Server { get; set; }
        /// <summary>
        /// Database in Server
        /// </summary>
        public static string Database { get; set; }
      
        /// <summary>
        /// Get table names under <see cref="Server"/> for <see cref="Database"/>
        /// </summary>
        /// <returns>List of table names</returns>
        /// <remarks>
        /// Unused in this project
        /// </remarks>
        public static async Task<List<string>> TableNamesList()
        {
            var tableNameList = new List<string>();

            var sqlStatement = $"SELECT TABLE_NAME FROM [{Database}].INFORMATION_SCHEMA.TABLES " +
                               "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME <> 'sysdiagrams' " +
                               "ORDER BY TABLE_NAME";


            return await Task.Run(async () =>
            {

                await using var cn = new SqlConnection($"Server={Server};Database=master;Integrated Security=true");
                await using var cmd = new SqlCommand(sqlStatement, cn);

                cn.Open();

                var reader = await cmd.ExecuteReaderAsync();

                while (reader.Read())
                {
                    tableNameList.Add(reader.GetString(0));
                }

                return tableNameList;

            });

        }

        /// <summary>
        /// Get all database names for <see cref="Server"/>
        /// </summary>
        /// <returns>List of database names a-z order excluding system tables</returns>
        public static async Task<List<string>> DatabaseNameList()
        {
            var tableNameList = new List<string>();
            var sqlStatement = await File.ReadAllTextAsync("DatabaseNames.txt");


            return await Task.Run(async () =>
            {
                await using var cn = new SqlConnection($"Server={Server};Database=master;Integrated Security=true");
                await using var cmd = new SqlCommand(sqlStatement, cn);

                cn.Open();

                var reader = await cmd.ExecuteReaderAsync();

                while (reader.Read())
                {
                    tableNameList.Add(reader.GetString(0));
                }


                return tableNameList;

            });

        }

        public static void Generate(string tableName)
        {
            var sqlStatement = File.ReadAllText("ColumnNameArray.txt");
            using var cn = new SqlConnection($"Server={Server};Database={Database};Integrated Security=true");
            using var cmd = new SqlCommand(sqlStatement, cn);
            cmd.Parameters.Add("@TableName", SqlDbType.NChar).Value = tableName;
            
            cn.Open();

            var results = $"private static string[] {tableName}() => new[] {{{Convert.ToString(cmd.ExecuteScalar())}}};";

            GeneratedHandler?.Invoke(results);

        }

    }
}
