using System;

class FindBiggestOfThreeInts
{
    static void Main()
    {
        int firstNum = -2;
        int secNum = -2;
        int thirdNum = -2;

        int biggerNum;
        int biggestNum;
        if (firstNum > secNum)
        {
            biggerNum = firstNum;
            if (biggerNum > thirdNum)
            {
                biggestNum = biggerNum;
            }
            else
            {
                biggestNum = thirdNum;
            }
        }
        else
        {
            biggerNum = secNum;
            if (biggerNum > thirdNum)
            {
                biggestNum = biggerNum;
            }
            else
            {
                biggestNum = thirdNum;
            }
        }
        Console.WriteLine("The biggest of [{0}, {1}, {2}] is {3}", firstNum, secNum, thirdNum, biggestNum);
    }
}
