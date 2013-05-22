using System;

class PrintSequence
{
    static void Main()
    {
        int membersToPrint = 10;

        for (int counter = 0, memberValue = -2; counter < membersToPrint; counter++,memberValue--)
        {
            bool isEvenMember = memberValue % 2 == 0;
            if (isEvenMember)
            {
                Console.WriteLine(Math.Abs(memberValue));
            }
            else
            {
                Console.WriteLine(memberValue);
            }
        }
    }
}
