using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static string filePath = "students.txt";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- File-Based CRUD System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
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
                    UpdateStudent();
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

    // 🔹 Add
    static void AddStudent()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        File.AppendAllText(filePath, id + "," + name + Environment.NewLine);

        Console.WriteLine("Student added successfully!");
    }

    // 🔹 View
    static void ViewStudents()
    {
        Console.WriteLine("\nStudent List:");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("No data found!");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            string[] data = line.Split(',');
            Console.WriteLine("ID: " + data[0] + ", Name: " + data[1]);
        }
    }

    // 🔹 Update
    static void UpdateStudent()
    {
        Console.Write("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());

        var lines = File.ReadAllLines(filePath).ToList();
        bool found = false;

        for (int i = 0; i < lines.Count; i++)
        {
            string[] data = lines[i].Split(',');

            if (int.Parse(data[0]) == id)
            {
                Console.Write("Enter New Name: ");
                string newName = Console.ReadLine();

                lines[i] = id + "," + newName;
                found = true;
            }
        }

        File.WriteAllLines(filePath, lines);

        Console.WriteLine(found ? "Updated successfully!" : "Student not found!");
    }

    // 🔹 Delete
    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        var lines = File.ReadAllLines(filePath).ToList();
        bool found = false;

        lines.RemoveAll(line =>
        {
            string[] data = line.Split(',');
            if (int.Parse(data[0]) == id)
            {
                found = true;
                return true;
            }
            return false;
        });

        File.WriteAllLines(filePath, lines);

        Console.WriteLine(found ? "Deleted successfully!" : "Student not found!");
    }
}