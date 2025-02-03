/*

    Copy Hashtable to Another Hashtable
    Description:
        Write a program to copy all key-value pairs from one Hashtable to another. 
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        Hashtable Hashtable1 = new Hashtable
        {

            { "Name", "Mohammad" },
            { "Age", 23 }
        
        };

        Hashtable Hashtable2 = new Hashtable(Hashtable1);

        Console.WriteLine("Contents of copied Hashtable:");
        foreach (DictionaryEntry Entry in Hashtable2)
        {

            Console.WriteLine($"Key: {Entry.Key}, Value: {Entry.Value}");
       
        }

    }
}
