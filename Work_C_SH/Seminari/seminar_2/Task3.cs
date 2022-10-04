using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_2
{
    /// <summary>
    /// Напишите программу, которая будет принимать на вход два числа 
    /// и выводить, является ли второе число кратным первому. 
    /// Если число 2 не кратно числу1, то программа выводит остаток от деления.
    /// </summary>
    internal class Task3
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
            if (num2 % num1 == 0)
            {
                Console.WriteLine("второе введенное число кратно первому ");
            }
            else
            {
                int ost = num2 % num1;
                Console.WriteLine("второе введенное число не кратно первому. Остаток: " + ost);
            }
        }

        //Вариант вывода
        //Console.WriteLine("Число " + num2 + "не кратно числу"+ num1 + "Остаток: " + ost);
    }
}
