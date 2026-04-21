using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public double HRA { get; set; }
    public double DA { get; set; }
    public double GrossSalary { get; set; }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Employee Payroll System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Calculate Salary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    ViewEmployees();
                    break;
                case 3:
                    CalculateSalary();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddEmployee()
    {
        Employee e = new Employee();

        Console.Write("Enter ID: ");
        e.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        e.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        e.BasicSalary = double.Parse(Console.ReadLine());

        employees.Add(e);

        Console.WriteLine("Employee added successfully!");
    }

    static void ViewEmployees()
    {
        Console.WriteLine("\nEmployee List:");
        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Basic Salary: {e.BasicSalary}");
        }
    }

    static void CalculateSalary()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        var emp = employees.Find(e => e.Id == id);

        if (emp != null)
        {
            emp.HRA = emp.BasicSalary * 0.20;
            emp.DA = emp.BasicSalary * 0.10;
            emp.GrossSalary = emp.BasicSalary + emp.HRA + emp.DA;

            Console.WriteLine("\nSalary Details:");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Basic Salary: {emp.BasicSalary}");
            Console.WriteLine($"HRA: {emp.HRA}");
            Console.WriteLine($"DA: {emp.DA}");
            Console.WriteLine($"Gross Salary: {emp.GrossSalary}");
        }
        else
        {
            Console.WriteLine("Employee not found!");
        }
    }
}