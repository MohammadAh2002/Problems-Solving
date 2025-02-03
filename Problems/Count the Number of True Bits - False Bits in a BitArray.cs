/*
 
    Count the Number of True Bits / False Bits in a BitArray
    Description: Write a function to count the number of true values and false values in a BitArray.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray Bits = new BitArray(new bool[] { true, false, true, true, false, false, true, true });

        Console.WriteLine("Number of True Bits: " + CountTrueBits(Bits));
        Console.WriteLine("Number of False Bits: " + CountFalesBits(Bits));

    }

    static int CountTrueBits(BitArray Bits)
    {

        int Count = 0;

        foreach (bool Bit in Bits)
        {

            if (Bit)
                Count++;

        }

        return Count;

    }

    static int CountFalesBits(BitArray Bits)
    {

        int Count = 0;

        foreach (bool Bit in Bits)
        {

            if (!Bit)
                Count++;

        }

        return Count;

    }

}
