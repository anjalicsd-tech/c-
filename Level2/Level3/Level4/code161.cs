using System;
using Serilog;

class Program
{
    static void Main(string[] args)
    {
        // 🔹 Configure Serilog
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Information("Application Started");

        try
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;

            Console.WriteLine("Result: " + result);

            Log.Information("Division successful. Result = {Result}", result);
        }
        catch (DivideByZeroException ex)
        {
            Log.Error("Error: Division by zero attempted. {Message}", ex.Message);
        }
        catch (Exception ex)
        {
            Log.Error("General error occurred: {Message}", ex.Message);
        }
        finally
        {
            Log.Information("Application Ended");
            Log.CloseAndFlush();
        }
    }
}