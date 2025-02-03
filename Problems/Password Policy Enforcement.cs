/*
 
    Password Policy Enforcement
    Task: Use a BitArray to enforce a password policy with 4 rules 
          (e.g., uppercase, lowercase, digit, special character). 
          Check if a password meets the policy.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray PasswordPolicy = new BitArray(4);


        string Password = "Password123!";
        PasswordPolicy[0] = Password.Any(char.IsUpper); // Uppercase
        PasswordPolicy[1] = Password.Any(char.IsLower); // Lowercase
        PasswordPolicy[2] = Password.Any(char.IsDigit); // Digit
        PasswordPolicy[3] = Password.Any(ch => "!@#$%^&*".Contains(ch)); // Special Character


        bool isValid = PasswordPolicy.Cast<bool>().All(bit => bit);
        Console.WriteLine($"Password Valid: {isValid}");

    }
}
