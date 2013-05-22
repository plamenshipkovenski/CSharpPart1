using System;

class CountNumbersInIntervalDivisibleByFive
{
    static void Main()
    {
        uint startInterval = 17;
        uint endInterval = 25;

        uint numberOfMembers = (endInterval - startInterval) + 1;
        uint membersDivisibleByFive = (numberOfMembers / 5) + 1;
        Console.WriteLine(membersDivisibleByFive);
    }
}
