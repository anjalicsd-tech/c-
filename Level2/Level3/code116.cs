using System;

// Base class
class Animal
{
    // Virtual method
    public virtual void Show()
    {
        Console.WriteLine("This is Animal class method");
    }
}

// Derived class
class Dog : Animal
{
    // Overriding the base class method
    public override void Show()
    {
        Console.WriteLine("This is Dog class method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Dog();  // Parent reference, child object

        a.Show();  // Calls overridden method
    }
}