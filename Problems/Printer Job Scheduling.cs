// Use a queue to manage printer jobs.

class Program
{
    static void Main()
    {

        Queue<string> PrinterQueue = new Queue<string>();

        PrinterQueue.Enqueue("Page 1");
        PrinterQueue.Enqueue("Page 2");
        PrinterQueue.Enqueue("Page 3");
        PrinterQueue.Enqueue("Page 4");
        PrinterQueue.Enqueue("Page 5");

        Console.WriteLine("Printing: " + PrinterQueue.Dequeue());
        Console.WriteLine("Next Job: " + PrinterQueue.Peek());

        Console.WriteLine("\nPrinting: " + PrinterQueue.Dequeue());
        Console.WriteLine("Next Job: " + PrinterQueue.Peek());

        Console.WriteLine("\nPrinting: " + PrinterQueue.Dequeue());
        Console.WriteLine("Next Job: " + PrinterQueue.Peek());

        Console.WriteLine("\nPrinting: " + PrinterQueue.Dequeue());
        Console.WriteLine("Next Job: " + PrinterQueue.Peek());

        Console.WriteLine("\nPrinting: " + PrinterQueue.Dequeue());

        if (PrinterQueue.Count == 0)
            Console.WriteLine("\nNot thing Left to Print :-)");

    }
}
