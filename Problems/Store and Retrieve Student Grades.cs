/*
 
    Store and Retrieve Student Grades
    Problem: Store the grades of students using their names as keys,
             and retrieve Bob's Info using student name.

    Output: Student: Bob, Grade: 90 
  
*/

class Program
{
    static void Main()
    {

        Dictionary<string, int> Students = new Dictionary<string, int>();

        Students.Add("Mohammad",90);
        Students.Add("Ahmad", 80);

        foreach(KeyValuePair<string, int> Student in Students)
        {

            Console.WriteLine("Student: {0}, Grade: {1}", Student.Key, Student.Value);

        }

    }
}
