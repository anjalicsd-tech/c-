using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Divya", City = "Mumbai" },
            new Student { Name = "Rahul", City = "Pune" },
            new Student { Name = "Amit", City = "Mumbai" },
            new Student { Name = "Sneha", City = "Pune" },
            new Student { Name = "Kiran", City = "Delhi" }
        };

        // Grouping by City
        var groupedData = students.GroupBy(s => s.City);

        foreach (var group in groupedData)
        {
            Console.WriteLine("City: " + group.Key);

            foreach (var student in group)
            {
                Console.WriteLine("  Name: " + student.Name);
            }
        }
    }
}