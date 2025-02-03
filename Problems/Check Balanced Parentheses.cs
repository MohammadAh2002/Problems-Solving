/*

    Check Balanced Parentheses
    Problem: Check if a given string has balanced parentheses.

    Input: "({[]})" or "({[)]}"
    Output: true for "({[]})" and false for "({[)]}"
    
    Key Idea:
        Use a stack to keep track of opening brackets and ensure they are closed in the correct order. 

*/

class Program
{
    static void Main()
    {
        string Parenthese1 = "({[]})";

        if (IsBalancedParentheses(Parenthese1))
            Console.WriteLine("Yes Parentheses 1 is Balanced");
        else
            Console.WriteLine("No Parentheses 1 is not Balanced");

        string Parenthese2 = "({[)]}";

        if (IsBalancedParentheses(Parenthese2))
            Console.WriteLine("Yes Parentheses 2 is Balanced");
        else
            Console.WriteLine("No Parentheses 2 is not Balanced");
    }

    public static bool IsBalancedParentheses(string Parentheses)
    {

        Stack<char> Stack = new Stack<char>();

        foreach (char Parenthese in Parentheses)
        {

            if (Parenthese == '(' || Parenthese == '[' || Parenthese == '{')
                Stack.Push(Parenthese);

            else if (Parenthese == ')' || Parenthese == ']' || Parenthese == '}')
            {

                if (Stack.Count == 0 || Stack.Pop() != OpenParentheses(Parenthese))
                    return false;

            }

        }

        return true;

    }

    public static char OpenParentheses(char C)
    {

        // You Give the Method the Close Parentheses and it's Give You Back the Open Parentheses for it.

        switch (C)
        {

            case '}':
                return '{';

            case ']':
                return '[';

            default:
                return '(';

        }

    }

}
