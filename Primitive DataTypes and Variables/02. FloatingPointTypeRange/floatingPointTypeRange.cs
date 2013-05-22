//Which of the following values can be assigned to 
//a variable of type float and which to
//a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?


using System;
using System.Threading;

class FloatingPointTypeRange
{
    static void Main()
    {
        int consoleRows = 33;
        int consoleCols = 73;
        int myHeight = 100;
        int myWidth= 100;
        Console.SetWindowSize(consoleCols, consoleRows);
        Console.SetBufferSize(myWidth, myHeight);
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"?                 34.567839023             
?                 12.345
?               8923.1234857
?               3456.091                  ?");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"floating point types.                   RANGE
                    .                <<<<(o)>>>>
                    .            
float:            {0}            {1}
double:           {2}   {3}
decimal:  {4}   {5}
                    .
                  POINT                                          MaxValue
                    .
                    V                                            MaxValue",
            float.MinValue, float.MaxValue,
            double.MinValue, double.MaxValue,
            decimal.MinValue, decimal.MaxValue
            );
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                    .");
        Console.WriteLine("                    .");
        Console.WriteLine("                    .                     ?");
        Console.WriteLine("                    .                 PRECISION");
        Console.WriteLine("                    .");
        Console.WriteLine(@"        float:      .  
       double:      .");
        Console.WriteLine();

        while (true)
        {
            if (Console.KeyAvailable)
         {
                ConsoleKeyInfo userInput = Console.ReadKey();
            }
                
            break;
        }
        string dotNet = "Press any key to continue . . . ";
        Console.SetCursorPosition(0,0);
    }
}
