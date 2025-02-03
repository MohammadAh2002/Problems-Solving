/*
 
    Basic Calculator
    Problem: Evaluate a mathematical expression containing +, -, (, ) without * or /.

    Example:
    Input: "1 + (2 - 3)"
    Output: 0

    Key Points:
    Use a stack to handle parentheses and maintain the current sum.

*/

class Program
{
    static void Main()
    {
        string S = "1 + (2 - 3)";

        Console.WriteLine(Calculate(S));
    }

    static int Calculate(string s)
    {

        Stack<int> Stack = new Stack<int>();
        int Result = 0, Sign = 1, Number = 0;


        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                Number = Number * 10 + (c - '0');
            }
            else if (c == '+')
            {
                Result += Sign * Number;
                Number = 0;
                Sign = 1;
            }
            else if (c == '-')
            {
                Result += Sign * Number;
                Number = 0;
                Sign = -1;
            }
            else if (c == '(')
            {
                Stack.Push(Result);
                Stack.Push(Sign);
                Result = 0;
                Sign = 1;
            }
            else if (c == ')')
            {
                Result += Sign * Number;
                Number = 0;
                Result *= Stack.Pop();
                Result += Stack.Pop();
            }
        }

        Result += Sign * Number;
        return Result;

    }
}
