using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
}

class Sale
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static List<Employee> employees = new List<Employee>();
    static List<Product> products = new List<Product>();
    static List<Sale> sales = new List<Sale>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MINI ERP SYSTEM ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Product");
            Console.WriteLine("3. View Employees");
            Console.WriteLine("4. View Products");
            Console.WriteLine("5. Sell Product");
            Console.WriteLine("6. View Sales Report");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddEmployee(); break;
                case 2: AddProduct(); break;
                case 3: ViewEmployees(); break;
                case 4: ViewProducts(); break;
                case 5: SellProduct(); break;
                case 6: SalesReport(); break;
                case 7: return;
                default: Console.WriteLine("Invalid Choice!"); break;
            }
        }
    }

    // 🔹 EMPLOYEE
    static void AddEmployee()
    {
        Employee e = new Employee();

        Console.Write("Enter ID: ");
        e.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        e.Name = Console.ReadLine();

        Console.Write("Enter Department: ");
        e.Department = Console.ReadLine();

        employees.Add(e);

        Console.WriteLine("Employee Added!");
    }

    static void ViewEmployees()
    {
        Console.WriteLine("\nEmployees:");
        foreach (var e in employees)
        {
            Console.WriteLine($"{e.Id} - {e.Name} - {e.Department}");
        }
    }

    // 🔹 PRODUCT
    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter ID: ");
        p.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Stock: ");
        p.Stock = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        p.Price = double.Parse(Console.ReadLine());

        products.Add(p);

        Console.WriteLine("Product Added!");
    }

    static void ViewProducts()
    {
        Console.WriteLine("\nProducts:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - Stock: {p.Stock} - Price: {p.Price}");
        }
    }

    // 🔹 SALE
    static void SellProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var product = products.Find(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Enter Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            if (qty <= product.Stock)
            {
                product.Stock -= qty;

                sales.Add(new Sale { ProductId = id, Quantity = qty });

                Console.WriteLine("Product Sold!");
            }
            else
            {
                Console.WriteLine("Insufficient Stock!");
            }
        }
        else
        {
            Console.WriteLine("Product Not Found!");
        }
    }

    // 🔹 SALES REPORT
    static void SalesReport()
    {
        Console.WriteLine("\nSales Report:");

        var report = sales.GroupBy(s => s.ProductId);

        foreach (var item in report)
        {
            var product = products.Find(p => p.Id == item.Key);

            int totalQty = item.Sum(x => x.Quantity);

            Console.WriteLine($"{product?.Name} - Total Sold: {totalQty}");
        }
    }
}