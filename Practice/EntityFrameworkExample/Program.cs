// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample;
using EntityFrameworkExample.Entities;

TrainingDbContext context = new TrainingDbContext();

//Insert Code
//Course course = new Course();
//course.Title = "C#";
//course.Fees = 8000;
//course.ClassStartDate = DateTime.Now;

//Course course2 = new Course { Title = "Asp.net", Fees = 6000, ClassStartDate = DateTime.Now };

//context.Add(course);
//context.Add(course2);

//context.SaveChanges();

//Get all items
//List<Course> courses = context.Courses.ToList();

//update object
//Course c1 = context.Courses.Where( x => x.Title == "C#.Net").FirstOrDefault();
//c1.Title = "C# DOT NET";
//c1.Fees = 12000;

//context.SaveChanges();

//remove object
Course c1 = context.Courses.Where(x => x.Title == "C# DOT NET").FirstOrDefault();
context.Courses.Remove(c1);
context.SaveChanges();
