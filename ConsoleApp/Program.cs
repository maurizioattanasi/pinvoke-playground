using System.Runtime.InteropServices;

internal class Program
{
    [DllImport("libnative")]
    public static extern void Greet();

    [DllImport("libnative", EntryPoint = "Add")]
    public static extern int AddNumbers(int a, int b);

    [DllImport("libnative")]
    public static extern bool IsLengthGreaterThan(string value, int len);

    [DllImport("libnative")]
    public static extern IntPtr GetName();

    private static void Main(string[] args)
    {
        Greet();

        int a = 2, b = 5;
        Console.WriteLine($"{a} + {b} = {AddNumbers(a, b)}");

        Console.WriteLine($"{IsLengthGreaterThan("Test1", 5)}");

        var ptr = GetName();

        string str = Marshal.PtrToStringAuto(ptr) ?? "Error";

        Console.WriteLine(str);
    }
}