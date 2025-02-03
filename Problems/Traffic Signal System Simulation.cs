/*

    Traffic Signal System Simulation
    Problem: Simulate vehicles waiting at a traffic signal.

    Vehicles are processed in the order they arrive (FIFO), and after processing,
    the next vehicle moves up.

    Vehicles arrive in the following order:

    "Car";
    "Truck"
    "Bike"
    "Bus"

    Output:

    Traffic Signal Simulation Started...

    Car has passed the signal.
    Vehicles waiting: Truck, Bike, Bus 

    Truck has passed the signal.
    Vehicles waiting: Bike, Bus 

    Bike has passed the signal.
    Vehicles waiting: Bus 

    Bus has passed the signal.
    No vehicles waiting.

    Traffic Signal Simulation Ended. 

*/

using System;

class Program
{
    static void Main()
    {
       
        Queue<string> VehiclesQueue = new Queue<string>();

        VehiclesQueue.Enqueue("Car");
        VehiclesQueue.Enqueue("Truck");
        VehiclesQueue.Enqueue("Bike");
        VehiclesQueue.Enqueue("Bus");

        Console.WriteLine("Traffic Signal Simulation Started...");

        while (VehiclesQueue.Count > 0) {

            // Process the vehicle at the front of the queue
            string Vehiclepassed = VehiclesQueue.Dequeue();
            Console.WriteLine($"\n{Vehiclepassed} has passed the signal.");

            if (VehiclesQueue.Count > 0)
            {
                Console.WriteLine("Vehicles waiting: " + string.Join(", ", VehiclesQueue));
            }
            else
            {
                Console.WriteLine("No vehicles waiting.");
            }

        }

        Console.WriteLine("\nTraffic Signal Simulation Ended.");

    }
}
