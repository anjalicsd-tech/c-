using System;

class Demo
{
    public int a = 10;        // Accessible everywhere
    private int b = 20;       // Accessible only within same class
    protected int c = 30;     // Accessible in same class + derived class
    internal int d = 40;      // Accessible within same assembly

    public void Show()
    {
        Console.WriteLine("Private b: " + b); // allowed (same class)
    }
}

// Derived class
class Test : Demo
{
    public void Display()
    {
        Console.WriteLine("Protected c: " + c); // allowed
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();

        Console.WriteLine("Public a: " + obj.a);

        // Console.WriteLine(obj.b); ❌ Error (private)
        // Console.WriteLine(obj.c); ❌ Error (protected)

        Console.WriteLine("Internal d: " + obj.d);

        obj.Show();

        Test t = new Test();
        t.Display();
    }
}