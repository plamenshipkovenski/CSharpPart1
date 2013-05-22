using System;
using System.Text;

class printSequence
{
    static void Main()
    {
        StringBuilder numToPrint = new StringBuilder("1");
        int sequenceMembers = 3;

        for (int i = 0; i < sequenceMembers; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(numToPrint);
            }
            else
            {
                numToPrint.Append("01");
                Console.WriteLine(numToPrint);
                numToPrint.Remove((numToPrint.Length - 1), 1);
            }
        }
    }
}