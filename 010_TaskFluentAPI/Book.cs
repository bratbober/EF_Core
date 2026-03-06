namespace _010_TaskFluentAPI
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }

        public List<Autor> Authors { get; set; } = new();
    }
}
