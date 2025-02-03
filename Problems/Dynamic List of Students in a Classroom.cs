/*

    Dynamic List of Students in a Classroom
    Problem: Maintain and display a dynamic list of students in a classroom.

    Example: Add, remove, or replace students in real-time, 
             and notify changes to event so you can use it to change UI. 

*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> students = new ObservableCollection<string>();

        students.CollectionChanged += (sender, e) =>
        {
            //this event will be fired on any change (add or remove).

            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Student Added: {e.NewItems[0]}");
            if (e.Action == NotifyCollectionChangedAction.Remove)
                Console.WriteLine($"Student Removed: {e.OldItems[0]}");

        };

        students.Add("Mohammad");
        students.Add("Ahmad");

        students.Remove("Ahmad");

    }
}

