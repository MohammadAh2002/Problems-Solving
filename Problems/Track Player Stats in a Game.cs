/*
 
    Track Player Stats in a Game
    Problem: Use tuples to store and display a player's name, health, and score in a game. 
 
*/

class Program
{
    static void Main()
    {

        (string Name, short Health, int Score) Player = PlayerDetails();

        Console.WriteLine($"Player Details: Name: {Player.Name}, Health: {Player.Health}, Score: {Player.Score}");

    }

    static public (string Name, short Health, int Score) PlayerDetails()
    {

        return ("Mohammad Ahmad", 100, 999);

    }
}
