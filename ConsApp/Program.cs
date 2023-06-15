namespace cons_app;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsEven(2));
    }

    public static bool IsEven(int x) => x % 2 == 0;
}