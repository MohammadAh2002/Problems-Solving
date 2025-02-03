/*

    Store Marks of Students in Multiple Subjects
    Problem: Use a jagged array to store marks of students across different subjects.

    Example:
    Input:

    Student 1: [90, 85, 88]
    Student 2: [76, 80]
    Student 3: [92, 93, 89, 85]

    Output: Display marks for each student. 
 
*/

class Program
{
    static void Main()
    {

        int[][] studentMarks = new int[][]
        {

            new int[] { 90, 85, 88 },
            new int[] { 76, 80 },  
            new int[] { 92, 93, 89, 85 }

        };

        for (int i = 0; i < studentMarks.Length; i++)
        {

            Console.Write($"Student {i + 1}: ");
            Console.WriteLine(string.Join(", ", studentMarks[i]));

        }

    }
        
}
