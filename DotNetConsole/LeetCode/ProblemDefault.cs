namespace HelloWorld;

public class ProblemDefault
{
    public static void SayHello()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Welcome, {name}!");
    }
}