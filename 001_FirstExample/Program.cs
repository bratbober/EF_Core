using _001_FirstExample;

using ApplicationDBContext context = new ApplicationDBContext(); 

Person person1 = new Person() {
    Name = "Den",
    LastName = "Smith",
    Birthdate = new DateTime(1999, 10, 10) 
};

context.People.Add(person1);
context.SaveChanges();





