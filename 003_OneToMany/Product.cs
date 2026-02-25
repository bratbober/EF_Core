namespace _003_OneToMany
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // Foreign key to Category
        public Category Category { get; set; } // Navigation property to Category

        public override string ToString()
        {
            return $"Product: Id={Id}, Name={Name}, Price={Price}, CategoryId={CategoryId}";
        }
    }
}
