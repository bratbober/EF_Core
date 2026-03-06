using Microsoft.EntityFrameworkCore;

namespace _010_TaskFluentAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Autor> Authors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "DATA SOURCE=403-6\\MSSQLSERVERSTEP; DATABASE=EFBookAuthorPublisherDB; UID=sa; PWD=1; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "Penguin Books" },
                new Publisher { Id = 2, Name = "O'Reilly Media" },
                new Publisher { Id = 3, Name = "Packt Publishing" }
);

            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, FirstName = "Robert", Surname = "Martin" },
                new Autor { Id = 2, FirstName = "Martin", Surname = "Fowler" },
                new Autor { Id = 3, FirstName = "Jon", Surname = "Skeet" },
                new Autor { Id = 4, FirstName = "Andrew", Surname = "Troelsen" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Clean Code", Pages = 464, Price = 40, PublisherId = 1 },
                new Book { Id = 2, Name = "Refactoring", Pages = 448, Price = 45, PublisherId = 1 },
                new Book { Id = 3, Name = "C# in Depth", Pages = 528, Price = 50, PublisherId = 2 },
                new Book { Id = 4, Name = "Pro C# 10", Pages = 800, Price = 55, PublisherId = 3 }
            );

            modelBuilder.Entity("BookAuthor").HasData(
                new { Book_Id = 1, Author_Id = 1 },
                new { Book_Id = 2, Author_Id = 2 },
                new { Book_Id = 3, Author_Id = 3 },
                new { Book_Id = 4, Author_Id = 4 }
            );

        }
    }

}
