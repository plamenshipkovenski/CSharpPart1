using System;

class FindMinAndMax
{
    static void Main()
    {
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        Console.Write("input integer: ");
        int arrLength = int.Parse(Console.ReadLine());
        Console.WriteLine("input {0} integers: ", arrLength);
        int[] myArray = new int[arrLength];

        for (int index = 0; index < myArray.Length; index++)
        {
            myArray[index] = int.Parse(Console.ReadLine());
        }
        foreach (var number in myArray)
        {
            if (number < minNum)
            {
                minNum = number;
            }
            if (maxNum < number)
            {
                maxNum = number;
            }
        }
        Console.WriteLine("minimal of those numbers is: {0}", minNum);
        Console.WriteLine("maximal of those numbers is: {0}", maxNum);
    }
}
