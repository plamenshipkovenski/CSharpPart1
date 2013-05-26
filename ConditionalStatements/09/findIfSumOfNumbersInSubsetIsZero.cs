using System;
using System.Collections.Generic;

class FindIfSumOfNumbersInSubsetIsZero
{
    static void Main()
    {
        int[] numbers = new int[]
        {
            3, -2, 1, 1, 8 
        };
        int sumToCompareWith = 0;
        List<List<int>> subsets = new List<List<int>>();

        //get combination of numbers in subset
        int subsetMaxMembers = (int)Math.Pow((double)2, (double)numbers.Length) - 1;
        for (int subsetMembers = 1; subsetMembers <= subsetMaxMembers ; subsetMembers++)
        {
            long subsetSum = 0;
            List<int> subset = new List<int>();
            //get subset members
            for (int i = 0; i < numbers.Length; i++)
            {
                int mask = 1 << i;
                int subsetAndMask = subsetMembers & mask;
                int bitValue = subsetAndMask >> i;
                if (bitValue == 1)
                {
                    subsetSum += numbers[i];
                    subset.Add(numbers[i]);
                }
            }
            if (subsetSum == sumToCompareWith)
            {
                subsets.Add(subset);
            }
        }
        Console.WriteLine("There is {0} subsets, with sum of {1}", subsets.Count, sumToCompareWith);
        foreach (var subset in subsets)
        {
            for (int i = 0; i < subset.Count; i++)
            {
                Console.Write("{0}{1}", subset[i], i == subset.Count - 1 ? "" : ", ");
            }
            Console.WriteLine();
        }
    }
}
