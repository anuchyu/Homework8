using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rng = new Random();
            Addendum();
            Console.WriteLine("Числа до операции удаления");
            Print();
            Console.WriteLine();
            Delete();
            Console.WriteLine("Числа после операции удаления");
            Print();

            void Addendum()
            {
                for (int i=0; i<=100; i++)
                {
                    numbers.Add(rng.Next(0,101));
                }
            }

            void Print()
            {
                foreach (int i in numbers)
                {
                    Console.Write(i+ " ");
                }
            }

            void Delete()
            {
                numbers.RemoveAll(item => item >= 25 && item <= 50);
            } 
            Console.ReadKey();
        }
    }
}
