using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    // <summary>
    ///Напишите программу, которая принимает на вход число
    ///и выдаёт количество цифр в числе.
    /// </summary>
    internal class Task26_2
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите положительное число: ");
            string number = Console.ReadLine();
            Console.WriteLine(number.Length);
        }
    }
}
