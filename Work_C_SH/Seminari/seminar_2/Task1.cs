using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_2
{
    /// <summary>
    /// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
    /// и показывает наибольшую цифру числа.
    /// </summary>
    internal class Task1
    {
        /// <summary>
        /// Запуск задачи 1
        /// </summary>
        public static void Run()
        {
            Random random = new Random(); //создание объекта типа рандом
            int number = random.Next(10, 100);
            Console.WriteLine(number);
            int tens = number / 10; // находим десятки в двузначном числе
            int ones = number % 10; // находим единицы в двузначном числе
            Console.WriteLine(tens);
            Console.WriteLine(ones);

            if (tens > ones)
            {
                Console.Write("наибольшее: " + tens);
            }
            else
            {
                Console.Write("наибольшее: " + ones);
            }
        }
                
    }
}
