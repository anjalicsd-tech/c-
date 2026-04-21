using System;

// Generic class
class GenericClass<T>
{
    private T data;

    public void Add(T value)
    {
        data = value;
    }

    public void Display()
    {
        Console.WriteLine("Data: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Generic with int
        GenericClass<int> obj1 = new GenericClass<int>();
        obj1.Add(10);
        obj1.Display();

        // Using Generic with string
        GenericClass<string> obj2 = new GenericClass<string>();
        obj2.Add("Hello");
        obj2.Display();
    }
}