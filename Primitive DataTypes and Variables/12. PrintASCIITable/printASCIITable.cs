using System;
using System.Text;

class PrintASCIITable 
{
    static void Main()
    {
        // ASCII is a 7bit code!
        Console.OutputEncoding = Encoding.ASCII;


        int column = 0;
        for (byte counter = 32; counter < 128; counter++)
        {
            if (column == 0)
            {
                Console.Write("0x{0:X}  ", counter);
            }
            Console.Write(" {0}  ", (char)counter);
            if (++column > 7)
            {
                column = 0;
                Console.WriteLine();
            }

        }
        Console.ReadLine();
    }
}
