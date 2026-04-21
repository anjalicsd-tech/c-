using System;

// Base class
class Person
{
    public string Name { get; set; }
}

// Derived class
class Student : Person
{
}

// Generic class with constraint
class GenericClass<T> where T : Person
{
    public void Show(T obj)
    {
        Console.WriteLine("Name: " + obj.Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student { Name = "Divya" };

        GenericClass<Student> obj = new GenericClass<Student>();
        obj.Show(s);

        // ❌ Error if used with other type like int
        // GenericClass<int> obj2 = new GenericClass<int>();
    }
}