/*
 
    Perform Bitwise AND Between Two BitArrays
    Description:
        Write a function that takes two BitArray objects of equal length and returns a new BitArray
        that is the result of a bitwise AND operation.
 
*/

using System.Collections;

class Program
{
    static void Main()
    {

        BitArray BitArray1 = new BitArray(new bool[] { true, false, true, true, false, false, true, true });
        BitArray BitArray2 = new BitArray(new bool[] { true, true, false, true, false, false, false, true });

        BitArray? Result1 = PerformAND(BitArray1, BitArray2);

        Console.WriteLine("Result of AND Operation: ");

        Console.WriteLine("Way 1:");
        foreach (bool Bit in Result1)
        {
            Console.Write(Bit + " ");
        }
        Console.WriteLine("\n________________________________________________________");

        BitArray? Result2 = AndOperation(BitArray1, BitArray2);

        Console.WriteLine("\nWay 2:");
        foreach (bool Bit in Result2)
        {
            Console.Write(Bit + " ");
        }
        Console.WriteLine("\n\n\n");

    }

    static BitArray? AndOperation(BitArray BitArray1, BitArray BitArray2)
    {
        if (BitArray1.Length != BitArray2.Length)
            return null;

        BitArray BitArray = new BitArray(BitArray1.Count);

        for(int i = 0; i < BitArray1.Count; i++)  {

            BitArray.Set(i, BitArray1[i] & BitArray2[i]);

        }

        return BitArray;

    }

    static BitArray? PerformAND(BitArray BitArray1, BitArray BitArray2)
    {
        if (BitArray1.Length != BitArray2.Length)
            return null;

        return BitArray1.And(BitArray2);
    }

}
