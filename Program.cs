using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Module4HW3;
using Module4HW3.Models;

var connectionString = new ConfigurationBuilder()
    .AddJsonFile(Path.GetFullPath("..\\..\\..\\config.json"))
    .Build()["DBConnectionString"];
var applicationContextOptions = new DbContextOptionsBuilder<ApplicationContext>().UseSqlServer(connectionString).Options;

/*
using var db = new ApplicationContext(applicationContextOptions);

var a = new Title { Name = "Senior" };
var b = new Title { Name = "Junior" };

db.Titles.Add(a);
db.Titles.Add(b);
db.SaveChanges();

foreach (var title in db.Titles.ToList())
{
    Console.WriteLine($"{title.TitleId} {title.Name}");
}
*/