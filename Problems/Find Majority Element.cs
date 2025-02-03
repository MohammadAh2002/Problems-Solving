/*
 
    Find Majority Element
    Problem: Find the majority element in an array (element appearing more than n/2 times).

    Example:
    Input: [3, 2, 3]
    Output: 3

    Key Points:

    Use a dictionary to count frequencies.
 
*/


class Program
{
    static void Main()
    {

        int[] Elements = [1, 2, 3, 1, 5, 9, 7, 5, 6, 3, 2, 1, 1, 5, 9, 4, 6, 5, 7, 2, 3];

        KeyValuePair<int, int> Element = MajorityElement(Elements);

        Console.WriteLine("Element: " + Element.Key + ", frequency: " + Element.Value);

    }

    static public KeyValuePair<int, int> MajorityElement(int [] Elements)
    {

        Dictionary<int, int> Elementsfrequency = new Dictionary<int, int> ();

        for (int i = 0; i < Elements.Length; i++) {

            if (Elementsfrequency.ContainsKey(Elements[i]))
                Elementsfrequency[Elements[i]]++;
            else 
                Elementsfrequency.Add(Elements[i], 1);

        }

        return Elementsfrequency.Aggregate((x, y) => x.Value > y.Value ? x : y);

    }
}
