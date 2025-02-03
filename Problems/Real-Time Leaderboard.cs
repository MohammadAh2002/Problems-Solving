/*

    Real-Time Leaderboard
    Problem: Track players’ scores in a game, sorted by player names. 
 
*/

class Program
{
    static void Main()
    {

        SortedList<string, int> LeaderBoard = new SortedList<string, int> {

            {"Mohammad", 1700},
            {"Alice", 1200},
            {"Charlie", 1500},
            {"Bob", 1300},
            {"Ahmad", 700 }

        };

        foreach (KeyValuePair<string, int> player in LeaderBoard)
        {
            Console.WriteLine($"Player: {player.Key}, Score: {player.Value}");
        }

    }
}
