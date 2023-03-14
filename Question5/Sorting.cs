using System;

namespace Sorting
{
    public class Sorting
    {
        static void Main(string[] args)
        {
            int[] terms = { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 };
            Array.Sort(terms);
            int largestGap = 0;
            for (int i = 0; i < terms.Length - 1; i++)
            {
                int gap = terms[i + 1] - terms[i];
                if (gap > largestGap)
                {
                    largestGap = gap;
                }
            }
            Console.WriteLine("Largest gap: " + largestGap);
        }
    }
}
