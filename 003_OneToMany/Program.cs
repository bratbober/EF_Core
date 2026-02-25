using _003_OneToMany;
using Microsoft.EntityFrameworkCore;

using ApplicationDBContext context = new ApplicationDBContext();

// Add Category
/*Category category = new Category() { Title = "Clothes" };
context.Categories.Add(category);
context.SaveChanges();*/

// Add Product
/*var products = new List<Product>
{
    // 1 — Їжа
    new Product { Name = "Burger", Price = 95, CategoryId = 1 },
    new Product { Name = "Pasta", Price = 150, CategoryId = 1 },
    new Product { Name = "Sushi Set", Price = 300, CategoryId = 1 },

    // 2 — Технології
    new Product { Name = "Smartphone", Price = 15000, CategoryId = 2 },
    new Product { Name = "Laptop", Price = 28000, CategoryId = 2 },
    new Product { Name = "Wireless Headphones", Price = 2500, CategoryId = 2 },

    // 3 — Одяг
    new Product { Name = "T-Shirt", Price = 400, CategoryId = 3 },
    new Product { Name = "Jeans", Price = 1200, CategoryId = 3 },
    new Product { Name = "Sneakers", Price = 2200, CategoryId = 3 },
};

context.Products.AddRange(products);
context.SaveChanges();*/


/*Category? category =
    context.Categories.Where(c => c.Title == "Food").FirstOrDefault();

Product product = new Product
{
    Name = "Borsch",
    Price = 130,
    Category = category
};

context.Products.Add(product);
context.SaveChanges();*/


/*var product = context.Products
    .Where(p => p.CategoryId == 2).Select(p => new 
    { 
        Name = p.Name,
        Price = p.Price
    }).FirstOrDefault();

Console.WriteLine(product);*/

// Eager loading(жадібне завантаження)
var product =  context.Products.Include(p => p.Category).ToList();

foreach (var item in product)
{
    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Category: {item.Category?.Title}");
}