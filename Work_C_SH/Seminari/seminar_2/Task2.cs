using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_2
{
    /// <summary>
    /// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    /// </summary>
    internal class Task2
    {
        /// <summary>
        /// Запуск задачи 2
        /// </summary>
        public static void Run()
        {
            Random random = new Random(); //создание объекта типа рандом
            int number = random.Next(100, 1000);
            Console.WriteLine(number);
            int sot = number / 100; // находим сотни в трехзначном числе
            int ones = number % 10; // находим единицы в трехзначном числе
            Console.WriteLine(sot);
            Console.WriteLine(ones);
            Console.Write(" " + sot + ones);
            // Варианты вывода ответа:
            //string c = Convert.ToString(sot) + Convert.ToString(ones);
            //Console.WriteLine(c);

            //Console.Write(sot);
            //Console.Write(ones);

            //Console.Write(sot*10 + ones);
        }
    }
}
