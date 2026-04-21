using System;
using System.Reflection;

// Sample class
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Show()
    {
        Console.WriteLine("Student method called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get type information
        Type t = typeof(Student);

        Console.WriteLine("Class Name: " + t.Name);

        // Get properties
        Console.WriteLine("\nProperties:");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        // Get methods
        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        // Create object using reflection
        object obj = Activator.CreateInstance(t);

        // Call method using reflection
        MethodInfo m = t.GetMethod("Show");
        m.Invoke(obj, null);
    }
}