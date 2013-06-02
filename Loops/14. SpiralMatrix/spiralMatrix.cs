using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] mySpiralMatrix = new int[n, n];

        int pos = 1;
        int count = n;
        int value = -n;
        int sum = -1;

        do
        {
            value = -1 * value / n;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                mySpiralMatrix[sum / n, sum % n] = pos++;
            }
            value *= n;
            count--;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                mySpiralMatrix[sum / n, sum % n] = pos++;
            }
        } while (count > 0);


        // Method to print arrays, pads numbers so they line up in columns
        n = (mySpiralMatrix.GetLength(0) * mySpiralMatrix.GetLength(1) - 1).ToString().Length + 1;

        for (int i = 0; i < mySpiralMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < mySpiralMatrix.GetLength(1); j++)
            {
                Console.Write(mySpiralMatrix[i, j].ToString().PadLeft(n, ' '));
            }
            Console.WriteLine();
        }
    }
}
