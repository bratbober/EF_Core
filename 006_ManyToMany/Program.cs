using _006_ManyToMany;
using Microsoft.EntityFrameworkCore;


ApplicationDBContext context = new ApplicationDBContext();

/*Student student1 = new Student { Name = "Alice" };
Student student2 = new Student { Name = "Bob" };
Student student3 = new Student { Name = "Charlie" };

context.Students.AddRange(student1, student2, student3);

Course course1 = new Course { Name = "Mathematics" };
Course course2 = new Course { Name = "Physics" };

context.Courses.AddRange(course1, course2);

course1.Students.AddRange(student1, student2);   
course2.Students.AddRange(student2, student3);

context.SaveChanges();*/

/*List<Course> courses = context.Courses.Include(c => c.Students).ToList();
foreach(Course course in courses)
{
    Console.WriteLine(course.Name);
    foreach(Student student in course.Students)
    {
        Console.WriteLine(student.Name);
    }
}*/

/*Student? student= context.Students.Include(s => s.Courses).Where(s => s.Id == 2).FirstOrDefault();
Course? course = context.Courses.Include(c => c.Students).Where(c => c.Id == 1).FirstOrDefault();
student?.Courses.Remove(course);
// course.Students.Remove(student);
context.SaveChanges();*/

/*Student? student = new Student { Name = "David" };
Course? course = context.Courses.Include(c => c.Students).Where(c => c.Id == 2).FirstOrDefault();
course?.Students.Add(student);
context.SaveChanges();*/

/*Student? student = context.Students.Include(s => s.Courses).Where(s => s.Id == 4).FirstOrDefault();
Course? course = context.Courses.Include(c => c.Students).Where(c => c.Id == 1).FirstOrDefault();
course?.Students.Add(student);
context.SaveChanges();*/