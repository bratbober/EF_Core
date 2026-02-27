using _005_LazyLoadingExample;

using ApplicationDBContext db = new ApplicationDBContext();

List<User> users = db.Users.ToList();

foreach (User user in users)
{
    Console.WriteLine($"Name: {user.Name}, Company: {user.Company?.Name}");
}