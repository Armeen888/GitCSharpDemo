namespace GitCSharpDemo.Core;

public static class Program
{
    public static int Main(string[] args)
    {
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}!");
        return 0;
    }
}