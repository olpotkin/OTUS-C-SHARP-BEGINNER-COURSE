
/// ==============================
/// First C# console application
/// ==============================
internal class Program
{
    private static void Main(string[] args)
    {
        int x = GetNumber("Insert first number: ");
        int y = GetNumber("Insert second number: ");

        // Subtraction
        Console.WriteLine($"Subtraction result: {x - y}");
        // Addition
        Console.WriteLine($"Addition result: {x + y}");
        // Multiplication
        Console.WriteLine($"Multiplication result: {x * y}");
        // Division
        Console.WriteLine($"Division result: {x / y}");


        // Max value: x or y
        int max = GetMax(x, y);
        Console.WriteLine($"Maximum of two values is: {max}");

        // Min value: x or y
        int min = GetMin(x, y);
        Console.WriteLine($"Minimum of two values is: {min}");

    }


    private static int GetNumber(string text)
    {
        Console.WriteLine(text);
        string str = Console.ReadLine();

        return int.Parse(str);
    }


    static int GetMax (int a, int b)
    {
        int max = 0;
        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }

        return max;
    }


    static int GetMin(int a, int b)
    {
        int min = 0;
        if (a < b)
            min = a;
        else
            min = b;

        return min;
    }

}
