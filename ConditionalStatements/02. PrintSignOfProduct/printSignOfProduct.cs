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
        int numHolderLenght = 3;
        int[] numHolder = new int[numHolderLenght];

        Console.WriteLine("Input three numbers:");
        for (int index = 0; index < numHolder.Length; index++)
        {
            Console.Write("input number: ");
            numHolder[index] = int.Parse(Console.ReadLine());
        }

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
