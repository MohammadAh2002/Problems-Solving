/*

    Queue Using Two Stacks
    Problem: Implement a queue using two stacks.

    Example:
    Operations: Enqueue(1), Enqueue(2), Dequeue(), Dequeue()
    Output: 1 , 2

    Key Points:

    Use one stack to store incoming elements and the other for dequeuing. 

 */

class Program
{
    static void Main()
    {

        MyQueue MyQueue = new MyQueue();

        MyQueue.Enqueue(1);
        MyQueue.Enqueue(2);

        Console.WriteLine("Element 1: " + MyQueue.Dequeue());
        Console.WriteLine("Element 2: " + MyQueue.Dequeue());

    }
}

class MyQueue
{

    Stack<int> EnqueueStack = new Stack<int>();
    Stack<int> DequeueStack = new Stack<int>();

    public void Enqueue(int Element)
    {

        EnqueueStack.Push(Element);

    }

    public int Dequeue()
    {
        if (DequeueStack.Count == 0)
        {
            while (EnqueueStack.Count > 0)
            {
                DequeueStack.Push(EnqueueStack.Pop());
            }
        }

        return DequeueStack.Pop();

    }

}
