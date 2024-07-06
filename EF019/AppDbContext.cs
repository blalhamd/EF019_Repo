

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF019
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder().AddJsonFile("AppSetting.json").Build();
            var connection = config.GetSection("ConnectionString").Value;
            
            optionsBuilder.UseSqlServer(connection);

            optionsBuilder.AddInterceptors(new SoftDeleteInterceptor());

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}
