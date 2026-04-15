using System;

class Student
{
    // Private data (hidden)
    private string name;
    private int age;

    // Public methods to access data (getter & setter)
    public void SetData(string n, int a)
    {
        name = n;
        age = a;
    }

    public void GetData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        s.SetData("Divya", 20);
        s.GetData();
    }
}