// Convert Decimal to Binary

class Program
{

    static void Main()
    {

        Console.WriteLine("Enter a Number:");
        int Number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("________________________________________");
        Console.WriteLine("First Way:");
        Console.WriteLine($"Converting Number {Number} From Decimal to Binary");
        Console.WriteLine($"Number {Number} in Binary: " + DecimalToBinary(Number));

        Console.WriteLine("________________________________________");
        Console.WriteLine("Second Way:");
        Console.WriteLine($"Converting Number {Number} From Decimal to Binary");
        Console.WriteLine($"Number {Number} in Binary: " + DecimalToBinary2(Number));

    }

    static int DecimalToBinary(int Number)
    {

        int Result = 0, Power = 1;

        while (Number != 0)
        {

            Result += Number % 2 * Power;
            Number = Number / 2;
            Power *= 10;

        }

        return Result;

    }

    static string DecimalToBinary2(int Number)
    {
        Stack<int> stack = new Stack<int>();

        while (Number > 0)
        {
            stack.Push(Number % 2);
            Number /= 2;
        }

        return string.Join("", stack);
    }

}
