using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    SearchStudent();
                    break;
                case 4:
                    DeleteStudent();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = int.Parse(Console.ReadLine());

        students.Add(s);

        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\nStudent List:");
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter ID to search: ");
        int id = int.Parse(Console.ReadLine());

        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            Console.WriteLine($"Found: {student.Name}, Marks: {student.Marks}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student deleted!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }
}