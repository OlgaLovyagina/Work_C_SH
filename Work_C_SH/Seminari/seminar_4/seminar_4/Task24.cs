using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    /// <summary>
    /// апишите программу, которая принимает на вход число (А) 
    /// и выдаёт сумму чисел от 1 до А.
    /// </summary>
    internal class Task24
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int num = 15;
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i}");
                sum += i;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
