using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_2
{
    /// <summary>
    /// Напишите программу, которая принимает на вход два числа и проверяет, 
    ///является ли одно число квадратом другого.
    /// </summary>
    internal class Task5
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите первое число : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 * num2 || num2 == num1 * num1) 
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");

            // функция возведения в квадрат
            //if(num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
        }
       
        //  Метод для ввода числа
        //int Input()
        //{
        //    Console.WriteLine("Введите число : ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}
    }
}

