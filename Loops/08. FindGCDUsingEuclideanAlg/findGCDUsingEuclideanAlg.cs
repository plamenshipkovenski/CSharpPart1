using System;

class FindGCDUsingEuclideanAlg
{
    private static int FindBigger(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    private static int FindSmaller(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    //static int GCD(int a, int b)// this algotrithm works for positive and negative values
    //{
    //    if (b == 0)
    //    {
    //        return a;
    //    }
    //    else
    //    {
    //        return GCD(b, a % b);
    //    }
    //}

    static void Main()
    {
        Console.Title = "Find greatest common divisor";
        Console.Write("input first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("input second number: ");
        int secNum = int.Parse(Console.ReadLine());

        //Console.WriteLine(GCD(firstNum, secNum));

        int GCD = 0;

        if (firstNum == 0)
        {
            GCD = secNum;
        }
        else if (secNum == 0)
        {
            GCD = firstNum;
        }
        else
        {
            //this algorithm works only for positive values

            int biggerNum = FindBigger(firstNum, secNum);
            int smallerNum = FindSmaller(firstNum, secNum);

            while (true)
            {
                int reminder = biggerNum % smallerNum;
                if (reminder == 0)
                {
                    GCD = smallerNum;
                    break;
                }
                biggerNum = FindBigger(smallerNum, reminder);
                smallerNum = FindSmaller(smallerNum, reminder);
            }
        }
        Console.WriteLine("GCD({0}, {1}) = {2}", firstNum, secNum, GCD);
    }
}
