/*

    Implementing Simple Backtracking
    Problem: Use a stack for backtracking My Day.

    Output:

    Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.

    Backtracking...

    Back to: Go Home
    Back to: Go to Cafe
    Back to: Go To Work
    Back to: Go to Super Market
    Back to: Go to Gaz Station
    Back to: Start

*/

class Program
{
    static void Main()
    {

        Stack<string> BacktrackingStack = new Stack<string>();

        BacktrackingStack.Push("Start");
        BacktrackingStack.Push("Go to Gaz Station");
        BacktrackingStack.Push("Go to Super Market");
        BacktrackingStack.Push("Go To Work");
        BacktrackingStack.Push("Go to Cafe");
        BacktrackingStack.Push("Go Home");

        Console.WriteLine("Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.\n");
        Console.WriteLine(string.Join(" -> ", BacktrackingStack.Reverse()));
        Console.WriteLine();

        while (BacktrackingStack.Count > 0) {

            Console.WriteLine("Back to: " + BacktrackingStack.Pop());

        }

    }
}
