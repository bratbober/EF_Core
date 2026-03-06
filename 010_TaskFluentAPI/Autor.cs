namespace _010_TaskFluentAPI
{
    public class Autor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
