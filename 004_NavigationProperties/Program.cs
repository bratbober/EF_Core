using _004_NavigationProperties;
using Microsoft.EntityFrameworkCore;

using ApplicationDBContext db = new ApplicationDBContext();


/*Company company1 = new Company { Name = "Microsoft" };
Company company2 = new Company { Name = "Google" };

db.Companies.Add(company1);
db.Companies.Add(company2);
db.SaveChanges();

User user1 = new User { Name = "Alice Smith", CompanyId = company1.Id };
User user2 = new User { Name = "Den Brown", CompanyId = company1.Id };
User user3 = new User { Name = "John Wick", CompanyId = company2.Id };
User user4 = new User { Name = "Lary Smith", CompanyId = company2.Id };
User user5 = new User { Name = "Bob Ten", CompanyId = company1.Id };

db.Users.AddRange(user1, user2, user3, user4, user5);
db.SaveChanges();*/



/*Company company1 = new Company { Name = "IBM" };
Company company2 = new Company { Name = "Apple" };

User user1 = new User { Name = "Yana Mazepa", Company = company1};
User user2 = new User { Name = "Tony Stark", Company = company1};
User user3 = new User { Name = "Jim Keryy", Company = company2};

db.Companies.AddRange(company1, company2);
db.Users.AddRange(user1, user2, user3);
db.SaveChanges();*/



/*User user1 = new User { Name = "Ivan Mazepa"};
User user2 = new User { Name = "Danylo Lisnichuk"};
User user3 = new User { Name = "Jack Sparow"};

Company company1 = new Company { Name = "HP" , Users = { user1 } };
Company company2 = new Company { Name = "Samsung", Users = { user2,user3 } };

db.Companies.AddRange(company1, company2);
db.Users.AddRange(user1, user2, user3);

db.SaveChanges();*/


// Підтягування даних з навігаційних властивостей


// Eager Loading(жадібне завантаження) -- Include

/*List<User> users = db.Users.Include(u => u.Company).ToList();

foreach (User user in users)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, CompanyID: {user.CompanyId}, Company: {user.Company?.Name}");
}*/

/*List<Company> companies = db.Companies.Include(c => c.Users).ToList();

foreach(Company company in companies)
{
    Console.WriteLine($"Company: {company.Name}");
    foreach(User user in company.Users)
    {
        Console.WriteLine($"User: {user.Name}");
    }
}*/


// Explicit Loading(явне завантаження) -- Load

/*Company? company = db.Companies.FirstOrDefault();
if(company != null)
{
    db.Users.Where(u => u.CompanyId == company.Id).Load(); 
    //db.Entry(company).Collection(c => c.Users).Load();

    Console.WriteLine(company.Name);
    foreach(User user in company.Users)
    {
        Console.WriteLine(user.Name);
    }
}*/

/*User? user = db.Users.FirstOrDefault();
if(user != null)
{
    db.Entry(user).Reference(u => u.Company).Load();
    Console.WriteLine($"User: {user.Name}, Company: {user.Company?.Name}");
}*/

// Lazy Loading(ліниве завантаження)
