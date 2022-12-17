using ConsoleApp37;

internal class Program
{
    private static void Main(string[] args)
    {
        InsulatedWire wire = new(5, 5, 5, 5, 5);
        Console.WriteLine(wire.ToString());
    }
}