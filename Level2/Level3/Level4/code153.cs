using System;
using System.Collections.Generic;

class Account
{
    public int AccountNo { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
}

class Program
{
    static List<Account> accounts = new List<Account>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Banking System ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. View Accounts");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    ViewAccounts();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    Withdraw();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Account a = new Account();

        Console.Write("Enter Account No: ");
        a.AccountNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        a.Name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        a.Balance = double.Parse(Console.ReadLine());

        accounts.Add(a);

        Console.WriteLine("Account created successfully!");
    }

    static void ViewAccounts()
    {
        Console.WriteLine("\nAccount List:");
        foreach (var a in accounts)
        {
            Console.WriteLine($"A/C No: {a.AccountNo}, Name: {a.Name}, Balance: {a.Balance}");
        }
    }

    static void Deposit()
    {
        Console.Write("Enter Account No: ");
        int accNo = int.Parse(Console.ReadLine());

        var acc = accounts.Find(a => a.AccountNo == accNo);

        if (acc != null)
        {
            Console.Write("Enter Deposit Amount: ");
            double amount = double.Parse(Console.ReadLine());

            acc.Balance += amount;

            Console.WriteLine("Amount Deposited Successfully!");
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter Account No: ");
        int accNo = int.Parse(Console.ReadLine());

        var acc = accounts.Find(a => a.AccountNo == accNo);

        if (acc != null)
        {
            Console.Write("Enter Withdraw Amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= acc.Balance)
            {
                acc.Balance -= amount;
                Console.WriteLine("Amount Withdrawn Successfully!");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }
}