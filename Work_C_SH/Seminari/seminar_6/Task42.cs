using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_6
{
    /// <summary>
    /// Напишите программу, которая будет преобразовывать
    ///десятичное число в двоичное
    /// </summary>
    internal class Task42
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (number > 0)
            {
              result = number % 2 + result;
                number /= 2;
            }
            // второй вариант решения задачи:
            //          int number = 43;
            //        string result2 = Convert.ToString(number, 2);

            // перевод обратно из двоичной в десятичную 
            // 101011= 1*2*2*2*2*2 + 0*2*2*2*2 + 1*2*2*2 + 0*2*2 + 1*2 + 1
            Console.WriteLine(result);     
        }
    }
}
