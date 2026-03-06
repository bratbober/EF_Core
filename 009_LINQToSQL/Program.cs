using _009_LINQToSQL;
using Microsoft.EntityFrameworkCore;

using (ApplicationDbContext db = new ApplicationDbContext())
{
    var groups = db.Users.GroupBy(u => u.Company!.Name);

    foreach (var group in groups)
    {
        Console.WriteLine($"Group Name:  {group.Key}");
        foreach(var user in group)
        {
            Console.WriteLine($"User Name: {user.Name}");
        }
    }

}


