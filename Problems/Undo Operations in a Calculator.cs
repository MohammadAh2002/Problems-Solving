// Implement undo functionality in a calculator.

class Program
{
    static void Main()
    {

        clsCalculator Calculator = new clsCalculator();

        Console.WriteLine("Add 25: ");
        Calculator.Add(25);
        Console.WriteLine("Current Result After Adding 5: " + Calculator.CurrentResult);

        Console.WriteLine("\nSubtract 5: ");
        Calculator.Subtract(5);
        Console.WriteLine("Current Result After Subtract 5: " + Calculator.CurrentResult);

        Console.WriteLine("\nCancel Last Operation");
        Calculator.CnacelLastOperation();
        Console.WriteLine("Current Result Canceling Last Operation: " + Calculator.CurrentResult);

        Console.WriteLine("\nCancel Last Operation");
        Calculator.CnacelLastOperation();
        Console.WriteLine("Current Result Canceling Last Operation: " + Calculator.CurrentResult);

        Console.WriteLine("\nAdding 5: ");
        Calculator.Add(5);
        Console.WriteLine("Current Result After Adding 5: " + Calculator.CurrentResult);

        Console.WriteLine("\nMultiply by 5: ");
        Calculator.Multiply(5);
        Console.WriteLine("Current Result After Multiplying by 5: " + Calculator.CurrentResult);

        Console.WriteLine("\nDivide by 5: ");
        Calculator.Divide(5);
        Console.WriteLine("Current Result After Dividing 5: " + Calculator.CurrentResult);

        Console.WriteLine("\nCancel Last Operation");
        Calculator.CnacelLastOperation();
        Console.WriteLine("Current Result Canceling Last Operation: " + Calculator.CurrentResult);
    }
}

public class clsCalculator
{

    public int CurrentResult = 0;
    Stack<int> _Results = new Stack<int>();

    private bool IsZero(int num)
    {

        return num == 0;

    }

    public void Add(int num)
    {

        _Results.Push(CurrentResult);
        CurrentResult += num;

    }

    public void Subtract(int num)
    {

        _Results.Push(CurrentResult);
        CurrentResult -= num;

    }

    public void Divide(int num)
    {

        if (IsZero(num))
            num = 1;

        _Results.Push(CurrentResult);
        CurrentResult /= num;

    }

    public void Multiply(int num)
    {

        _Results.Push(CurrentResult);
        CurrentResult *= num;

    }

    public void CnacelLastOperation()
    {

        CurrentResult = _Results.Pop();

    }

    public void Clear()
    {

        CurrentResult = 0;
        _Results.Clear();

    }

};
