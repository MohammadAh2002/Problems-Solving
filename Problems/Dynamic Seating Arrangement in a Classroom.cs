/*

    Dynamic Seating Arrangement in a Classroom
    Problem: Each row in a classroom has a different number of seats.
             Store the seating arrangement and access each seat dynamically. 
 
*/

class Program
{
    static void Main()
    {

        int[][] ClassroomSeats = new int[3][];
        ClassroomSeats[0] = new int[] { 1, 2, 3 };
        ClassroomSeats[1] = new int[] { 4, 5 };
        ClassroomSeats[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("Classroom Seating:");
        for (int i = 0; i < ClassroomSeats.Length; i++)
        {

            Console.Write($"Row {i + 1}: ");

            Console.WriteLine(string.Join(", ", ClassroomSeats[i]));

        }

    }

}
