/*
 
    Light Control System
    Task: Represent the state of lights in a smart home system with 8 lights.
          Update the status of specific lights and turn all lights off at once. 
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray lights = new BitArray(8, false);

        lights[0] = true;
        lights.Set(7, true);
        lights[3] = true;

        Console.WriteLine("Lights:");
        for (int i = 0; i < lights.Length; i++)
        {
            
                Console.WriteLine($"Light {i}: {lights[i]}");            

        }

        lights.SetAll(false);

        Console.WriteLine("\nReseting All Lights:");
        for (int i = 0; i < lights.Length; i++)
        {

            Console.WriteLine($"Light {i}: {lights[i]}");

        }
    }
}
