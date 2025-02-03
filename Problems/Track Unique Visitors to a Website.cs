/*

    Track Unique Visitors to a Website
    Problem: Track unique visitors to a website using IP addresses.
 
*/


class Program
{
    static void Main()
    {

        HashSet<string> Visitors = new HashSet<string>();

        Visitors.Add("192.168.1.1");
        Visitors.Add("192.168.1.3");
        Visitors.Add("192.168.1.2");
        Visitors.Add("192.168.1.6");
        Visitors.Add("192.168.3.1");
        Visitors.Add("192.168.1.1");

        Console.WriteLine("Number of Unique Visitors: " + Visitors.Count);

    }
}
