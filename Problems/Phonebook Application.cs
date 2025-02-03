/*
 
    Phonebook Application
    Problem: Implement a phonebook where you can store and retrieve contact numbers using names.

    Output:

    Alice's Phone: 123-456-7890

    Bob's Phone: 987-654-3210
 
*/

class Program
{
    static void Main()
    {

        Dictionary<string, string> PhoneBook = new Dictionary<string, string> {

            {"Mohammad","0543812416"},
            {"Ahmad","1543812416"}
        
        };

        foreach (KeyValuePair<string, string> Phone in PhoneBook)
        {
        
            Console.WriteLine(Phone.Key + " Phone: " + Phone.Value);
        
        }

    }
}
