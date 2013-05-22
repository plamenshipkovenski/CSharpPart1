using System;

class FindGreatestOfFiveVariables
{
    static void Main()
    {
        Console.Title = "Find biggest number";
        int countVariables = 5;
        double[] inputHolder = new double[countVariables];
        double biggest = double.MinValue;

        for (int i = 0; i < countVariables; i++)
        {
            Console.Write("input number: ");
            inputHolder[i] = double.Parse(Console.ReadLine());
            if (biggest < inputHolder[i])
            {
                biggest = inputHolder[i];
            }
        }
        Console.WriteLine("the biggest of these numbers is: {0}", biggest);
    }
}
