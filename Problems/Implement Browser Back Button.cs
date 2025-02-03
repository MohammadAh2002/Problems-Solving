// Use a stack to implement a browser's back button functionality.
class Program
{
    static void Main()
    {

        Stack<int> PagesStack = new Stack<int>();

        PagesStack.Push(1);
        PagesStack.Push(2);
        PagesStack.Push(3);
        PagesStack.Push(4);
        PagesStack.Push(5);

        Console.WriteLine("Current Page: " + PagesStack.Peek());
        Console.WriteLine("Back From: " + PagesStack.Pop());

        Console.WriteLine("Current Page: " + PagesStack.Peek());
        Console.WriteLine("Back From: " + PagesStack.Pop());

        Console.WriteLine("Current Page: " + PagesStack.Peek());

    }
}
