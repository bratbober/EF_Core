using _002_AppWihtMigration;

using ApplicationDBContext context = new ApplicationDBContext();

// CRUD - Create, Read, Update, Delete

// Create
/*Person person1 = new Person()
{
    Name = "Petro",
    LastName = "Venom",
    Birthdate = new DateTime(2003, 2, 16)
};

context.People.Add(person1);
context.SaveChanges();*/

// Update
/*Person? person = context.People.Where(p => p.Id == 3).FirstOrDefault();
person.Name = "Yana";
context.SaveChanges();*/

// Delete
/*Person? person = context.People.Where(p => p.Id == 1).FirstOrDefault();
context.People.Remove(person);
context.SaveChanges();*/

// Read
List<Person> people = context.People.ToList();
foreach(var person in people)
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Birthdate: {person.Birthdate}, LastName: {person.LastName}");
}


