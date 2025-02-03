/*
 
     Create a BitArray from an Integer
     Description: Write a function that takes an integer and returns a BitArray
                  representing its binary digits.
 
*/


using System.Collections;

class Program
{
    static void Main()
    {

        int Number = 10; // Binary: 1010
        BitArray Bits = IntToBitArray(Number);

        Console.Write("BitArray representation of " + Number + ": ");
        
        bool LeadingZero = true;
        for (int i = Bits.Length - 1; i >= 0; i--)
        {
            if (Bits[i])
            {
                LeadingZero = false;
            }
            if (!LeadingZero)
            {
                Console.Write(Bits[i] ? "1" : "0");
            }
        }

        // In case the number is 0, print a single "0"
        if (LeadingZero)
        {
            Console.Write("0");
        }
    }

    static BitArray IntToBitArray(int number)
    {
        return new BitArray(new[] { number });
    }

}
