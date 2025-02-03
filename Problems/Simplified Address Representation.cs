/*
 
    Simplified Address Representation
    Problem: Use tuples to represent and display a person's address.

    Output: Address: 123 Main St, Springfield, IL, 62704

*/

class Program
{
    static void Main()
    {

        (string Street, string City, string Country, string Zip) Address = ("123 Main St", "Jerusalem", "Palestine", "200256");

        Console.WriteLine($"Address Details: Street:{Address.Street}, City: {Address.City}, Country: {Address.Country}, Zip: {Address.Zip}.");

    }

}
