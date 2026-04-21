using System;
using System.Text.Json;

// Class to serialize
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create object
        Student s = new Student { Id = 1, Name = "Divya" };

        // 🔹 Serialization (Object → JSON)
        string jsonString = JsonSerializer.Serialize(s);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonString);

        // 🔹 Deserialization (JSON → Object)
        Student newStudent = JsonSerializer.Deserialize<Student>(jsonString);

        Console.WriteLine("\nDeserialized Object:");
        Console.WriteLine("Id: " + newStudent.Id);
        Console.WriteLine("Name: " + newStudent.Name);
    }
}