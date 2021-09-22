using System;
using System.IO;

namespace ДЗ_к_5_уроку_3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255:");
            string fileName = "byteFile.bin";
            var text = Convert.ToByte(Console.ReadLine());
            
            byte[] bytes = { text };

            File.WriteAllBytes(fileName, bytes);
            byte[] fromFile = File.ReadAllBytes(fileName);
            Console.WriteLine(fromFile);
        }
    }
}
