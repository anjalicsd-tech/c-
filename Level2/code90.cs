using System;

class Student
{
    private string[] names = new string[5];

    // Indexer
    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Using indexer to store values
        s[0] = "Anjali";
        s[1] = "Rahul";
        s[2] = "Priya";

        // Using indexer to retrieve values
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);
    }
}