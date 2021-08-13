using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BaseNetCoreDbContextExtensionsProject.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BaseNetCoreDbContextExtensionsProject.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class DbContextExtensions
    {
        /// <summary>
        /// Determine if a connection can be made asynchronously
        /// </summary>
        /// <param name="context"><see cref="DbContext"/></param>
        /// <returns></returns>
        public static async Task<bool> TestConnection(this DbContext context) =>
            await Task.Run(async () => await context.Database.CanConnectAsync());

        /// <summary>
        /// Determine if a connection can be made asynchronously with <see cref="CancellationToken"/>
        /// </summary>
        /// <param name="context"><see cref="DbContext"/></param>
        /// <param name="token">&lt;see cref="CancellationToken"/&gt;</param>
        /// <returns></returns>
        public static async Task<bool> TestConnection(this DbContext context, CancellationToken token) =>
            await Task.Run(async () => await context.Database.CanConnectAsync(token), token);

        /// <summary>
        /// Get model names for a <see cref="DbContext"/>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<string> GetModelNames(this DbContext context) =>
            context.ModelTypeInformation().Select(item => item.Name).ToList();

        public static List<Type> ModelTypeInformation(this DbContext context) => 
            context.Model.GetEntityTypes().Select(entityType => entityType.ClrType).ToList();

        /// <summary>
        /// Get details for a model
        /// </summary>
        /// <param name="context">Active dbContext</param>
        /// <param name="modelName">Model name in context</param>
        /// <returns></returns>
        public static List<SqlColumn> GetEntityProperties(this DbContext context, string modelName)
        {

            if (context == null) throw new ArgumentNullException(nameof(context));

            Type entityType = context.Model.GetEntityTypes()
                .Select(eType => eType.ClrType)
                .FirstOrDefault(x => x.Name == modelName);

            var sqlColumnsList = new List<SqlColumn>();

            // ReSharper disable once AssignNullToNotNullAttribute
            IEnumerable<IProperty> properties = context.Model.FindEntityType(entityType).GetProperties();

            foreach (IProperty itemProperty in properties)
            {
                var sqlColumn = new SqlColumn() { Name = itemProperty.Name };

                var test = itemProperty.GetColumnType();
                var comment = context.Model.FindEntityType(entityType).FindProperty(itemProperty.Name).GetComment();

                sqlColumn.Description = string.IsNullOrWhiteSpace(comment) ? itemProperty.Name : comment;

                sqlColumn.IsPrimaryKey = itemProperty.IsKey();
                sqlColumn.IsForeignKey = itemProperty.IsForeignKey();
                sqlColumn.IsNullable = itemProperty.IsColumnNullable();

                sqlColumn.ClrType = itemProperty.ClrType;
                sqlColumn.SqlType = itemProperty.GetColumnType();

                sqlColumnsList.Add(sqlColumn);

            }

            return sqlColumnsList;
        }
    }
}
