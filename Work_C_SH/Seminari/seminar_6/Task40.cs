using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_6
{
    /// <summary>
    /// Напишите программу, которая принимает на вход три
    ///числа и проверяет, может ли существовать треугольник со
    ///сторонами такой длины
    ///Теорема о неравенстве треугольника: каждая сторона треугольника
    ///меньше суммы двух других сторон.
    /// </summary>
    internal class Task40
    {
        /// <summary>
        /// Запуск задачи 
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Введите певое число: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите певое число: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите певое число: ");
            int length3 = Convert.ToInt32(Console.ReadLine());
            if ((length1 + length2) > length3 && (length2 + length3) > length1 && (length1 + length3) > length2)
            {
                Console.WriteLine("треугольник со сторонами такой длины может существовать");
            }
            else
            {
                Console.WriteLine("треугольник со сторонами такой длины  не может существовать");
            }
        }
    }
}
