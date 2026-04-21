using System;
using Microsoft.Extensions.DependencyInjection;

// Interface
public interface IMessageService
{
    void SendMessage(string message);
}

// Implementation
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Email Sent: " + message);
    }
}

// Consumer
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify()
    {
        _messageService.SendMessage("Hello from Dependency Injection!");
    }
}

// Program
class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IMessageService, EmailService>()
            .AddTransient<Notification>()
            .BuildServiceProvider();

        var notification = serviceProvider.GetService<Notification>();
        notification.Notify();
    }
}