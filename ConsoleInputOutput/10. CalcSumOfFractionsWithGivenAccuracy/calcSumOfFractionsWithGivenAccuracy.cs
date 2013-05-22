//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalcSumOfFractionsWithGivenAccuracy
{
    static void Main()
    {
        int dividend = 1;
        int divisor = 1;
        double sum = 0;

        int maxDivisor = 5;

        for (int i = 0; i < maxDivisor; i++)
        {
            double fraction = (double)dividend / (double)divisor;
            bool isOddDivisor = !((divisor & 1) == 0);
            if (isOddDivisor)
            {
                if (divisor != 1)
                {
                    fraction *= -1;
                }
            }
            sum += fraction;
            divisor++;
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}
