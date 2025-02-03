/*
 
    Remove Invalid Parentheses
    Problem: Remove the minimum number of invalid parentheses to make the string valid.

    Example:
    Input: "(()))"
    Output: "()" or "(())"

    Key Points:

    Use a stack to track mismatched parentheses. 
 
*/


class Program
{
    static void Main()
    {

        string S = "(()))";

        Console.WriteLine(RemoveInvalidParentheses(S));

    }

    static string RemoveInvalidParentheses(string S)
    {
        Stack<int> Stack = new Stack<int>();
        HashSet<int> InvalidIndices = new HashSet<int>();

        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == '(')
            {
                Stack.Push(i);
            }
            else if (S[i] == ')')
            {
                if (Stack.Count == 0)
                {
                    InvalidIndices.Add(i);
                }
                else
                {
                    Stack.Pop();
                }
            }
        }

        while (Stack.Count > 0)
        {
            InvalidIndices.Add(Stack.Pop());
        }

        char[] result = new char[S.Length - InvalidIndices.Count];
        int index = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (!InvalidIndices.Contains(i))
            {
                result[index++] = S[i];
            }
        }

        return new string(result);

    }






}
