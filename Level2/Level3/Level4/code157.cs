using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    // 🔹 Change connection string as per your SQL Server
    static string connectionString = "Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- ADO.NET CRUD ---");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Insert();
                    break;
                case 2:
                    Read();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Delete();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    // 🔹 INSERT
    static void Insert()
    {
        SqlConnection con = new SqlConnection(connectionString);

        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        int marks = int.Parse(Console.ReadLine());

        string query = "INSERT INTO Student VALUES (@Id, @Name, @Marks)";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Marks", marks);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Console.WriteLine("Record Inserted!");
    }

    // 🔹 READ
    static void Read()
    {
        SqlConnection con = new SqlConnection(connectionString);

        string query = "SELECT * FROM Student";

        SqlCommand cmd = new SqlCommand(query, con);

        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\nStudent List:");
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Marks: {reader["Marks"]}");
        }

        con.Close();
    }

    // 🔹 UPDATE
    static void Update()
    {
        SqlConnection con = new SqlConnection(connectionString);

        Console.Write("Enter Id to update: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter New Marks: ");
        int marks = int.Parse(Console.ReadLine());

        string query = "UPDATE Student SET Marks=@Marks WHERE Id=@Id";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Marks", marks);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Console.WriteLine("Record Updated!");
    }

    // 🔹 DELETE
    static void Delete()
    {
        SqlConnection con = new SqlConnection(connectionString);

        Console.Write("Enter Id to delete: ");
        int id = int.Parse(Console.ReadLine());

        string query = "DELETE FROM Student WHERE Id=@Id";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Console.WriteLine("Record Deleted!");
    }
}