using System;

// First interface
interface IPrinter
{
    void Print();
}

// Second interface
interface IScanner
{
    void Scan();
}

// Class implementing multiple interfaces
class Machine : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Machine m = new Machine();

        m.Print();
        m.Scan();
    }
}
