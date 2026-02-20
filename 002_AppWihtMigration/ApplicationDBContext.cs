using Microsoft.EntityFrameworkCore;

namespace _002_AppWihtMigration
{
    public class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "DATA SOURCE=403-6\\MSSQLSERVERSTEP; DATABASE=EFPeopleDB; UID=sa; PWD=1; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Person> People { get; set; }

    }
}
