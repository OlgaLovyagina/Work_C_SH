using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    /// <summary>
    /// на вход два натуральных числа (A и B) и возводит 
    /// число A в степень B
    /// </summary>
    internal class Task25
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите 1-е число: ");
            Console.Write("А =  ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число: ");
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result = num * result;
            }
            Console.WriteLine("Число А в степени В = " + result);
        }
    }
}
