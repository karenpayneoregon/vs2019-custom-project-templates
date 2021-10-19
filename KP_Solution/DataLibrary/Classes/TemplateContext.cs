using System.IO;
using System.Threading.Tasks;
using ConfigurationHelper;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace $safeprojectname$.Classes
{
    public partial class TemplateContext : DbContext
    {
        public TemplateContext()
        {
        }

        public TemplateContext(DbContextOptions<TemplateContext> options)
            : base(options)
        {
        }


        /// <summary>
        /// For logging to file via .LogTo
        /// </summary>
        private readonly StreamWriter _logStream = new("ef-log.txt", append: true);
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(Helper.ConnectionString())
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                    .LogTo(_logStream.WriteLine);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #region Takes care of disposing stream used for logging
        public override void Dispose()
        {
            base.Dispose();
            _logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await _logStream.DisposeAsync();
        }
        #endregion
    }
}
