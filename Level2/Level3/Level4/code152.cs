using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    ViewBooks();
                    break;
                case 3:
                    SearchBook();
                    break;
                case 4:
                    DeleteBook();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book ID: ");
        b.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Book Title: ");
        b.Title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        b.Author = Console.ReadLine();

        books.Add(b);

        Console.WriteLine("Book added successfully!");
    }

    static void ViewBooks()
    {
        Console.WriteLine("\nBook List:");
        foreach (var b in books)
        {
            Console.WriteLine($"ID: {b.Id}, Title: {b.Title}, Author: {b.Author}");
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter Book ID to search: ");
        int id = int.Parse(Console.ReadLine());

        var book = books.Find(b => b.Id == id);

        if (book != null)
        {
            Console.WriteLine($"Found: {book.Title} by {book.Author}");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        var book = books.Find(b => b.Id == id);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book deleted successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
}