using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_2
{
    /// <summary>
    /// Напишите программу, которая принимает на вход число и проверяет, 
    ///кратно ли оно одновременно 7 и 23 
    /// </summary>
    internal class Task4
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 && num % 23 == 0) // и
            {
                Console.WriteLine($" число {num} кратно 7 и 23 ");
            }
            else
            {
                Console.WriteLine($" число {num} не кратно 7 и 23");
            }
        }

        
    }
}
