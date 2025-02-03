/*

    Convert a BitArray to an Integer
    Description:
    Write a function to convert a BitArray (representing binary digits) into an integer.
 
*/
using System.Collections;

class Program
{
    static void Main()
    {

        BitArray BitArray = new BitArray(new bool[] { true, false, true, false, false });

        int Result = BitArrayToInt(BitArray);

        Console.WriteLine("Integer value of BitArray: " + Result);

    }

    static int BitArrayToInt(BitArray BitArray)
    {

        int Result = 0;

        for (int i = 0; i < BitArray.Length; i++)
        {

            if (BitArray[i])
            {

                Result += (1 << i);

            }

        }

        return Result;

    }

}
