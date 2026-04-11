using System;

// struct declaration
struct Student
{
    public int id;
    public string name;

    public void display()
    {
        Console.WriteLine("ID = " + id);
        Console.WriteLine("Name = " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s;

        s.id = 1;
        s.name = "Anjali";

        s.display();
    }
}