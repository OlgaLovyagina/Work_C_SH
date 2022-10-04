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
    internal class Task27
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int current = Math.Abs(number);

            int sum = 0;
            int a = NumberDigits(current);
            for (int i = 0; i < a; i++)
            {
                sum = sum + current % 10;
                current = current / 10;
            }
            Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
        }


        /// <summary>
        /// считает количество цифр в числе
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        static int NumberDigits(int current)
        {
            int i = 0;

            while (current > 0)
            {
                current /= 10;
                i++;
            }
            return i;
        }
    }
}
    

