using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
   /// <summary>
   ///Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
   /// </summary>
    internal class Task26
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
   
        {
            int number = 1234322;
            int current = number;
            int count = 0;
            while (current > 0)
            {
                current = current / 10;
                count = count + 1;
            }
            Console.WriteLine($"Количество цифр в числе {number} = {count}");
        }
    }

}

