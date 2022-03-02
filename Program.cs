namespace hello_world_git;

internal static class Program
{
    private static void Main(string[] args)
    {
        if (args.Length >= 1)
        {
            var name = args[0];
            Console.WriteLine($"Hello, {name}!");
        }
        else
        {
            Console.WriteLine("Hello, World!");
        }
    }
}