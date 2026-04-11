using System;

class Program
{
    static void Main()
    {
        // Creating a tuple
        var student = (Id: 1, Name: "Anjali", Marks: 85);

        // Accessing values
        Console.WriteLine("ID = " + student.Id);
        Console.WriteLine("Name = " + student.Name);
        Console.WriteLine("Marks = " + student.Marks);

        // Another tuple
        var data = (10, "Hello", 5.5);
        Console.WriteLine("\nValues:");
        Console.WriteLine(data.Item1);
        Console.WriteLine(data.Item2);
        Console.WriteLine(data.Item3);
    }
}