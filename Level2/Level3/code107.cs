using System;

// Abstract class
abstract class Animal
{
    // Abstract method (no body)
    public abstract void Sound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

// Derived class
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Dog();

        a.Sound();   // Calls abstract method
        a.Sleep();   // Calls normal method
    }
}