/*

    Check palindrome using a stack 
    Problem:
    Check if a given string is a palindrome using a stack.

    Input: "madam"
    Output: true

    Input: "hello"
    Output: false 

*/

class Program
{
    static void Main()
    {
        string S1 = "madam";

        if (IsPalindrome(S1))
            Console.WriteLine("Yes String 1 is Palindrome");
        else
            Console.WriteLine("No String 1 is not Palindrome");

        string S2 = "hello";

        if (IsPalindrome(S2))
            Console.WriteLine("Yes String 2 is Palindrome");
        else
            Console.WriteLine("No String 2 is not Palindrome");
    }

    public static bool IsPalindrome(string S)
    {

        Stack<char> Stack = new Stack<char>(S);

        for (int i = 0; i < S.Length; i++)
        {

            if (S[i] != Stack.Pop())
                return false;

        }

        return true;

    }
}
