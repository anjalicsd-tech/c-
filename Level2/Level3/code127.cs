using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        // Push elements
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack elements:");

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Pop element
        Console.WriteLine("Popped: " + stack.Pop());
    }
}