/*

    Reverse a String
    Problem: Reverse a given string using a stack.

    Input: "hello"
    Output: "olleh"
    
    Key Idea:
        Push each character onto the stack, then pop them off to get the reversed string.

*/


class Program
{
    static void Main()
    {

        string S = "Mohammad Ahmad";

        Console.WriteLine("Reversed String: " + ReverseString(S));

    }

    static public string ReverseString(string S)
    {

        Stack<char> Stack = new Stack<char>();

        foreach (char C in S) { 
        
            Stack.Push(C);

        }

        S = "";

        while (Stack.Count > 0)
        {
            S += Stack.Pop();
        }

        return S;

    }

}
