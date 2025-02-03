/*
    Task Scheduling

    Problem: Given a set of tasks with a specific order,
    simulate the order of execution using a queue.
    
    Example:

    Input:
    ["Task1", "Task2", "Task3", "Task4"]
    
    Output:
    Execute tasks in the order they appear.
    
    Key Points:
    Enqueue tasks in the given order.
    Dequeue and process them one at a time.

*/

class Program
{
    static void Main()
    {

        Queue<string> TasksQueue = new Queue<string>();

        TasksQueue.Enqueue("Task 1");
        TasksQueue.Enqueue("Task 2");
        TasksQueue.Enqueue("Task 3");
        TasksQueue.Enqueue("Task 4");

        Console.WriteLine("Executing tasks:");

        while (TasksQueue.Count > 0) {

            Console.WriteLine("processing: " + TasksQueue.Dequeue());
          
        }

        Console.WriteLine("\nAll Tasks Has Finshed");

    }
}

