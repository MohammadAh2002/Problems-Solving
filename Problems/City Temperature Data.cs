/*

    City Temperature Data
    Problem: Store daily temperature readings for multiple cities,
             where each city has a different number of recorded days. 
 
*/

class Program
{
    static void Main()
    {

        double[][] CityTemperature = new double[3][];
        CityTemperature[0] = new double[] { 10.5, 20.3, 30.1 };
        CityTemperature[1] = new double[] { 40.7, 50.5 };
        CityTemperature[2] = new double[] { 60.9, 70.5, 80, 90.6 };

        Console.WriteLine("Cities Temperature:");
        for (int i = 0; i < CityTemperature.Length; i++)
        {

            Console.Write($"City {i + 1}: ");

            Console.WriteLine(string.Join(", ", CityTemperature[i]));

        }

    }

}
