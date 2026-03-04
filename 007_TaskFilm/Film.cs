namespace _007_TaskFilm
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Actor> Actors { get; set; } = new();
        public int MovieStudioId { get; set; }
        public MovieStudio? MovieStudio { get; set; }
    }
}
