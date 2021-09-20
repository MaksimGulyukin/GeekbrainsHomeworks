using System;

namespace DZ_4_zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetFullName("Васильев", "Николай", "Иванович"));
            Console.WriteLine(GetFullName("Петров", "Петр", "Константинович"));
            Console.WriteLine(GetFullName("Кротов", "Михаил", "Петрович"));
        }

        static string GetFullName(string FirstName, string LastName, string patronymic)
        {
            return $"{FirstName}  {LastName}  {patronymic}";
        }
    }
}
