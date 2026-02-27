using Microsoft.EntityFrameworkCore;

namespace _005_LazyLoadingExample
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "DATA SOURCE=403-6\\MSSQLSERVERSTEP; DATABASE=EFUserCompanyLazyDB; UID=sa; PWD=1; TrustServerCertificate=True;";
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString);

        }
    }
}
