using System;

class PrintSignOfProduct
{
    static bool FindSign(int number)
    {
        bool isPositive = true;
        if (number < 0)
        {
            isPositive = false;
        }
        return isPositive;
    }
    static void Main()
    {
        Console.WriteLine("Input three numbers:");
        Console.Write("first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("second number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.Write("third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int numHolderLenght = 3;

        int[] numHolder = new int[numHolderLenght];

        int negativeCount = 0;

        foreach (var number in numHolder)
        {
            bool isNegative = !FindSign(number);
            if (isNegative)
            {
                negativeCount++;
            }
        }
        string productSign;
        if (negativeCount % 2 == 0)
        {
            productSign = "+";
        }
        else
        {
            productSign = "-";
        }
        Console.WriteLine("The sign of product of these numbers is: {0}", productSign);
    }
}
