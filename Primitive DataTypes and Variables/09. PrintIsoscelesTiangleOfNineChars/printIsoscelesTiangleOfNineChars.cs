using System;

class PrintIsoscelesTiangleOfNineChars
{
    static void Main()
    {
        int rows;
        int cols;
        rows = 3;
        cols = 5;
        char[,] myMatrix = new char[rows, cols];
        int start;
        int end;
        start = myMatrix.GetLength(1) / 2;
        end = start;
        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                if (start <= col && col <= end)
                {
                    myMatrix[row, col] = '\u00A9';
                }
            }
            start--;
            end++;
            Console.WriteLine();
        }
        PrintMatrix(myMatrix);
    }

    private static void PrintMatrix(char[,] myMatrix)
    {

        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                Console.Write(myMatrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
