using System;
using System.IO;

namespace ДЗ_к_5_уроку_2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";

            File.AppendAllText(fileName, DateTime.Now.ToString("HH:mm:ss ;"));
            string readFile =File.ReadAllText(fileName);
            Console.WriteLine(readFile);
        }
    }
}
