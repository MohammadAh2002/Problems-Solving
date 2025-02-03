/*
 
    Evaluate a Postfix Expression
    Problem: Evaluate a postfix expression using a stack.

    Example:
    Input: "231*+9-"
    Output: -4


    Key Points:

    - Push numbers onto the stack.
    - Perform operations using the top two elements for each operator.
    
    Step-by-Step Execution for "231*+9-":

    1- Initial Expression: "231*+9-"

    2- Processing the Characters:

    Character 2:
    Digit → Push 2 onto the stack.
    Stack: [2]

    Character 3:
    Digit → Push 3 onto the stack.
    Stack: [2, 3]

    Character 1:
    Digit → Push 1 onto the stack.
    Stack: [2, 3, 1]

    Character *:
    Operator → Pop 1 and 3 from the stack.
    Multiply: 3 * 1 = 3
    Push result (3) onto the stack.
    Stack: [2, 3]

    Character +:
    Operator → Pop 3 and 2 from the stack.
    Add: 2 + 3 = 5
    Push result (5) onto the stack.
    Stack: [5]

    Character 9:
    Digit → Push 9 onto the stack.
    Stack: [5, 9]

    Character -:
    Operator → Pop 9 and 5 from the stack.
    Subtract: 5 - 9 = -4
    Push result (-4) onto the stack.
    Stack: [-4]

    3- Final Step:
    The last element in the stack (-4) is popped and returned as the result.
 
*/


class Program
{
    static void Main()
    {

        string PostfixExpression = "231*+9-";

        Console.WriteLine("Evaluate Postfix Expression Result: " + EvaluatePostfixExpression(PostfixExpression));

    }

    static public int EvaluatePostfixExpression(string S)
    {

        Stack<int> Stack = new Stack<int>();

        foreach(char C in S){

            if(char.IsDigit(C))
            {
                Stack.Push(C - '0');
                continue;
            }

            if ((C == '+' || C == '-' || C == '/' || C == '*') && Stack.Count > 1)
            {
                int Number2 = Stack.Pop();
                int Number1 = Stack.Pop();

                Stack.Push(Calculate(Number1, Number2, C));

            }

        }

        return Stack.Pop();

    }

    public static int Calculate(int Num1, int Num2, char Operation)
    {
        switch (Operation)
        {
            case '+':
                return Num1 + Num2;
            case '-':
                return Num1 - Num2;
            case '/':
                return Num1 / Num2;
            default:
                return Num1 * Num2;
        }
    }

}
