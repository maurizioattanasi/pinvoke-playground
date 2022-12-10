using System.Runtime.InteropServices;

internal class Program
{
    [DllImport("libnative.dylib")]
    public static extern void Greet();

    private static void Main(string[] args)
    {
        Greet();

        Console.WriteLine("Hello, World!");
    }
}