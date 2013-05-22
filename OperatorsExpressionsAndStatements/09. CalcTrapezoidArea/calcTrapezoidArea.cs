using System;

class CalcTrapezoidArea
{
    static void Main()
    {
        double sideA = 56;
        double sideB = 45;
        double height = 4;

        double Area = (height * (sideA + sideB)) / 2;
        Console.WriteLine(Area);
    }
}
