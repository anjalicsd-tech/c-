using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Stock");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    ViewProducts();
                    break;
                case 3:
                    UpdateStock();
                    break;
                case 4:
                    DeleteProduct();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter Product ID: ");
        p.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        p.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        p.Price = double.Parse(Console.ReadLine());

        products.Add(p);

        Console.WriteLine("Product added successfully!");
    }

    static void ViewProducts()
    {
        Console.WriteLine("\nProduct List:");
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Qty: {p.Quantity}, Price: {p.Price}");
        }
    }

    static void UpdateStock()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var product = products.Find(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Enter New Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Stock updated successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    static void DeleteProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        var product = products.Find(p => p.Id == id);

        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }
}