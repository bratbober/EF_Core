namespace _007_TaskFilm
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; } = new();
    }
}
