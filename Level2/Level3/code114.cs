using System;

// Sealed class
sealed class Animal
{
    public void Show()
    {
        Console.WriteLine("This is a sealed class");
    }
}

// ❌ This will give error if uncommented
// class Dog : Animal
// {
// }

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        a.Show();
    }
}