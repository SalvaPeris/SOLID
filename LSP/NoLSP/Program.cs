using NoLSP;

internal class Program
{
    private static void Main(string[] args)
    {
        Apple apple = new Orange();
        Console.WriteLine(apple.GetColor());
    }
}