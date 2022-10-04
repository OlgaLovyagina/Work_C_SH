using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    /// <summary>
    ///Напишите программу, которая принимает на вход число
    ///и выдаёт количество цифр в числе.
    /// </summary>
    internal class Task26_1
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            int number = 14124;
            int i = 0;

            while (number > 0)
            {
                number /= 10;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
