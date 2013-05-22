using System;

class checkIntegerDivisibility
{
    static void Main()
    {
        int dividend;
        dividend = int.Parse(Console.ReadLine());
        int factor1 = 5;
        int factor2 = 7;
        int divisor = factor1 * factor2;
        bool hasReminder = (dividend % divisor) > 0;

        bool isDivisible;
        if (hasReminder)
        {
            isDivisible = false;
        }
        else
        {
            isDivisible = true;
        }

        if (isDivisible)
        {
            Console.WriteLine("{0} can be divided (without reminder) by {1}, and {2} at the same time!", dividend, factor1, factor2);
        }
        else
        {
            Console.WriteLine("{0} can not be divided (without reminder) by {1}, and {2} at the same time!", dividend, factor1, factor2);
        }
    }
}