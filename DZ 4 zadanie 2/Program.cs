using System;


namespace ДЗ_к_4_уроку_3_задание
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите числа через пробел, для получения их суммы: ");
            string str = Console.ReadLine();
            var words = str.Split();
            int sum = default;
            for (int i = 0; i < words.Length; sum += int.Parse(words[i++])) ;
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
