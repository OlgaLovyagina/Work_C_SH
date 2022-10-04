using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    /// <summary>
    /// Напишите программу, которая принимает на вход пятизначное число и проверяет,
    ///является ли оно палиндромом.
    /// </summary>
    internal class Task19
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите пятизначное целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int rev = 0;

            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n = n / 10;
            }
            if (num == rev)
            {
                Console.WriteLine("Введеное число является полиндромом ");
            }
            else
            {
                Console.WriteLine("Введеное число не является полиндромом ");
            }
        }
    }
}
