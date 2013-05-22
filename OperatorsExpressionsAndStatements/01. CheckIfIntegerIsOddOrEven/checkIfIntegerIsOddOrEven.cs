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
        int num = 0;
        bool isEven = true && ValidateEvenNum(num);
        bool isOdd = !isEven;
        Console.WriteLine(isEven);
        Console.WriteLine(isOdd);
    }
}
