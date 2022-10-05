using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    /// <summary>
    /// Напишите программу, которая принимает на вход число 
    /// и выдаёт произведение чисел от 1 до N.(Факториал)
    /// </summary> 
    internal class Task28
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int product = 1;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}");
                product *= i;
            }
            Console.WriteLine();
            Console.WriteLine($"{product}");
        }
    }
}
