using System;

// Custom Attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class MyAttribute : Attribute
{
    public string Message;

    public MyAttribute(string message)
    {
        Message = message;
    }
}

// Using Attribute
[MyAttribute("This is a sample class")]
class Demo
{
    [MyAttribute("This is a sample method")]
    public void Show()
    {
        Console.WriteLine("Method executed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Type t = typeof(Demo);

        // Reading class attribute
        object[] classAttrs = t.GetCustomAttributes(false);
        foreach (MyAttribute attr in classAttrs)
        {
            Console.WriteLine("Class Attribute: " + attr.Message);
        }

        // Reading method attribute
        var method = t.GetMethod("Show");
        object[] methodAttrs = method.GetCustomAttributes(false);

        foreach (MyAttribute attr in methodAttrs)
        {
            Console.WriteLine("Method Attribute: " + attr.Message);
        }

        // Call method
        Demo d = new Demo();
        d.Show();
    }
}