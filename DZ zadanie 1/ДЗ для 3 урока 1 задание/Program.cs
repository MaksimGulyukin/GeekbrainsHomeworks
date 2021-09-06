using System;

namespace ДЗ_для_3_урока_1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            matrix[0, 0] = 12;
            matrix[1, 1] = 1;
            matrix[2, 2] = 67;
            matrix[3, 3] = 4;
            matrix[4, 4] = 98;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
