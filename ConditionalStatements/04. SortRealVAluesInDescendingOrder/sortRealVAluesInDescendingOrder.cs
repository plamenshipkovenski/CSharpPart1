using System;

class SortRealVAluesInDescendingOrder
{
    static double FindBigger(double a, double b)
    {
        double bigger = double.MinValue;
        if (a < b)
        {
            bigger = b;
        }
        else
        {
            bigger = a;
        }
        return bigger;
    }
    static void Main()
    {
        Console.Title = "Sort three real values in descending order";
        int numsToSort = 3;
        double[] numsSorted = new double[numsToSort];
        Console.Write("Input first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        double secNum = double.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        double biggerNum = FindBigger(FindBigger(firstNum, secNum), thirdNum);
        numsSorted[0] = biggerNum;
        if (biggerNum == firstNum)
        {
            if (secNum > thirdNum)
            {
                numsSorted[1] = secNum;
                numsSorted[2] = thirdNum;
            }
            else
            {
                numsSorted[1] = thirdNum;
                numsSorted[2] = secNum;
            }
        }
        if (biggerNum == secNum)
        {
            if (firstNum > thirdNum)
            {
                numsSorted[1] = firstNum;
                numsSorted[2] = thirdNum;
            }
            else
            {
                numsSorted[1] = thirdNum;
                numsSorted[2] = firstNum;
            }
        }
        if (biggerNum == thirdNum)
        {
            if (firstNum > secNum)
            {
                numsSorted[1] = firstNum;
                numsSorted[2] = secNum;
            }
            else
            {
                numsSorted[1] = secNum;
                numsSorted[2] = firstNum;
            }
        }
        for (int i = 0; i < numsSorted.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("biggest: ");
            }
            else if (i == 1)
            {
                Console.Write("middle: ");
            }
            else
            {
                Console.Write("smallest: ");
            }
            Console.WriteLine(numsSorted[i]);
        }
    }
}
