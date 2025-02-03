/*
 
    Representing a Social Network
    Create a system to represent a social network where each person has connections (friends). 
    The structure should allow traversal and printing of a person's connections.

    Note: User Tree.

    Output:

    Alice's Social Network:
    Alice
     - Bob
     - Charlie
*/

class Person
{

    public string Name { get; set; }
    public List<Person> Friends { get; set; } = new List<Person>(); 

    public Person(string name)
    {
        Name = name;
    }

    public void PrintFriends(int depth, string indent = "")
    {
        if (depth == 0) return; 
        Console.WriteLine(indent + Name); 
        foreach (Person friend in Friends)
        {
            friend.PrintFriends(depth - 1, indent + "  ");
        }
    }
}

class Program
{
    static void Main()
    {

        Person alice = new Person("Alice");
        Person bob = new Person("Bob");
        Person charlie = new Person("Charlie");
        Person dave = new Person("Dave");

        alice.Friends.Add(bob);
        alice.Friends.Add(charlie);
        bob.Friends.Add(dave); 

        Console.WriteLine("Alice's Social Network:");
        alice.PrintFriends(3);

    }
}
