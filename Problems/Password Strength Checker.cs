/*
 
    Password Strength Checker
    Task: Use a BitArray to track whether a password has an 
          uppercase letter, a lowercase letter, a digit, and a special character.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        string Password = "Hello123!";

        BitArray Checks = new BitArray(4, false);

        foreach (char c in Password)
        {
            if (char.IsUpper(c)) Checks[0] = true;
            if (char.IsLower(c)) Checks[1] = true;
            if (char.IsDigit(c)) Checks[2] = true;
            if (!char.IsLetterOrDigit(c)) Checks[3] = true;
        }

        Console.WriteLine($"Password Strength: {Checks[0]}, {Checks[1]}, {Checks[2]}, {Checks[3]}");

    }
}
