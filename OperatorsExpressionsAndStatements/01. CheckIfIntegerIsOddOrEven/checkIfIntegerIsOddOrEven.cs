using System;

class checkIfIntegerIsOddOrEven
{
    static bool ValidateEvenNum(int num)
    {
        bool isEven = true;
        if ((num % 2) != 0)
        {
            isEven = false;
        }
        return isEven;
    }
    static void Main()
    {
        Console.Write("input number: ");
        int num = int.Parse(Console.ReadLine());

        bool isEven = ValidateEvenNum(num);

        if (isEven)
        {
            Console.WriteLine("{0} is even!", num);
        }
        else
        {
            Console.WriteLine("{0} is odd!", num);
        }
    }
}
