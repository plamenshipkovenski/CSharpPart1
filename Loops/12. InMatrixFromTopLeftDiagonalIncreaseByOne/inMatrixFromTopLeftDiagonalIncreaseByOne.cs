using System;

class inMatrixFromTopLeftDiagonalIncreaseByOne
{
    static void Main()
    {
        Console.Write("Input matrix width: ");
        int n = int.Parse(Console.ReadLine());

        int[,] myMatrix = new int[n, n];

        int memberValue = 1;

        for (int row = 0; row < myMatrix.GetLength(0); row++)
        {
            int tempMemberValue = memberValue;

            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                myMatrix[row, col] = tempMemberValue;
                tempMemberValue++;
            }
            memberValue++;
        }
        PrintMatrix(myMatrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}