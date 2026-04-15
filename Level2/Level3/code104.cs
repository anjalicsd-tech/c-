using System;

// Base class (Parent)
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class (Child)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();

        // Calling parent class method
        d.Eat();

        // Calling child class method
        d.Bark();
    }
}