using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> fullname = new List<string>();
            Console.WriteLine("Введите 1: Внести новые данные в справочник\nВведите 2: Найти по номеру человека");
            int option = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, string> guide = new Dictionary<int, string>();
            if (option == 1)
            {
                Addendum();
            }
            else 
                if ( option == 2)
            {
                Console.Write("Введите номер: ");
                int _number = Convert.ToInt32(Console.ReadLine());
                if (guide.TryGetValue(_number, out string value))
                {
                    Console.WriteLine($"Для номера: {_number}, Владелец: {0}.", value);
                }
                else
                {
                    Console.WriteLine($"Для номера: {_number}, Владелец не найден.");
                    foreach (KeyValuePair<int, string> e in guide) Console.WriteLine($"{e} ");
                }
            }
            void Addendum()
            {
                string choice = "yes";
                do
                {
                    int count = guide.Count;
                    Console.Write("Введите номер: ");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Введите полностью ФИО: ");
                    fullname.Add($"{Console.ReadLine()}");
                    guide.Add(numbers[count], fullname[count]);
                    Console.WriteLine("Продолжить заполнять справочник? Введите - 1 - 'да' Введите - 2 - 'нет' ");
                    int _option = Convert.ToInt32(Console.ReadLine());
                    if (_option == 2) choice = "no";
                } while (choice == "yes");
            }
            Console.ReadKey();
        }
    }
}
