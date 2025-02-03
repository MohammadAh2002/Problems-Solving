/*

    Schedule Tasks Based on Priority
    Description: Implement a task scheduler where tasks have priorities,
                 and you need to process them in order of priority.

    Note: Use SortedSet not Queue

*/

class Program
{
    static void Main()
    {
        SortedSet<Task> Tasks = new SortedSet<Task>
        {
            new Task { Priority = 2, Description = "Write report" },
            new Task { Priority = 1, Description = "Fix critical bug" },
            new Task { Priority = 3, Description = "Team meeting" }
        };

        // Add a new task with same priority
        Tasks.Add(new Task { Priority = 2, Description = "Review PRs" });

        Console.WriteLine("Tasks in priority order:\n");
        foreach (Task Task in Tasks)
        {
            Console.WriteLine($"Priority: {Task.Priority}, Task: {Task.Description}");
        }

    }

}

class Task : IComparable<Task>
{

    public int Priority { get; set; }
    public string? Description { get; set; }

    public int CompareTo(Task Other)
    {
        // Lower priority number indicates higher importance
        int Result = Priority.CompareTo(Other.Priority);

        if (Result == 0)
        {
            // If priorities are equal, compare descriptions to avoid duplicates
            Result = Description.CompareTo(Other.Description);
        }
        return Result;
    }
}

