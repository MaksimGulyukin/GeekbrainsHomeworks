using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Привет " + name + "!" + "Сегодня: " + DateTime.Now);

            Console.ReadKey();
        }
    }
}
