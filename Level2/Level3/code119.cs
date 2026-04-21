using System;

// SRP: Invoice only handles calculation
class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating total...");
    }
}

// ISP + DIP: Interface for printing
interface IPrinter
{
    void Print();
}

class InvoicePrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing invoice...");
    }
}

// DIP: depends on abstraction, not concrete class
class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice();
        invoice.CalculateTotal();

        IPrinter printer = new InvoicePrinter();
        printer.Print();
    }
}