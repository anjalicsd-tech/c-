using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Course
{
    public int StudentId { get; set; }
    public string CourseName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Divya" },
            new Student { Id = 2, Name = "Rahul" },
            new Student { Id = 3, Name = "Amit" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { StudentId = 1, CourseName = "C#" },
            new Course { StudentId = 2, CourseName = "Java" },
            new Course { StudentId = 1, CourseName = "SQL" }
        };

        // LINQ Join
        var result = students.Join(
            courses,
            s => s.Id,            // outer key
            c => c.StudentId,     // inner key
            (s, c) => new
            {
                s.Name,
                c.CourseName
            });

        Console.WriteLine("Student Courses:");

        foreach (var item in result)
        {
            Console.WriteLine(item.Name + " - " + item.CourseName);
        }
    }
}