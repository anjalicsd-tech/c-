using System;

class Student
{
    string name;
    int age;

    // Constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }

    // Method to display data
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object and calling constructor
        Student s1 = new Student("Divya", 20);

        s1.Display();
    }
}