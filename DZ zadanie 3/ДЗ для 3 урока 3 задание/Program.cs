using System;

namespace ДЗ_для_3_урока_3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение либо слово: ");
            string text = Console.ReadLine();
            char[] textReverse = text.ToCharArray();
            Array.Reverse(textReverse);
            string text2 = new string(textReverse);
            Console.WriteLine(text2);
            Console.ReadKey();
        }
    }
}
