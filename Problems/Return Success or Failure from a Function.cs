/*
 
    Return Success or Failure from a Function
    Problem: Write a function that check the student mark and returns success status and the mark value.
 
*/

class Program
{
    static void Main()
    {

        (bool Success, int Value) Result = CheckStudentStatus(55);

        Console.WriteLine($"Success: {Result.Success}, Value: {Result.Value}");

    }

    static (bool Success, int Value) CheckStudentStatus(int Mark)
    {

        return (Mark >= 50 ? true : false, Mark);

    }

}
