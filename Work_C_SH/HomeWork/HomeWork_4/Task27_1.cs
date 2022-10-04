using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    /// <summary>
    /// принимает на вход число и выдаёт сумму цифр в числе.
    /// </summary>
    internal class Task27_1
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Сумма цифр в числе = {sum}");
        }
    }
}
