using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

#region Model
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}
#endregion

#region DbContext
public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Trusted_Connection=True;");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- EF Core CRUD SYSTEM ---");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Insert();
                    break;
                case 2:
                    View();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Delete();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    // 🔹 INSERT
    static void Insert()
    {
        using (var db = new AppDbContext())
        {
            Student s = new Student();

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Marks: ");
            s.Marks = int.Parse(Console.ReadLine());

            db.Students.Add(s);
            db.SaveChanges();

            Console.WriteLine("Student Inserted!");
        }
    }

    // 🔹 READ
    static void View()
    {
        using (var db = new AppDbContext())
        {
            var list = db.Students.ToList();

            Console.WriteLine("\nStudent List:");
            foreach (var s in list)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }
    }

    // 🔹 UPDATE
    static void Update()
    {
        using (var db = new AppDbContext())
        {
            Console.Write("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());

            var student = db.Students.Find(id);

            if (student != null)
            {
                Console.Write("Enter New Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Enter New Marks: ");
                student.Marks = int.Parse(Console.ReadLine());

                db.SaveChanges();

                Console.WriteLine("Student Updated!");
            }
            else
            {
                Console.WriteLine("Student Not Found!");
            }
        }
    }

    // 🔹 DELETE
    static void Delete()
    {
        using (var db = new AppDbContext())
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            var student = db.Students.Find(id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();

                Console.WriteLine("Student Deleted!");
            }
            else
            {
                Console.WriteLine("Student Not Found!");
            }
        }
    }
}