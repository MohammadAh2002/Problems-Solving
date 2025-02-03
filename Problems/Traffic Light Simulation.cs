/*
 
    Traffic Light Simulation
    Task: Use a BitArray to represent the state of traffic lights at 3 intersections (Red, Yellow, Green).
          Change the light for one intersection.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray TrafficLights = new BitArray(4);

        // Green at intersection 1
        TrafficLights[2] = true;

        // Change light to Yellow
        TrafficLights[2] = false;
        TrafficLights[1] = true;

        Console.WriteLine("Intersection 1 Lights:");
        Console.WriteLine($"Red: {TrafficLights[0]}, Yellow: {TrafficLights[1]}, Green: {TrafficLights[2]}");

    }
}
