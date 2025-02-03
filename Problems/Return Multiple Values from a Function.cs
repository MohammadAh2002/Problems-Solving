/*
 
    Return Multiple Values from a Function
    Problem: Create a function that returns a student's name, age, and grade. 
 
 
*/

class Program
{
    static void Main()
    {

        (string Name, short Age, float Grade) Student = StudentDetails();

        Console.WriteLine($"Student Details: Name: {Student.Name}, Age: {Student.Age}, Grade: {Student.Grade}");

    }

    static public (string Name, short Age, float Grade) StudentDetails()
    {

        return ("Mohammad Ahmad", 23, 96.5f);

    }
}
