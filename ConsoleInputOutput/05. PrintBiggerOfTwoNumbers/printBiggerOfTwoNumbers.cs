using System;

class PrintBiggerOfTwoNumbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal bigger = Math.Max(a, b);
        Console.WriteLine(bigger);
    }
}
