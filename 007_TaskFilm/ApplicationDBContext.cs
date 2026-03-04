using Microsoft.EntityFrameworkCore;

namespace _007_TaskFilm
{ 
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieStudio> MovieStudios { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "DATA SOURCE=403-6\\MSSQLSERVERSTEP; DATABASE=EFFilmDB; UID=sa; PWD=1; TrustServerCertificate=True;";
            optionsBuilder
                .UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Сідінг курсів
            modelBuilder.Entity<MovieStudio>().HasData(
                new MovieStudio { Id = 1, Name = "Warner Bros" },
                new MovieStudio { Id = 2, Name = "Universal Pictures" },
                new MovieStudio { Id = 3, Name = "Paramount Pictures" }
    );

            // 2. Сідінг фільмів
            modelBuilder.Entity<Film>().HasData(
                new Film { Id = 1, Name = "Inception", ReleaseDate = new DateTime(2010, 7, 16), MovieStudioId = 1 },
                new Film { Id = 2, Name = "The Matrix", ReleaseDate = new DateTime(1999, 3, 31), MovieStudioId = 1 },
                new Film { Id = 3, Name = "Jurassic Park", ReleaseDate = new DateTime(1993, 6, 11), MovieStudioId = 2 },
                new Film { Id = 4, Name = "Interstellar", ReleaseDate = new DateTime(2014, 11, 7), MovieStudioId = 1 },
                new Film { Id = 5, Name = "Gladiator", ReleaseDate = new DateTime(2000, 5, 5), MovieStudioId = 3 },
                new Film { Id = 6, Name = "The Mummy", ReleaseDate = new DateTime(1999, 5, 7), MovieStudioId = 2 }

            );

            // 3. Сідінг акторів
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Leonardo DiCaprio" },
                new Actor { Id = 2, Name = "Keanu Reeves" },
                new Actor { Id = 3, Name = "Sam Neill" },
                new Actor { Id = 4, Name = "Matthew McConaughey" },
                new Actor { Id = 5, Name = "Russell Crowe" },
                new Actor { Id = 6, Name = "Brendan Fraser" }
            );

            // 4. Сідінг зв’язків Film <-> Actor (many-to-many)
            modelBuilder.Entity("ActorFilm").HasData(
                new { ActorsId = 1, FilmsId = 1 }, // DiCaprio -> Inception
                new { ActorsId = 2, FilmsId = 2 }, // Reeves -> Matrix
                new { ActorsId = 3, FilmsId = 3 },  // Neill -> Jurassic Park
                new { ActorsId = 4, FilmsId = 4 }, // McConaughey -> Interstellar
                new { ActorsId = 5, FilmsId = 5 }, // Crowe -> Gladiator
                new { ActorsId = 6, FilmsId = 6 }, // Fraser -> The Mummy

        // Декілька акторів у фільмі
                new { ActorsId = 1, FilmsId = 4 }, // DiCaprio (умовно) -> Interstellar
                new { ActorsId = 2, FilmsId = 1 }  // Reeves (умовно) -> Inception
            );
        }
    }
}
