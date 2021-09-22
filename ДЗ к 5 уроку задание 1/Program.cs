using System;
using System.IO;
namespace ДЗ_к_5_уроку_1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст, который хотите внести в файл: ");
            string text = Console.ReadLine();
            
            Console.WriteLine("Введите название файла: ");
            string fileName = Console.ReadLine();
            File.AppendAllText(fileName, text);
            string readFile = File.ReadAllText(fileName);
            Console.WriteLine(readFile);
        }
    }
}
