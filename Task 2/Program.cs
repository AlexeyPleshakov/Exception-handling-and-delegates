using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class SortingException: Exception
    {
        public SortingException(string message) : base(message) { } 
    }

    internal class Program
    {
        static void Main()
        {
            List<string> surnames = new List<string> { "Плешаков", "Жуков", "Вишняков", "Панин", "Пилюгин" };

            Sorter sorter = new Sorter();
            sorter.SortingTriggered += Sort;

            int input;
            do
            {
                Console.WriteLine("Введите 1 для сортировки А-Я, 2 для сортировки Я-А:");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out input))
                {
                    try
                    {
                        sorter.PerformSorting(input, surnames);
                    }
                    catch (SortingException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите 1 или 2.");
                }
            } while(input != 1 && input != 2);
        }

        static void Sort(object sender, List<string> surnames)
        {
            Console.WriteLine("Отсортированный список фамилий:");
            foreach(string surname in surnames)
            {
                Console.WriteLine(surname);
            }
        }
    }
}
