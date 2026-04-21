using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; } // Admin / User
}

class Program
{
    static List<User> users = new List<User>()
    {
        new User { Username = "admin", Password = "123", Role = "Admin" },
        new User { Username = "user1", Password = "111", Role = "User" }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("--- LOGIN SYSTEM ---");

        Console.Write("Enter Username: ");
        string uname = Console.ReadLine();

        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        var user = users.Find(u => u.Username == uname && u.Password == pass);

        if (user != null)
        {
            Console.WriteLine("\nLogin Successful!");

            Console.WriteLine("Role: " + user.Role);

            if (user.Role == "Admin")
            {
                AdminPanel();
            }
            else if (user.Role == "User")
            {
                UserPanel();
            }
        }
        else
        {
            Console.WriteLine("Invalid Credentials!");
        }
    }

    // 🔹 Admin Features
    static void AdminPanel()
    {
        Console.WriteLine("\n--- ADMIN PANEL ---");
        Console.WriteLine("1. View All Users");
        Console.WriteLine("2. Add New User (Demo)");
        Console.WriteLine("Admin has full access.");
    }

    // 🔹 User Features
    static void UserPanel()
    {
        Console.WriteLine("\n--- USER PANEL ---");
        Console.WriteLine("1. View Profile");
        Console.WriteLine("2. Update Password (Demo)");
        Console.WriteLine("User has limited access.");
    }
}