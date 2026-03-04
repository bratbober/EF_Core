using _007_TaskFilm;

ApplicationDBContext context = new ApplicationDBContext();

// add new film
/*context.Films.Add(new Film { Name = "It", ReleaseDate = new DateTime(2017, 01, 01), MovieStudioId = 1 });
context.SaveChanges();*/

// edit film
/*Film? film = context.Films.Where(f => f.Id == 2).FirstOrDefault();
film.Name = "The Matrix Reloaded";
context.SaveChanges();*/

// delete film
/*Film? film = context.Films.Where(f => f.Id == 1).FirstOrDefault();
context.Films.Remove(film);
context.SaveChanges();*/

// add new actor
/*context.Actors.Add(new Actor { Name = "Adam Sandler" });
context.SaveChanges();*/

// edit actor
/*Actor? actor = context.Actors.Where(a => a.Id == 2).FirstOrDefault();
actor.Name = "Keanu Charles Reeves";
context.SaveChanges();*/

// delete actor
/*Actor? actor= context.Actors.Where(a => a.Id == 6) .FirstOrDefault();
context.Actors.Remove(actor);
context.SaveChanges();*/

// add movieStudio
/*context.MovieStudios.Add(new MovieStudio { Name = "20th"} );
context.SaveChanges();*/