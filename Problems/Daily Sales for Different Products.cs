/*

    Daily Sales for Different Products
    Problem: Store the sales for different products, where each product has varying daily sales. 
 
*/

class Program
{
    static void Main()
    {

        int[][] Sales = new int[3][];
        Sales[0] = new int[] { 10, 20, 30 };
        Sales[1] = new int[] { 40, 50 };
        Sales[2] = new int[] { 60, 70, 80, 90 };

        Console.WriteLine("Products Sales:");
        for (int i = 0; i < Sales.Length; i++)
        {

            Console.Write($"Product {i + 1}: ");

            Console.WriteLine(string.Join(", ", Sales[i]));

        }

    }

}
