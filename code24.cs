using System;

class Program
{
    static void Main()
    {
        double length, breadth, area;

        Console.Write("Enter length: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth: ");
        breadth = Convert.ToDouble(Console.ReadLine());

        area = length * breadth;

        Console.WriteLine("Area of Rectangle = " + area);
    }
}