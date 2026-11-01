namespace GitCSharpDemo.Core;

public static class Program
{
    public static int Main(string[] args)
    {
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Guest";
        }

        Console.WriteLine($"Hello, {name}!");


        return 0;
    }
}