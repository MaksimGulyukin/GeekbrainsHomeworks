using System;

namespace ДЗ_для_3_урока_2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] matrix = new string[5, 2];

            matrix[0, 0] = "Тамара П.";
            matrix[0, 1] = "+7999999993";
            matrix[1, 0] = "Петя";
            matrix[1, 1] = "89999993124";
            matrix[2, 0] = "Паша"; 
            matrix[2, 1] = "79883453234";
            matrix[3, 0] = "Начальник";
            matrix[3, 1] = "89777777777";
            matrix[4, 0] = "Вася";
            matrix[4, 1] = "+7988888888";

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
