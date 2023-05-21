
/// ==============================
/// First C# console application
/// ==============================
internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            int x = GetNumber("Insert first number: ");
            int y = GetNumber("Insert second number: ");

            Console.WriteLine("Please, choose the command: +, -, *, /, min, max");
            string cmd = Console.ReadLine();

            int result = GetResult(x, y, cmd);
            Console.WriteLine(result);

        } while (AskContinue());
    }

    private static bool AskContinue()
    {
        while (true)
        {
            Console.WriteLine("Do you want to continue? Y/N");
            var status = Console.ReadLine();
            if (status == "Y" || status == "y")
                return true;
            else if (status == "N" || status == "n")
                return false;
            else
                Console.WriteLine("Operation is not correct. Insert Y or N");
        }
    }

    private static int GetResult(int x, int y, string cmd)
    {
        int result;
        switch (cmd)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x * y;
                break;
            case "/":
                result = x / y;
                break;
            case "max":
                result = GetMax(x, y);
                break;
            case "min":
                result = GetMin(x, y);
                break;
            default:
                result = 0;
                break;
        }

        return result;
    }

    private static int GetNumber(string text)
    {
        Console.WriteLine(text);

        while (true)
        {
            string str = Console.ReadLine();
            int result;

            // Check if user input is correct
            if (Int32.TryParse(str, out result))
                return result;
            else
                Console.WriteLine("Wrong format. Try again.");
        }


    }

    // Max value: x or y
    static int GetMax(int a, int b)
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

    // Min value: x or y
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
