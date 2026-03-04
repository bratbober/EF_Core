namespace _007_TaskFilm
{
    public class MovieStudio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; } = new();
    }
}
